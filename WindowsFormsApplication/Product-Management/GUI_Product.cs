using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Category_Management;

namespace WindowsFormsApplication.Product_Management
{
    public partial class frmGUI : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_Product f = new BUS_Product();
        BUS_Category Bus_Category = new BUS_Category();
        ValidationProduct val = new ValidationProduct();
        public frmGUI()
        {
            InitializeComponent();
            this.load();
        }
        public void load()
        {
            this.lstProduct.DataSource = f.load();
            cbocategory.DataSource = db.Categories.ToList();
            cbocategory.ValueMember = "CategoryID";
            cbocategory.DisplayMember = "Name";
            //cbocategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbocategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbosup.DataSource = db.Suppliers.ToList();
            cbosup.ValueMember = "SupplierID";
            cbosup.DisplayMember = "Name";
            //cbosup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbosup.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lstProduct.DataSource = f.search(txtTimKiem.Text);
        }

        private void lstProduct_DoubleClick(object sender, EventArgs e)
        {
            if (lstProduct.SelectedRows.Count == 1) // if select only one row
            {

                var row = lstProduct.SelectedRows[0]; // get the selected row
                var cell = row.Cells["ProductID"]; // get the id cell of the row
                String id = (String)cell.Value; // get the id value from the cell
                Product rs = db.Products.Single(st => st.ProductID == id);
                txtMa.Text = rs.ProductID;
                txtTen.Text = rs.Name;

                txtDuongDan.Text = rs.Image;
                cbocategory.SelectedValue = rs.CategoryID;
                cbosup.SelectedValue = rs.SupplierID;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (val.Required(txtTen))
            {
                MessageBox.Show("Name is required!");
            }
            else
            {
                //Product pro = new Product();
                String Category = (string)cbocategory.SelectedValue;
                Category category = db.Categories.Single(x => x.CategoryID == Category);
                int quantity = (int)++category.Quantity;
                String Name = txtTen.Text;
                //Product pro = db.Products.Single(x => x.Name == Name);
                string Image = Name+Path.GetExtension(txtDuongDan.Text);

                String Supplier = (string)cbosup.SelectedValue;

                bool flag = f.insertProduct(Name, Image, Supplier, Category);
                if (flag == true)
                {
                    Bus_Category.UpdateCategory2(Category, quantity);
                    load();
                    MessageBox.Show("Insert success");
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String id = txtMa.Text;
            String Name = txtTen.Text;
            String Image = txtDuongDan.Text;
            String Supplier = cbosup.Text;
            String Category = cbocategory.Text;
            bool flag = f.updateProduct(id, Name, Supplier, Category, Image);
            if (flag == true)
            {
                MessageBox.Show("Update successfully!");
            }
            else
            {
                MessageBox.Show("Update unsuccessfully!");
            }
            load();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtMa.Text = string.Empty;
            txtDuongDan.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedRows.Count == 1)
            {
                var row = lstProduct.SelectedRows[0];
                var cellProductName = row.Cells["Name"];
                string name = (string)cellProductName.Value;
                DialogResult result = MessageBox.Show("Do you really want to delete the product \"" + name + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var cellProductID = row.Cells["ProductID"];
                    string id = (string)cellProductID.Value;
                    var cellCategoryID = row.Cells["CategoryName"];
                    string categoryName = cellCategoryID.Value.ToString();
                    string category = db.Categories.Single(x => x.Name == categoryName).CategoryID;
                    Category cat = db.Categories.Single(x => x.CategoryID == category);
                    int quantity = (int)--cat.Quantity;
                    var flag = f.Delete(id);
                    if (flag == true)
                    {
                        Bus_Category.UpdateCategory2(category, quantity);
                        MessageBox.Show("Deleted");
                        load();
                    }
                    else MessageBox.Show("Delete unsuccessfully!");
                }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = opf.FileName;
                //pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        //public static bool HinhHopLe(this OpenFileDialog ful)
        //{
        //    if (!ful.HasFile) return false;
        //    //chi kiem tra upload 1 file:
        //    if (ful.AllowMultiple) return false;
        //    var ex = Path.GetExtension(ful.FileName).ToLower();
        //    string[] hinhs = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
        //    var ok = hinhs.Contains(ex);
        //    if (ful.FileContent.Length > 4 * 1024 * 1024)
        //        ok = false;
        //    return ok;
        //}
    }
}
