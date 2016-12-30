using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.HeadquarterReceipt_Management
{
    public partial class GUI_HeadquarterReceiptDetail : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_HeadquarterReceiptDetail Bus_Detail = new BUS_HeadquarterReceiptDetail();

        public GUI_HeadquarterReceiptDetail()
        {
            InitializeComponent();
            LoadHeadquarterDetail();
        }

        private void LoadHeadquarterDetail()
        {
            cboHeadquarterID.DataSource = Bus_Detail.LoadHeadquarterID();
            cboHeadquarterID.ValueMember = "HeadquaterID";
            cboHeadquarterID.DisplayMember = "HeadquaterID";

            string headquarterID = (string)cboHeadquarterID.SelectedValue;
            //LoadDetail(headquarterID);

            DataGridViewTextBoxColumn txtProduct = new DataGridViewTextBoxColumn();
            txtProduct.HeaderText = "Product ID";
            DataGridViewTextBoxColumn txtQuantity = new DataGridViewTextBoxColumn();
            txtQuantity.HeaderText = "Quantity";
            DataGridViewTextBoxColumn txtPrice = new DataGridViewTextBoxColumn();
            txtPrice.HeaderText = "Price";
            DataGridViewCheckBoxColumn txtFull = new DataGridViewCheckBoxColumn();
            txtFull.HeaderText = "Full";
            DataGridViewCheckBoxColumn txtNotEnough = new DataGridViewCheckBoxColumn();
            txtNotEnough.HeaderText = "Not enough";
            DataGridViewCheckBoxColumn txtDamage = new DataGridViewCheckBoxColumn();
            txtDamage.HeaderText = "Damage";
            lstProducts.Columns.Add(txtProduct);
            lstProducts.Columns.Add(txtQuantity);
            lstProducts.Columns.Add(txtPrice);
            lstProducts.Columns.Add(txtFull);
            lstProducts.Columns.Add(txtNotEnough);
            lstProducts.Columns.Add(txtDamage);
            lstProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstProducts.AllowUserToAddRows = false;

            var enableButton = db.HeadquaterReceiptDetails.FirstOrDefault(x => x.HeadquaterID == headquarterID);
            if (enableButton == null)
            {
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
            }
        }

        private void LoadDetail(string headquarterID)
        {
            var data = Bus_Detail.LoadDetail(headquarterID);
            for (int i = 0; i < data.Count; i++)
                data[i].ExpiryDate = DateTime.Now;
            lstHeadquarterRDs.DataSource = data;
            lstHeadquarterRDs.Columns["HeadquaterReceipt"].Visible = false;
        }

        private void cboHeadquarterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProducts.Rows.Clear();

            string headquarterID = (string)cboHeadquarterID.SelectedValue;

            var enableButton = db.HeadquaterReceiptDetails.FirstOrDefault(x => x.HeadquaterID == headquarterID);
            if (enableButton == null)
            {
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
            }
            LoadDetail(headquarterID);

            string proposedID = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID).ProposeID;
            List<string> lst = db.Headquarter_SelectProduct(proposedID).ToList();

            for (int i = 0; i < lst.Count; i++)
            {
                var entityError = lst[i];
                int quantity = db.ProposeReceiptDetails.Single(x => x.ProposeID == proposedID && x.ProductID == entityError).Quantity;
                double price = db.Prices.Single(x => x.ProductID == entityError).Price1;
                lstProducts.Rows.Add(entityError, quantity, price);
                var status = db.HeadquaterReceiptDetails.FirstOrDefault(x => x.HeadquaterID == headquarterID && x.ProductID == entityError);
                if (status == null)
                {
                    foreach (DataGridViewRow row in lstProducts.Rows)
                    {
                        row.Cells[3].Value = false;
                        row.Cells[4].Value = false;
                        row.Cells[5].Value = false;
                    }
                }
                else
                {
                    if (status.Status == "Full")
                    {
                        lstProducts.Rows[i].Cells[3].Value = true;
                        lstProducts.Rows[i].Cells[4].Value = false;
                        lstProducts.Rows[i].Cells[5].Value = false;
                    }
                    else if (status.Status == "Not enough")
                    {
                        lstProducts.Rows[i].Cells[3].Value = false;
                        lstProducts.Rows[i].Cells[4].Value = true;
                        lstProducts.Rows[i].Cells[5].Value = false;
                    }
                    else if (status.Status == "Damage")
                    {
                        lstProducts.Rows[i].Cells[3].Value = false;
                        lstProducts.Rows[i].Cells[4].Value = false;
                        lstProducts.Rows[i].Cells[5].Value = true;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string headquarterID = (string)cboHeadquarterID.SelectedValue;
            string proposedID = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID).ProposeID;
            List<string> lst = db.Headquarter_SelectProduct(proposedID).ToList();
            bool flagAdd = false, flagUnchecked = true;

            foreach (DataGridViewRow row in lstProducts.Rows)
            {
                bool full = (bool)row.Cells[3].Value;
                bool notFull = (bool)row.Cells[4].Value;
                bool damage = (bool)row.Cells[5].Value;

                if (full == false && notFull == false && damage == false) flagUnchecked = false;
            }

            if (flagUnchecked == true)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    bool full = (bool)lstProducts.Rows[i].Cells[3].Value;
                    bool notFull = (bool)lstProducts.Rows[i].Cells[4].Value;
                    bool damage = (bool)lstProducts.Rows[i].Cells[5].Value;

                    var entityError = lst[i];
                    int quantity = db.ProposeReceiptDetails.Single(x => x.ProposeID == proposedID && x.ProductID == entityError).Quantity;
                    double price = db.Prices.Single(x => x.ProductID == entityError).Price1;
                    if (full == true)
                    {
                        string status = "Full";
                        bool flag = Bus_Detail.InsertHeadquarterDetail(headquarterID, entityError, quantity, price, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                    if (notFull == true)
                    {
                        string status = "Not enough";
                        bool flag = Bus_Detail.InsertHeadquarterDetail(headquarterID, entityError, quantity, price, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                    if (damage == true)
                    {
                        string status = "Damage";
                        bool flag = Bus_Detail.InsertHeadquarterDetail(headquarterID, entityError, quantity, price, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                }
            }
            if (flagUnchecked == false) MessageBox.Show("Please check the status!");
            if (flagAdd == true)
            {
                MessageBox.Show("Add to Headquarter Receipt Detail successfully!");
                LoadDetail(headquarterID);
            }
            else MessageBox.Show("Add to Headquarter Receipt Detail unsuccessfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string headquarterID = (string)cboHeadquarterID.SelectedValue;
            string proposedID = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID).ProposeID;
            List<string> lst = db.Headquarter_SelectProduct(proposedID).ToList();
            bool flagAdd = false, flagUnchecked = true;

            foreach (DataGridViewRow row in lstProducts.Rows)
            {
                bool full = (bool)row.Cells[3].Value;
                bool notFull = (bool)row.Cells[4].Value;
                bool damage = (bool)row.Cells[5].Value;

                if (full == false && notFull == false && damage == false) flagUnchecked = false;
            }

            if (flagUnchecked == true)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    bool full = (bool)lstProducts.Rows[i].Cells[3].Value;
                    bool notFull = (bool)lstProducts.Rows[i].Cells[4].Value;
                    bool damage = (bool)lstProducts.Rows[i].Cells[5].Value;

                    var entityError = lst[i];

                    if (full == true)
                    {
                        string status = "Full";
                        bool flag = Bus_Detail.UpdateHeadquarterDetail(headquarterID, entityError, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                    if (notFull == true)
                    {
                        string status = "Not enough";
                        bool flag = Bus_Detail.UpdateHeadquarterDetail(headquarterID, entityError, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                    if (damage == true)
                    {
                        string status = "Damage";
                        bool flag = Bus_Detail.UpdateHeadquarterDetail(headquarterID, entityError, status);
                        if (flag == true) flagAdd = true;
                        else flagAdd = false;
                    }
                }
            }
            if (flagUnchecked == false) MessageBox.Show("Please check the status!");
            if (flagAdd == true)
            {
                MessageBox.Show("Update Headquarter Receipt Detail successfully!");
                LoadDetail(headquarterID);
            }
            else MessageBox.Show("Update Headquarter Receipt Detail unsuccessfully!");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstHeadquarterRDs.DataSource = Bus_Detail.Search(txtSearch.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string headquarterID = (string)cboHeadquarterID.SelectedValue;
            GUI_PrintHeadquarter print = new GUI_PrintHeadquarter(headquarterID);
            print.ShowDialog();
        }
    }
}
