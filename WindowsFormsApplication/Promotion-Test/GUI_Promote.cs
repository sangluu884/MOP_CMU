using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Promotion_Test
{
    public partial class GUI_Promote : Form
    {
        CMART0Entities db = new CMART0Entities();
        ValidationExtensition v = new ValidationExtensition();
        BUS_Promotion Bus_Promotion = new BUS_Promotion();
        Authority authority = new Authority();
        string getAccount;

        public GUI_Promote(string id)
        {
            InitializeComponent();
            getAccount = id;
        }

        private void GUI_Promote_Load(object sender, EventArgs e)
        {
            CMART0Entities db = new CMART0Entities();
            Price price = new Price();
            lstPromotion.DataSource = Bus_Promotion.loadListPromotion().ToList();
            lstPromotion.Columns["Product"].Visible = false;
            cboProduct.DataSource = db.Products.ToList();
            cboProduct.ValueMember = "ProductID";
            cboProduct.DisplayMember = "Name";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Promotion").Create;
            if (create == true)
            {
                string tmp = null;
                if (v.Required(txtPrice) || v.Required(txtContent) || v.RegularNumberExpression(txtPrice))
                {
                    if (v.Required(txtPrice))
                    {
                        tmp += "Price can't empty \n";
                    }
                    if (v.Required(txtContent))
                    {
                        tmp += "Content can't empty \n";
                    }
                    if (!v.Required(txtPrice) && v.RegularNumberExpression(txtPrice))
                    {
                        tmp += "Price must be numbers \n";
                    }
                    MessageBox.Show(tmp);
                }

                else
                {
                    string id = txtID.Text;
                    float price = float.Parse(txtPrice.Text.ToString());
                    DateTime start = dtDateStart.Value;
                    DateTime end = dtpEndDate.Value;
                    string content = txtContent.Text;
                    string productID = (string)cboProduct.SelectedValue;
                    Product product = db.Products.SingleOrDefault(x => x.ProductID == productID);
                    var tam = txtImage.Text;
                    string image = null;
                    if (tam != string.Empty)
                    {
                        image = product.Name + Path.GetExtension(txtImage.Text);
                    }
                    else
                    {
                        image = "";
                    }

                    Promotion promote = db.Promotions.FirstOrDefault(x => x.ProductID == productID);
                    if (promote == null)
                    {
                        if (start >= DateTime.Today && end.Date >= start.Date)
                        {
                            if (Bus_Promotion.Insert(id, price, start, end, content, image, productID) == true)
                            {
                                MessageBox.Show("Create Sucessfully!");
                                GUI_Promote_Load(null, null);
                                txtContent.Text = txtPrice.Text = txtImage.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Create Unsuccessfully!");
                            }
                        }
                        else MessageBox.Show("Start Date or End Date is not valid!");
                    }
                    else
                    {
                        MessageBox.Show("Promotion is existed");
                    }
                }
            }
            else MessageBox.Show("Your account do not have the authority to create Promotion!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstPromotion.DataSource = Bus_Promotion.search(txtSearch.Text).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             bool delete = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Promotion").Delete;
             if (delete == true)
             {
                 if (lstPromotion.SelectedRows.Count == 1)
                 {
                     var row = lstPromotion.SelectedRows[0];
                     var cell = row.Cells["PromotionID"];
                     string ID = (string)cell.Value;
                     DialogResult result = MessageBox.Show("Do you really want to delete the supplier \"" + ID + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (result == DialogResult.Yes)
                     {
                         Bus_Promotion.Delete(ID);
                         GUI_Promote_Load(null, null);
                     }
                 }
             }
             else MessageBox.Show("Your account do not have the authority to delete Promotion!");
        }

        private void lstPromotion_DoubleClick(object sender, EventArgs e)
        {
            Promotion pro = new Promotion();
            if (lstPromotion.SelectedRows.Count == 1)
            {
                var row = lstPromotion.SelectedRows[0];
                var cell = row.Cells["PromotionID"];
                string ID = (string)cell.Value;
                pro = db.Promotions.Single(x => x.PromotionID == ID);
                txtID.Text = ID;
                cboProduct.Text = pro.Product.Name;
                txtImage.Text = pro.Image;
                dtDateStart.Text = pro.StartDate.ToString();
                txtPrice.Text = pro.PromotionPrice.ToString();
                txtContent.Text = pro.Content;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Promotion").Update;
            if (update == true)
            {
                string id = txtID.Text;
                string proID = (string)cboProduct.SelectedValue;

                Product product = db.Products.Single(x => x.ProductID == proID);
                string img = null;
                if (txtImage.Text != string.Empty)
                {
                    img = product.Name + Path.GetExtension(txtImage.Text);
                }
                else img = "";

                DateTime start = dtDateStart.Value;
                DateTime end = dtpEndDate.Value;
                //DateTime date = DateTime.Parse(dtDateStart.Value);
                if (start >= DateTime.Now && end >= start)
                {
                    float price = float.Parse(txtPrice.Text);
                    string cont = txtContent.Text;
                    bool flag = Bus_Promotion.Update(id, price, start, end, cont, img, proID);
                    if (flag == true)
                    {
                        MessageBox.Show("Update promotion successfully!");
                    }
                    else MessageBox.Show("Update promotion unsuccessfully!");
                    txtContent.Text = txtPrice.Text = txtImage.Text = "";
                    GUI_Promote_Load(null, null);
                }
                else MessageBox.Show("End Date is not valid!");
            }
            else MessageBox.Show("Your account do not have the authority to update Promotion!");
        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            CMART0Entities db = new CMART0Entities();
            string name = cboProduct.Text.ToString();
            try
            {
                Price price = db.Prices.SingleOrDefault(x => x.Product.Name == name);
                if (price != null)
                {
                    Product chon = db.Products.Single(x => x.Name == name);
                    string id = chon.ProductID.ToString();
                    txtOldPrice.Text = db.Prices.Single(x => x.ProductID == id).Price1.ToString();
                }
                else txtOldPrice.Text = "Please set price!";
            }
            catch
            {

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = opf.FileName;
                //pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
