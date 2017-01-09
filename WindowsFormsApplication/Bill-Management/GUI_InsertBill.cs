using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Bill_Management
{
    public partial class GUI_InsertBill : Form
    {
        BUS_InsertBill bus = new BUS_InsertBill();
        CMART0Entities db = new CMART0Entities();
        Authority authority = new Authority();
        string getAccount;

        public GUI_InsertBill(string id)
        {
            InitializeComponent();
            getAccount = id;
            txtpos.DataSource = Enumerable.Range(1, 9).ToList();
            txtbranch.DataSource = Enumerable.Range(1, 2).ToList();
            txtuser.Text = id;
        }

        private bool checkexitProductid(string id)
        {
            return bus.checkexitProductid(id);
        }

        private float countmoney(string id, int number)
        {
            return bus.countmoney(id, number);
        }

        private void showProductInfo(object sender, EventArgs e)
        {
            if (checkexitProductid(txtproduct.Text))
            {
                int a = 0;
                Product add = db.Products.Single(st => st.ProductID == txtproduct.Text);
                int quantity = 1;
                float sum = countmoney(add.ProductID.ToString(), quantity);
                if (sum != -1)
                {
                    float price = sum / quantity;
                    string id = txtproduct.Text;
                    string name = add.Name;
                    for (int i = 0; i < lstbilldetail.RowCount; i++)
                    {
                        try
                        {
                            if (lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString() == id && float.Parse(lstbilldetail.Rows[i].Cells["Price"].Value.ToString()) == sum)
                            {
                                quantity += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                                sum = countmoney(add.ProductID.ToString(), quantity);
                                lstbilldetail.Rows.Remove(lstbilldetail.Rows[i]);
                                lstbilldetail.Rows.Add(id, name, quantity, price, sum);
                                break;
                            }
                            if (lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString() == id && float.Parse(lstbilldetail.Rows[i].Cells["Price"].Value.ToString()) != sum)
                            {
                                lstbilldetail.Rows.Add(id, name, quantity, price, sum);
                                break;
                            }
                        }
                        catch
                        {
                            a = 1;
                        }

                    }
                    if (a == 1)
                    {
                        lstbilldetail.Rows.Add(id, name, quantity, price, sum);
                    }
                    txtproduct.Text = "";
                }
                else
                {
                    txtproduct.Text = "";
                    MessageBox.Show("This product has no price");
                }
                

                //Show total quantity,total amount
                int soluong = 0;
                float amount = 0;
                try
                {
                    for (int i = 0; i < lstbilldetail.RowCount; i++)
                    {
                        soluong += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                        amount += (float)lstbilldetail.Rows[i].Cells["Total"].Value;
                    }
                }
                catch
                {

                }
                txtsl.Text = soluong.ToString();
                txtamount.Text = amount.ToString();
                //show outmoney
                try
                {
                    float outp = float.Parse(txtinmoney.Text) - float.Parse(txtamount.Text);
                    if (outp < 0)
                    {
                        txtoutmoney.Text = "0";
                    }
                    else
                    {
                        txtoutmoney.Text = outp.ToString();
                    }
                }
                catch
                {
                    txtoutmoney.Text = "0";
                }


            }
            else
            {
                if (txtproduct.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("ProductID not correct");
                }

            }

        }

        private void createbillbutton(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Invoice").Create;
            if (create == true)
            {
                string sum = sumExtension();
                if (sum == "")
                {
                    string rs = bus.createBilldetail(lstbilldetail, txtamount, txtsl, txtinmoney, txtoutmoney, txtbranch, txtpos, txtuser);
                    if (rs != "false")
                    {
                        MessageBox.Show("Create Bill successfully");
                        GUI_Review f = new GUI_Review(rs);
                        f.ShowDialog();
                        lstbilldetail.Rows.Clear();
                        txtsl.Text = "0";
                        txtamount.Text = "0";
                        txtoutmoney.Text = "0";
                        txtinmoney.Text = "";
                        txtproduct.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Create Bill unsuccessfully");
                    }

                }
                else
                {
                    MessageBox.Show(sum);
                }
            }
            else MessageBox.Show("Your account do not have the authority to create Invoice!");
        }

        private string sumExtension()
        {
            ValidationBill validate = new ValidationBill();
            string sumextension = "";
            if (validate.Requiredcbo(txtpos) == false)
            {
                sumextension += "\n Choose another POS";
            }
            if (validate.Requiredcbo(txtbranch) == false)
            {
                sumextension += "\n Choose another Branch";
            }
            if (validate.Required(txtinmoney) == false)
            {
                sumextension += "\n Pay money not null";
            }
            if (validate.Required(txtinmoney) == true)
            {
                if (validate.Compared(float.Parse(txtamount.Text), float.Parse(txtinmoney.Text)) == false)
                {
                    sumextension = "\n Pay money not lower than total money";
                }
            }
            if (validate.RangeDatagridview(lstbilldetail) == false)
            {
                sumextension += "\n Bill must have product";
            }
            return sumextension;
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ManageBill f = new GUI_ManageBill();
            f.ShowDialog();
        }

        private void lstbilldetail_DoubleClick(object sender, EventArgs e)
        {
            bool delete = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Invoice").Delete;
            if (delete == true)
            {
                ValidationBill vali = new ValidationBill();
                if (lstbilldetail.SelectedRows.Count == 1 && lstbilldetail.SelectedRows[0].Cells["ProductID"].Value != null)
                {
                    DialogResult rs = MessageBox.Show("Do you want to delete this?", "Delete Row", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        lstbilldetail.Rows.Remove(this.lstbilldetail.SelectedRows[0]);
                    }
                    int soluong = 0;
                    float amount = 0;
                    try
                    {
                        for (int i = 0; i < lstbilldetail.RowCount; i++)
                        {
                            soluong += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                            amount += (float)lstbilldetail.Rows[i].Cells["Total"].Value;
                        }
                    }
                    catch
                    {

                    }
                    txtsl.Text = soluong.ToString();
                    txtamount.Text = amount.ToString();
                    numsoluong.Visible = false;
                    try
                    {
                        float outp = float.Parse(txtinmoney.Text) - float.Parse(txtamount.Text);
                        if (outp < 0)
                        {
                            txtoutmoney.Text = "0";
                        }
                        else
                        {
                            txtoutmoney.Text = outp.ToString();
                        }
                    }
                    catch
                    {
                        txtoutmoney.Text = "0";
                    }
                }
            }
            else MessageBox.Show("Your account do not have the authority to delete Invoice!");
        }

        private void lstbilldetail_Click(object sender, EventArgs e)
        {
            if (lstbilldetail.SelectedRows.Count == 1 && lstbilldetail.SelectedRows[0].Cells["ProductID"].Value != null)
            {
                numsoluong.Visible = true;
                numsoluong.Value = int.Parse(lstbilldetail.SelectedRows[0].Cells["Quantity"].Value.ToString());
            }
            else
            {
                numsoluong.Visible = false;
            }
        }

        private void numsoluong_ValueChanged(object sender, EventArgs e)
        {
            int a = (int)numsoluong.Value;
            lstbilldetail.SelectedRows[0].Cells["Quantity"].Value = a;
            float sum = a * (float)lstbilldetail.SelectedRows[0].Cells["Price"].Value;
            lstbilldetail.SelectedRows[0].Cells["Total"].Value = sum;
            //Show total quantity,total amount
            int soluong = 0;
            float amount = 0;
            try
            {
                for (int i = 0; i < lstbilldetail.RowCount; i++)
                {
                    soluong += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                    amount += (float)lstbilldetail.Rows[i].Cells["Total"].Value;
                }
            }
            catch
            {

            }
            txtsl.Text = soluong.ToString();
            txtamount.Text = amount.ToString();
            //show outmoney
            try
            {
                float outp = float.Parse(txtinmoney.Text) - float.Parse(txtamount.Text);
                if (outp < 0)
                {
                    txtoutmoney.Text = "0";
                }
                else
                {
                    txtoutmoney.Text = outp.ToString();
                }
            }
            catch
            {
                txtoutmoney.Text = "0";
            }
        }

        private void txtinmoney_TextChanged(object sender, EventArgs e)
        {
            ValidationBill validate = new ValidationBill();
            if (validate.CheckNumTextbox(txtinmoney) == true)
            {
                if (validate.RangeDatagridview(lstbilldetail) == true)
                {
                    try
                    {
                        float outp = float.Parse(txtinmoney.Text) - float.Parse(txtamount.Text);
                        if (outp < 0)
                        {
                            txtoutmoney.Text = "0";
                        }
                        else
                        {
                            txtoutmoney.Text = outp.ToString();
                        }
                    }
                    catch
                    {
                        txtoutmoney.Text = "0";
                    }
                }
                else
                {
                    txtoutmoney.Text = txtinmoney.Text;
                }
            }
            else
            {
                if ((txtinmoney.Text == "" && txtamount.Text == "0"))
                {

                }
                else
                {
                    MessageBox.Show("Must input number in this field");
                }

            }


        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you want to cancle this bill?", "Cancle bill", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                lstbilldetail.Rows.Clear();
                txtsl.Text = "0";
                txtamount.Text = "0";
                txtoutmoney.Text = "0";
                txtinmoney.Text = "";
                txtproduct.Text = "";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MainFrm main = new GUI_MainFrm(getAccount);
            main.Closed += (s, args) => this.Close();
            main.ShowDialog();
        }
    }
}
