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
    public partial class GUI_ManageBill : Form
    {
        BUS_ManageBill bus = new BUS_ManageBill();
        public GUI_ManageBill()
        {
            InitializeComponent();
            showform();
        }
        public void showform()
        {
            lstbill.DataSource = bus.getAllListBill();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (checkInputData(txtsearch.Text) == true)
            {
                lstbill.DataSource = bus.searchAllList(txtsearch.Text);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private bool checkInputData(string input)
        {
            if (input != "")
            {
                return true;
            }
            return false;
        }

        private void selectBillToUpdate(object sender, EventArgs e)
        {
            CMART0Entities db = new CMART0Entities();
            if (lstbill.SelectedRows.Count == 1)
            {
                lstbilldetail.Rows.Clear();
                numsoluong.Visible = false;
                var row = lstbill.SelectedRows[0];
                var cell = row.Cells["BillID"];
                string id = (string)cell.Value;
                Bill rs = loadBill(id);
                txtamount.Text = rs.TotalAmount.ToString();
                txtsl.Text = rs.TotalQuantity.ToString();
                dtpsaleday.Value = (DateTime)rs.SaleDate;
                Account s = db.Accounts.Single(st => st.AccountID == rs.AccountID);
                cboaccount.DataSource = db.Accounts.ToList();
                cboaccount.DisplayMember = "FullName";
                cboaccount.ValueMember = "AccountID";
                cboaccount.SelectedValue = s.AccountID;
                txtid.Text = rs.BillID.ToString();
                txtinmoney.Text = rs.InputMoney.ToString();
                txtoutmoney.Text = rs.OutputMoney.ToString();
                txtpos.DataSource = Enumerable.Range(1, 9).ToList();
                txtpos.Text = rs.POS.ToString();
                txtbranch.Text = rs.BillID.ToString().Substring(6, 1);
                List<BillDetail> detail = loadDetailOfBill(id);
                for (int i = 0; i < detail.Count; i++)
                {
                    string prid = detail[i].ProductID;
                    string name = name = db.Products.Single(st => st.ProductID == prid).Name.ToString();
                    float pr = (float)detail[i].Price * detail[i].Quantity;
                    lstbilldetail.Rows.Add(detail[i].ProductID.ToString(), name, detail[i].Quantity, detail[i].Price, pr);
                }
                txtproduct.Visible = true;
            }
        }

        public Bill loadBill(string id)
        {
            return bus.loadBill(id);
        }

        public List<BillDetail> loadDetailOfBill(string id)
        {
            return bus.loadDetailOfBill(id);
        }

        private void clickSaveButton(object sender, EventArgs e)
        {
            CMART0Entities db = new CMART0Entities();
            string sum = sumExtension();
            if (txtid.Text != "")
            {
                if (sum == "")
                {

                    //Save Bill Detail
                    bus.updateBillDetail(lstbilldetail, txtid);

                    //Save Bill
                    if (checkNullData())
                    {
                        Bill update = new Bill();
                        update.BillID = txtid.Text;
                        update.SaleDate = dtpsaleday.Value;
                        update.POS = int.Parse(txtpos.Text);
                        update.TotalAmount = float.Parse(txtamount.Text);
                        update.TotalQuantity = int.Parse(txtsl.Text);
                        update.InputMoney = float.Parse(txtinmoney.Text);
                        update.OutputMoney = float.Parse(txtoutmoney.Text);
                        update.AccountID = (string)cboaccount.SelectedValue;
                        if (bus.updateBill(update))
                        {
                            MessageBox.Show("Update bill successfully");
                            lstbilldetail.Rows.Clear();
                            txtsl.Text = "0";
                            txtamount.Text = "0";
                            txtoutmoney.Text = "0";
                            txtinmoney.Text = "";
                            txtproduct.Text = "";
                            txtpos.Text = "";
                            cboaccount.Text = "";
                            txtid.Text = "";
                            dtpsaleday.Value = DateTime.Today;

                        }
                        else
                        {
                            MessageBox.Show("Update bill unsuccessfully");
                        }
                        showform();

                    }
                }
                else
                {
                    MessageBox.Show(sum);
                }
            }
            else
            {
                MessageBox.Show("Select a bill to update");
            }
            


        }
        private bool checkNullData()
        {
            if (txtamount.Text == null || txtinmoney.Text == null || txtoutmoney.Text == null || txtpos.Text == null || txtsl.Text == null || cboaccount.Text == null)
            {
                return false;
            }
            return true;

        }

        private string sumExtension()
        {
            ValidationBill validate = new ValidationBill();
            string sumextension = "";
            if (validate.Requiredcbo(txtpos) == false)
            {
                sumextension += "\n Pos wrong";
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
            if (validate.Requiredcbo(cboaccount) == false)
            {
                sumextension += "\n User not null";
            }
            if (validate.RangeDatagridview(lstbilldetail) == false)
            {
                sumextension += "\n Bill must have product";
            }
            return sumextension;
        }

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {
            CMART0Entities db = new CMART0Entities();
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
                quantity_amount_outmoney();

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

        private bool checkexitProductid(string id)
        {
            return bus.checkexitProductid(id);
        }

        private float countmoney(string id, int number)
        {
            return bus.countmoney(id, number);
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
            object price = lstbilldetail.SelectedRows[0].Cells["Price"].Value;
            float sum = a * float.Parse(price.ToString());
            lstbilldetail.SelectedRows[0].Cells["Total"].Value = sum;
            //Show total quantity,total amount
            quantity_amount_outmoney();
        }

        private void quantity_amount_outmoney()
        {
            int soluong1 = 0;
            float amount1 = 0;

            for (int i = 0; i < lstbilldetail.Rows.Count - 1; i++)
            {
                soluong1 += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                amount1 += float.Parse(lstbilldetail.Rows[i].Cells["Total"].Value.ToString());
            }

            txtsl.Text = soluong1.ToString();
            txtamount.Text = amount1.ToString();
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
                if (txtinmoney.Text == "" && txtamount.Text == "0")
                {

                }
                else
                {
                    MessageBox.Show("Must input number in this field");
                }

            }

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            lstbilldetail.Rows.Clear();
            txtsl.Text = "0";
            txtamount.Text = "0";
            txtoutmoney.Text = "0";
            txtinmoney.Text = "";
            txtproduct.Text = "";
            txtpos.Text = "";
            cboaccount.Text = "";
            txtid.Text = "";
            dtpsaleday.Value = DateTime.Today;
        }

        private void lstbilldetail_DoubleClick(object sender, EventArgs e)
        {
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
                    for (int i = 0; i < lstbilldetail.RowCount - 1; i++)
                    {
                        soluong += (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                        amount += float.Parse(lstbilldetail.Rows[i].Cells["Total"].Value.ToString());
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

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                GUI_Review f = new GUI_Review(txtid.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a bill to print");
            }
            
        }
    }
}
