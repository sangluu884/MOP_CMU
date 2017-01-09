using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.BranchOfficeReceipt_Management
{
    public partial class GUI_BRANCHOFFICERECEIPT : Form
    {
        String id = null;
        String getAccount;
        CMART0Entities db = new CMART0Entities();
        BUS_BRANCHOFFICERECEIPT Bus = new BUS_BRANCHOFFICERECEIPT();
        ValidationExtensition val = new ValidationExtensition();
        Authority authority = new Authority();

        public GUI_BRANCHOFFICERECEIPT(String re)
        {
            InitializeComponent();
            getAccount = re;
            Load();
        }
        public void Load()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            lstReceipt.DataSource = Bus.loadList();
            lstReceipt.Columns["Account"].Visible = false;
            lstReceipt.Columns["BranchOfficeReceiptDetails"].Visible = false;
            lstReceipt.Columns["HeadQuaterReceipt"].Visible = false;
            lstReceipt.Columns[4].Visible = false;
            cbbHeadquater.DataSource = DataAccess.HeadquaterReceipts.ToList();
            cbbHeadquater.ValueMember = "HeadquaterID";
            cbbHeadquater.DisplayMember = "HeadquaterID"; 
            txtAccount.Text = getAccount;
            cbbBranch.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bool create = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Branch Office Receipts").Create;
           if (create == true)
           {
               String HeadQuaterID = cbbHeadquater.Text;
               String Branch = cbbBranch.Text;
               String AccountID = txtAccount.Text;
               bool flag = Bus.insertBRANCHOFFICERECEIPT(HeadQuaterID, Branch, AccountID);
               if (flag == true)
               {
                   MessageBox.Show("Create successfully ");
               }
               else
               {
                   MessageBox.Show("Create unsuccessfully");
               }
               Load();
           }
           else MessageBox.Show("Your account do not have the authority to create Branch Office Receipts!");
        }
        private void lstReceipt_Click(object sender, EventArgs e)
        {
            if (lstReceipt.SelectedRows.Count == 1)
            {
                var row = lstReceipt.SelectedRows[0];
                var cell = row.Cells["BranchOfficeID"];
                String ID = (String)cell.Value;
                id = ID;
                Bus.loadBRANCHOFFICERECEIPT(id,txtBranchOID,cbbHeadquater,cbbBranch);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if(val.RegularExpression(Search))
            { MessageBox.Show("Search not allow special character "); }
            else
            { lstReceipt.DataSource = Bus.search(Search.Text); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool update = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Branch Office Receipts").Update;
            if (update == true)
            {
                String BranchOfficeID = txtBranchOID.Text;
                String HeadQuaterID = cbbHeadquater.Text;
                String AccountID = txtAccount.Text;
                bool flag = Bus.updateBRANCHOFFICERECEIPT(BranchOfficeID, HeadQuaterID, AccountID);
                if (flag == true)
                {
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    MessageBox.Show("Update unsuccessfully");
                }
                Load();
            }
            else MessageBox.Show("Your account do not have the authority to update Branch Office Receipts!");
        }

        private void lstReceipt_DoubleClick(object sender, EventArgs e)
        {
            if (lstReceipt.SelectedRows.Count == 1)
            {
                var row = lstReceipt.SelectedRows[0];
                var cell = row.Cells["BranchOfficeID"];
                String ID = (String)cell.Value;
                id = ID;
                GUI_BRANCHOFFICERECEIPTDETAIL BranchDetail = new GUI_BRANCHOFFICERECEIPTDETAIL(id);
                BranchDetail.ShowDialog();
            }
        }

        private void GUI_BRANCHOFFICERECEIPT_Load(object sender, EventArgs e)
        {

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
