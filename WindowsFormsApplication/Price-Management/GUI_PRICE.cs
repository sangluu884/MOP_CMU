using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.PRICE
{
    public partial class GUI_PRICE : Form
    {
        String id = null;
        CMART0Entities db = new CMART0Entities();
        BUS_PRICE bus = new BUS_PRICE();
        ValidationExtensition validation = new ValidationExtensition();
        Authority authority = new Authority();
        string getAccount;

        public GUI_PRICE(string id)
        {
            InitializeComponent();
            getAccount = id;
            GUI_PRICE_Load();
        }

        private void GUI_PRICE_Load()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            lstReceipt.DataSource = bus.loadList();
            lstReceipt.Columns["Product"].Visible = false;
            cbbProductID.DataSource = DataAccess.Products.ToList();
            cbbProductID.ValueMember = "ProductID";
            cbbProductID.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Price").Create;
            if (create == true)
            {
                string tmp = null;
                if (validation.Required(txtPrice) || validation.RegularNumberExpression(txtPrice))
                {
                    if (validation.Required(txtPrice))
                    {
                        tmp += "Price can not empty";
                    }
                    if (!validation.Required(txtPrice) && validation.RegularNumberExpression(txtPrice))
                    {
                        tmp += "Price must be number";
                    }
                    MessageBox.Show(tmp);
                }
                else
                {
                    String ProductID = (String)cbbProductID.SelectedValue;
                    float price = float.Parse(txtPrice.Text);
                    DateTime date = DTPDate.Value;
                    if (date >= DateTime.Today)
                    {
                        bool flag = bus.insertPRICE(ProductID, price, date);
                        if (flag == true)
                        {
                            MessageBox.Show("Insert success");
                        }
                        else
                        {
                            MessageBox.Show("Insert Fail");
                        }
                        GUI_PRICE_Load();
                    }
                    else MessageBox.Show("Effective date is not valid!");
                }
            }
            else MessageBox.Show("Your account do not have the authority to create Price!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Price").Update;
            if (update == true)
            {
                String ProductID = (String)cbbProductID.SelectedValue;
                float price = float.Parse(txtPrice.Text);
                DateTime date = DTPDate.Value;
                bool flag = bus.updatePRICE(ProductID, price, date);
                if (flag == true)
                {
                    MessageBox.Show("Edit Successfully!");
                }
                else
                {
                    MessageBox.Show("Edit Unsuccessfully!");
                }
                GUI_PRICE_Load();
            }
            else MessageBox.Show("Your account do not have the authority to update Price!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool delete = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Price").Delete;
            if (delete == true)
            {
                string tmp = null;
                if (validation.Required(txtPrice) || validation.RegularNumberExpression(txtPrice))
                {
                    if (validation.Required(txtPrice))
                    {
                        tmp += "Price can not empty";
                    }
                    if (!validation.Required(txtPrice) && validation.RegularNumberExpression(txtPrice))
                    {
                        tmp += "Price must be number";
                    }
                    MessageBox.Show(tmp);
                }
                else
                {
                    String ProductID = (String)cbbProductID.SelectedValue;
                    string productName = db.Products.Single(x => x.ProductID == ProductID).Name;
                    float price = float.Parse(txtPrice.Text);
                    DateTime date = DTPDate.Value;
                    DialogResult result = MessageBox.Show("Do you really want to delete the price of \"" + productName + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool flag = bus.deletePRICE(ProductID, price, date);
                        if (flag == true)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Delete unsuccessfully!");
                        }
                    }
                    GUI_PRICE_Load();
                }
            }
            else MessageBox.Show("Your account do not have the authority to delete Price!");
        }

        private void lstReceipt_Click(object sender, EventArgs e)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            Price price = new Price();
            if (lstReceipt.SelectedRows.Count == 1)
            {
                var row = lstReceipt.SelectedRows[0];
                var cellProductID = row.Cells[0];
                var cellPrice = row.Cells[1];
                String ID = (String)cellProductID.Value;
                double PriceC = (double)cellPrice.Value;
                id = ID;
                price = DataAccess.Prices.Single(st => st.ProductID == ID && st.Price1 == PriceC);
                txtPrice.Text = price.Price1.ToString();
                DTPDate.Text = price.EffectiveDay.ToShortDateString();
                cbbProductID.SelectedValue = price.ProductID;
               
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if(validation.RegularExpression(Search))
            {
                MessageBox.Show("Search not allow special character");
            }
            else
            {lstReceipt.DataSource = bus.search(Search.Text);}
            
        }

    }
}
