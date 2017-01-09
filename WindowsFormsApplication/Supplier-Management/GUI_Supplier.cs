using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Supplier_Management
{
    public partial class GUI_Supplier : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_Supplier Bus_Supplier = new BUS_Supplier();
        ValidationExtensition validation = new ValidationExtensition();
        Authority authority = new Authority();
        string accID;

        public GUI_Supplier(string id)
        {
            InitializeComponent();
            accID = id;
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            lstSuppliers.DataSource = Bus_Supplier.LoadListSupplier();
            lstSuppliers.Columns["Products"].Visible = false;
            lstSuppliers.Columns["ProposeReceipts"].Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == accID && x.NameOfAuthority == "Manage Supplier").Create;
            if (create == true)
            {
                if ((validation.Required(txtName) || validation.Required(txtAddress) || validation.Required(txtPhone) || validation.RegularNumberExpression(txtPhone) || validation.RegularExpression(txtName) || validation.RegularExpression(txtAddress)))
                {
                    String tmp = null;
                    if (validation.Required(txtName))
                    {
                        tmp += "Name can not empty \n";
                    }
                    if (validation.Required(txtAddress))
                    {
                        tmp += "Address can not empty \n";
                    }
                    if (validation.Required(txtPhone))
                    {
                        tmp += "Phone can not empty \n";
                    }
                    if (!validation.Required(txtPhone) && validation.RegularNumberExpression(txtPhone))
                    {
                        tmp += "Phone must be numbers only\n";
                    }
                    if (!validation.Required(txtName) && validation.RegularExpression(txtName))
                    {
                        tmp += "Name not allow special charater\n";
                    }
                    if (!validation.Required(txtAddress) && validation.RegularExpression(txtAddress))
                    {
                        tmp += "Address not allow special charater\n";
                    }
                    if (tmp != null)
                    { MessageBox.Show(tmp); }
                }
                else
                {

                    string id = txtID.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;

                    bool flag = Bus_Supplier.InsertSupplier(id, name, address, phone);
                    if (flag == true)
                    {
                        MessageBox.Show("Create successfully!");
                        LoadSupplier();
                    }
                    else MessageBox.Show("Create Unsuccessfully!");
                }
            }
            else MessageBox.Show("Your account do not have the authority to create Supplier!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == accID && x.NameOfAuthority == "Manage Supplier").Update;
            if (update == true)
            {
                if ((validation.Required(txtName) || validation.Required(txtAddress) || validation.Required(txtPhone) || validation.RegularNumberExpression(txtPhone) || validation.RegularExpression(txtName) || validation.RegularExpression(txtAddress)))
                {
                    String tmp = null;
                    if (validation.Required(txtName))
                    {
                        tmp += "Name can not empty \n";
                    }
                    if (validation.Required(txtAddress))
                    {
                        tmp += "Address can not empty \n";
                    }
                    if (validation.Required(txtPhone))
                    {
                        tmp += "Phone can not empty \n";
                    }
                    if (!validation.Required(txtPhone) && validation.RegularNumberExpression(txtPhone))
                    {
                        tmp += "Phone must be numbers only\n";
                    }
                    if (!validation.Required(txtName) && validation.RegularExpression(txtName))
                    {
                        tmp += "Name not allow special charater\n";
                    }
                    if (!validation.Required(txtAddress) && validation.RegularExpression(txtAddress))
                    {
                        tmp += "Address not allow special charater\n";
                    }
                    if (tmp != null)
                    { MessageBox.Show(tmp); }
                }
                else
                {
                    string id = txtID.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;

                    bool flag = Bus_Supplier.UpdateSupplier(id, name, address, phone);
                    if (flag == true)
                    {
                        MessageBox.Show("Update successfully!");
                        LoadSupplier();
                    }
                    else MessageBox.Show("Update Unsuccessfully!");
                }
            }
            else MessageBox.Show("Your account do not have authority to update Supplier!");
        }

        private void lstSuppliers_DoubleClick(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            CMART0Entities db = new CMART0Entities();

            if (lstSuppliers.SelectedRows.Count == 1)
            {
                var row = lstSuppliers.SelectedRows[0];
                var cell = row.Cells["SupplierID"];
                string ID = (string)cell.Value;
                supplier = db.Suppliers.Single(x => x.SupplierID == ID);
                txtID.Text = supplier.SupplierID;
                txtName.Text = supplier.Name;
                txtAddress.Text = supplier.Address;
                txtPhone.Text = supplier.PhoneNumber;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool delete = db.Authorities.Single(x => x.AccountID == accID && x.NameOfAuthority == "Manage Supplier").Delete;
            if (delete == true)
            {
                if (lstSuppliers.SelectedRows.Count == 1)
                {
                    var row = lstSuppliers.SelectedRows[0];
                    var cell = row.Cells["SupplierID"];
                    string ID = (string)cell.Value;
                    var cellName = row.Cells["Name"];
                    string name = (string)cellName.Value;
                    DialogResult result = MessageBox.Show("Do you really want to delete the supplier \"" + name + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Bus_Supplier.Delete(ID);
                        LoadSupplier();
                    }
                }
            }
            else MessageBox.Show("Your account do not have the authority to delete Supplier!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (validation.RegularExpression(txtSearch))
            { MessageBox.Show("Search not allow special character"); }
            else
            { lstSuppliers.DataSource = Bus_Supplier.Search(txtSearch.Text); }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtAddress.Text= string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }


    }
}
