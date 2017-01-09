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
    public partial class GUI_HeadquarterReceipt : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_HeadquarterReceipt Bus_Headquarter = new BUS_HeadquarterReceipt();
        Authority authority = new Authority();
        string getAccount;

        public GUI_HeadquarterReceipt(string re)
        {
            InitializeComponent();
            getAccount = re;
            LoadHeadquarter();
        }

        private void LoadHeadquarter()
        {
            cboProposed.DataSource = Bus_Headquarter.LoadProposed();
            cboProposed.ValueMember = "ProposeID";
            cboProposed.DisplayMember = "ProposeID";

            lstHeadquarterRs.DataSource = Bus_Headquarter.LoadHeadquarterR();
            lstHeadquarterRs.Columns["Account"].Visible = false;
            lstHeadquarterRs.Columns["BranchOfficeReceipts"].Visible = false;
            lstHeadquarterRs.Columns["HeadquaterReceiptDetails"].Visible = false;
            lstHeadquarterRs.Columns["ProposeReceipt"].Visible = false;

            txtAccountID.Text = getAccount;
        }

        private void cboProposed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string proposedID = (string)cboProposed.SelectedValue;
                List<string> lst = db.Headquarter_SelectProduct(proposedID).ToList();
                double totalMoney = 0;
                for (int i = 0; i < lst.Count; i++)
                {
                    var entityError = lst[i];
                    double getMoney = db.Prices.Single(x => x.ProductID == entityError).Price1;
                    totalMoney += getMoney;
                }
                txtTotalAmount.Text = totalMoney.ToString();
            }
            catch { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MainFrm main = new GUI_MainFrm(getAccount);
            main.Closed += (s, args) => this.Close();
            main.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Headquarters Receipts").Create;
            if (create == true)
            {
                string headID = txtHeadID.Text;
                string proposedID = (string)cboProposed.SelectedValue;
                double totalAmountOfMoney = double.Parse(txtTotalAmount.Text);
                string accountID = txtAccountID.Text;

                bool flag = Bus_Headquarter.InsertHeadquarter(proposedID, totalAmountOfMoney, accountID);
                if (flag == true)
                {
                    MessageBox.Show("Create Headquarter Receipt successfully!");
                    LoadHeadquarter();
                    Clean();
                }
                else MessageBox.Show("Create Headquarter Receipt unsuccessfully!");
            }
            else MessageBox.Show("Your account do not have the authority to create Headquarter Receipt!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Headquarters Receipts").Update;
            if (update == true)
            {
                string headID = txtHeadID.Text;
                var check = Find(headID);
                if (check != null)
                {
                    string proposedID = (string)cboProposed.SelectedValue;
                    double totalAmountOfMoney = double.Parse(txtTotalAmount.Text);
                    string accountID = txtAccountID.Text;

                    bool flag = Bus_Headquarter.UpdateAccount(headID, proposedID, totalAmountOfMoney, accountID);
                    if (flag == true)
                    {
                        MessageBox.Show("Update Headquarter Receipt successfully!");
                        LoadHeadquarter();
                    }
                    else MessageBox.Show("Update Headquarter Receipt unsuccessfully!");
                }
                else MessageBox.Show("Please choose a Headquarter Receipt!");
            }
            else MessageBox.Show("Your account do not have the authority to update Headquarter Receipt!");
        }

        public HeadquaterReceipt Find(string headquarterID)
        {
            return db.HeadquaterReceipts.FirstOrDefault(x => x.HeadquaterID == headquarterID);
        }

        private void lstHeadquarterRs_DoubleClick(object sender, EventArgs e)
        {
            HeadquaterReceipt headquarter = new HeadquaterReceipt();
            CMART0Entities db = new CMART0Entities();

            if (lstHeadquarterRs.SelectedRows.Count == 1)
            {
                var row = lstHeadquarterRs.SelectedRows[0];
                var cell = row.Cells["HeadquaterID"];
                string headquarterID = (string)cell.Value;
                headquarter = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID);
                txtHeadID.Text = headquarter.HeadquaterID;
                cboProposed.Text = headquarter.ProposeID;
                txtTotalAmount.Text = headquarter.TotalAmount.ToString();
                //txtAccountID.Text = headquarter.AccountID;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtHeadID.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstHeadquarterRs.DataSource = Bus_Headquarter.Search(txtSearch.Text);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            GUI_HeadquarterReceiptDetail detail = new GUI_HeadquarterReceiptDetail(getAccount);
            detail.ShowDialog();
        }

        private void lstHeadquarterRs_Click(object sender, EventArgs e)
        {
            HeadquaterReceipt headquarter = new HeadquaterReceipt();
            CMART0Entities db = new CMART0Entities();

            if (lstHeadquarterRs.SelectedRows.Count == 1)
            {
                var row = lstHeadquarterRs.SelectedRows[0];
                var cell = row.Cells["HeadquaterID"];
                string headquarterID = (string)cell.Value;
                headquarter = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID);
                txtHeadID.Text = headquarter.HeadquaterID;
                cboProposed.Text = headquarter.ProposeID;
                txtTotalAmount.Text = headquarter.TotalAmount.ToString();
                //txtAccountID.Text = headquarter.AccountID;
            }
        }
    }
}
