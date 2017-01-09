using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ProposeReceipt_Management
{
    public partial class GUI_Propose : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_Propose Bus_Proposed = new BUS_Propose();
        Authority authority = new Authority();
        string getAccount;

        public GUI_Propose(string re)
        {

            InitializeComponent();
            getAccount = re;
            LoadProposed();
            //GUI_ProposedDetail detail = new GUI_ProposedDetail(getAccount);
            //detail.Close();
        }

        private void LoadProposed()
        {
            lstProposedRs.DataSource = Bus_Proposed.LoadListProposed();
            lstProposedRs.Columns["Account"].Visible = false;
            lstProposedRs.Columns["HeadquaterReceipts"].Visible = false;
            lstProposedRs.Columns["Supplier"].Visible = false;
            lstProposedRs.Columns["ProposeReceiptDetails"].Visible = false;
            cboSupplier.DataSource = db.Suppliers.ToList();
            cboSupplier.ValueMember = "SupplierID";
            cboSupplier.DisplayMember = "Name";
            txtAccount.Text = getAccount;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Propose Receipts").Create;
            if (create == true)
            {
                string id = txtID.Text;
                string supplier = (string)cboSupplier.SelectedValue;
                string account = txtAccount.Text;

                bool flag = Bus_Proposed.InsertProposed(id, supplier, account);
                if (flag == true)
                {
                    MessageBox.Show("Create Successfylly!");
                    LoadProposed();
                }
                else MessageBox.Show("Create Unsucessfully!");
            }
            else MessageBox.Show("Your account do not have the authority to create Proposed Receipt!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Propose Receipts").Update;
            if (update == true)
            {
                string id = txtID.Text;
                string supplier = (string)cboSupplier.SelectedValue;
                string account = txtAccount.Text;

                bool flag = Bus_Proposed.UpdateProposed(id, supplier, account);
                if (flag == true)
                {
                    MessageBox.Show("Update Successfylly!");
                    LoadProposed();
                }
                else MessageBox.Show("Update Unsucessfully!");
            }
            else MessageBox.Show("Your account do not have the authority to update Proposed Receipt!");
        }

        private void lstProposedRs_DoubleClick(object sender, EventArgs e)
        {
            ProposeReceipt proposed = new ProposeReceipt();
            CMART0Entities db = new CMART0Entities();

            if (lstProposedRs.SelectedRows.Count == 1)
            {
                var row = lstProposedRs.SelectedRows[0];
                var cell = row.Cells["ProposeID"];
                string ID = (string)cell.Value;
                proposed = db.ProposeReceipts.Single(x => x.ProposeID == ID);
                txtID.Text = proposed.ProposeID;
                cboSupplier.Text = proposed.Supplier.Name;
                txtAccount.Text = proposed.AccountID;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstProposedRs.DataSource = Bus_Proposed.Search(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProposed();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            GUI_ProposedDetail detail = new GUI_ProposedDetail(getAccount);
            detail.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MainFrm main = new GUI_MainFrm(getAccount);
            main.Closed += (s, args) => this.Close();
            main.ShowDialog();
        }
    }
}
