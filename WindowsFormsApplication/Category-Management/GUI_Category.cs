using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Category_Management
{
    public partial class GUI_Category : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_Category Bus_Category = new BUS_Category();
        ValidationExtensition validation = new ValidationExtensition();
        Authority authority = new Authority();
        string getAccount;

        public GUI_Category(string id)
        {
            InitializeComponent();
            getAccount = id;
            this.LoadCategory();
        }

        private void LoadCategory()
        {
            lstCategories.DataSource = Bus_Category.LoadListCategory();
            lstCategories.Columns["Products"].Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Category").Create;
            if (create == true)
            {
                if (validation.Required(txtName))
                {
                    MessageBox.Show("Name can not empty");
                }
                else
                {
                    string id = txtID.Text;
                    string name = txtName.Text;
                    int quantity = 0;
                    Bus_Category.InsertCategory(id, name, quantity);
                    MessageBox.Show("Create category successfully!");
                    LoadCategory();
                }
            }
            else MessageBox.Show("Your account do not have the authority to create Category!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Category").Update;
            if (update == true)
            {
                Category category = new Category();
                string id = txtID.Text;
                string name = txtName.Text;
                int quantity = (int)db.Categories.Single(x => x.CategoryID == id).Quantity;
                Bus_Category.UpdateCategory(id, name, quantity);
                MessageBox.Show("Update category successfully!");
                LoadCategory();
            }
            else MessageBox.Show("Your account do not have the authority to update Category!");
        }

        private void lstCategories_DoubleClick(object sender, EventArgs e)
        {
            Category category = new Category();
            CMART0Entities db = new CMART0Entities();

            if (lstCategories.SelectedRows.Count == 1)
            {
                var row = lstCategories.SelectedRows[0];
                var cell = row.Cells["CategoryID"];
                string categoryID = (string)cell.Value;
                category = db.Categories.Single(x => x.CategoryID == categoryID);
                txtID.Text = category.CategoryID;
                txtName.Text = category.Name;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool delete = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Category").Delete;
            if (delete == true)
            {
                if (lstCategories.SelectedRows.Count == 1)
                {
                    var row = lstCategories.SelectedRows[0];
                    var cell = row.Cells["CategoryID"];
                    string categoryID = (string)cell.Value;
                    DialogResult result = MessageBox.Show("Do you really want to delete the category \"" + categoryID + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool flag = Bus_Category.DeleteCategory(categoryID);
                        if (flag == true)
                        {
                            LoadCategory();
                            MessageBox.Show("Deleted");
                        }
                        else MessageBox.Show("Delete unsuccessfully!");
                    }
                }
            }
            else MessageBox.Show("Your account do not have the authority to delete Category!");
        }
    }
}
