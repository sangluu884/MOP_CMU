using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ProposeReceipt_Management
{
    public partial class GUI_ProposedDetail : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_ProposedDetail Bus_Detail = new BUS_ProposedDetail();
        Authority authority = new Authority();
        string getAccount;

        public GUI_ProposedDetail(string id)
        {
            InitializeComponent();
            getAccount = id;
            LoadDetail();
        }

        private void LoadDetail()
        {
            cboProposedID.DataSource = db.ProposeReceipts.ToList();
            cboProposedID.ValueMember = "ProposeID";
            cboProposedID.DisplayMember = "ProposeID";

            cboProduct.DataSource = db.Products.ToList();
            cboProduct.ValueMember = "ProductID";
            cboProduct.DisplayMember = "Name";

            DataGridViewTextBoxColumn dtgProduct = new DataGridViewTextBoxColumn();
            dtgProduct.HeaderText = "Product";
            DataGridViewTextBoxColumn dtgQuantity = new DataGridViewTextBoxColumn();
            dtgQuantity.HeaderText = "Quantity";
            lstProduct.Columns.Add(dtgProduct);
            lstProduct.Columns.Add(dtgQuantity);
            lstProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnUpdate.Enabled = false;
        }

        public void LoadListMainDetail()
        {
            string proposedID = (string)cboProposedID.SelectedValue;
            lstDetails.DataSource = db.ProposeReceiptDetails.Where(x => x.ProposeID == proposedID).ToList();
            lstDetails.Columns["ProposeReceipt"].Visible = false;
            lstDetails.Columns["Product"].Visible = false;
        }

        public void Clean()
        {
            nmrQuantity.Value = 1;
            lstProduct.Rows.Clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Propose Receipts Detail").Create;
            if (create == true)
            {
                bool message = false;
                string proposedID = (string)cboProposedID.SelectedValue;

                foreach (DataGridViewRow row in lstProduct.Rows)
                {
                    try
                    {
                        string productID = row.Cells[0].Value.ToString();
                        int qu = int.Parse(row.Cells[1].Value.ToString());
                        string proID = db.Products.Single(x => x.Name == productID).ProductID;
                        var checkExistProduct = Find(proID, proposedID);
                        if (checkExistProduct == null)
                        {
                            bool flag = Bus_Detail.InsertProposedDetail(proID, proposedID, qu);
                            if (flag == true)
                            {
                                message = true;
                            }
                            else
                            {
                                message = false;
                            }
                        }
                        else MessageBox.Show("The product " + checkExistProduct.ProductID + " is exist!");
                    }
                    catch
                    {

                    }
                }
                if (message == true)
                {
                    MessageBox.Show("Create Proposed Detail successfully!");
                    LoadListMainDetail();
                    Clean();
                }
                else MessageBox.Show("Create Proposed Detail unsuccessfully!");
            }
            else MessageBox.Show("Your account do not have the authority to add Proposed Receipt Detail!");
        }

        public ProposeReceiptDetail Find(string productID, string proposedID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.ProposeReceiptDetails.FirstOrDefault(x => x.ProposeID == proposedID && x.ProductID == productID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string product = (string)cboProduct.SelectedValue;
            string proposed = db.Products.Single(x => x.ProductID == product).Name;
            int quantity = int.Parse(nmrQuantity.Value.ToString());
            lstProduct.Rows.Add(proposed, quantity);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedRows.Count == 1)
            {
                var row = lstProduct.SelectedRows[0];
                var cellProduct = row.Cells[0];
                var cellQuantity = row.Cells[1];
                string id = (string)cellProduct.Value;
                int quantity = int.Parse(cellQuantity.Value.ToString());
                lstProduct.Rows.RemoveAt(this.lstProduct.SelectedRows[0].Index);
            }
        }

        private void cboProposedID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string proposedID = (string)cboProposedID.SelectedValue;

                lstDetails.DataSource = Bus_Detail.LoadListProposedDetail(proposedID);
                lstDetails.Columns["ProposeReceipt"].Visible = false;
                lstDetails.Columns["Product"].Visible = false;
            }
            catch
            {

            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmrQuantity.Value = 1;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void lstDetails_DoubleClick(object sender, EventArgs e)
        {
            ProposeReceiptDetail detail = new ProposeReceiptDetail();
            CMART0Entities db = new CMART0Entities();

            if (lstDetails.SelectedRows.Count == 1)
            {
                var row = lstDetails.SelectedRows[0];
                var cellProduct = row.Cells["ProductID"];
                var cellQuantity = row.Cells["Quantity"];
                string product = (string)cellProduct.Value;
                string productName = db.Products.Single(x => x.ProductID == product).Name;
                int quantity = int.Parse(cellQuantity.Value.ToString());
                cboProduct.Text = productName;
                nmrQuantity.Text = quantity.ToString();
            }
            cboProduct.Enabled = false;
            btnAdd.Enabled = false;
            lstProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnCreate.Enabled = false;
            btnClean.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Propose Receipts Detail").Update;
            if (update == true)
            {
                string proposedID = (string)cboProposedID.SelectedValue;
                string productID = (string)cboProduct.SelectedValue;
                int quantity = int.Parse(nmrQuantity.Value.ToString());

                bool flag = Bus_Detail.UpdateProposedDetail(productID, proposedID, quantity);
                if (flag == true)
                {
                    MessageBox.Show("Update Proposed Detail successfully!");
                    LoadListMainDetail();
                    Clean();
                    cboProduct.Enabled = true;
                    btnAdd.Enabled = true;
                    lstProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                    btnCreate.Enabled = true;
                    btnClean.Enabled = true;
                    btnUpdate.Enabled = false;
                }
                else MessageBox.Show("Update Proposed Detail unsuccessfully!");
            }
            else MessageBox.Show("Your account do not have the authority to update Proposed Receipt Detail!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstDetails.DataSource = Bus_Detail.Search(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListMainDetail();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string proposedID = (string)cboProposedID.SelectedValue;
            GUI_PrintProposed print = new GUI_PrintProposed(proposedID);
            print.ShowDialog();
        }
    }
}
