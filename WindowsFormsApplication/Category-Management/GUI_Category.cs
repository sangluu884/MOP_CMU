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
        BUS_Category Bus_Category = new BUS_Category();
        public GUI_Category()
        {
            InitializeComponent();
            this.LoadCategory();
        }

        private void LoadCategory()
        {
            lstCategories.DataSource = Bus_Category.LoadListCategory();
            lstCategories.Columns["Products"].Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            int quantity = 0;
            Bus_Category.InsertCategory(id,name,quantity);
            MessageBox.Show("Create category successfully!");
            LoadCategory();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            CMART0Entities db = new CMART0Entities();
            string id = txtID.Text;
            string name = txtName.Text;
            int quantity = (int)db.Categories.Single(x => x.CategoryID == id).Quantity;
            Bus_Category.UpdateCategory(id, name, quantity);
            MessageBox.Show("Update category successfully!");
            LoadCategory();
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
            if (lstCategories.SelectedRows.Count == 1)
            {
                var row = lstCategories.SelectedRows[0];
                var cell = row.Cells["CategoryID"];
                string accountID = (string)cell.Value;
                Bus_Category.DeleteCategory(accountID);
                LoadCategory();
            }
        }
    }
}
