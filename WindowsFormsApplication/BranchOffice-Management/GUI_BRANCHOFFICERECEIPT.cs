using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.BRANCHOFFICERECEIPT
{
    public partial class GUI_BRANCHOFFICERECEIPT : Form
    {
        String id = null;
        BUS_BRANCHOFFICERECEIPT Bus = new BUS_BRANCHOFFICERECEIPT();
        
        public GUI_BRANCHOFFICERECEIPT()
        {
            InitializeComponent();
            Load();
            cbbBranch.Items.Add(1);
            cbbBranch.Items.Add(2);
            cbbStatus.Items.Add("good");
            cbbStatus.Items.Add("bad");
        }
        public void Load()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            lstReceipt.DataSource = Bus.loadList();
            lstReceipt.Columns["Account"].Visible = false;
            lstReceipt.Columns["BranchOfficeReceiptDetails"].Visible = false;
            lstReceipt.Columns["HeadQuaterReceipt"].Visible = false;
            cbbHeadquater.DataSource = DataAccess.HeadquaterReceipts.ToList();
            cbbHeadquater.ValueMember = "HeadquaterID";
            cbbHeadquater.DisplayMember = "HeadquaterID"; 
            cbbHeadquater.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbHeadquater.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String HeadQuaterID = cbbHeadquater.Text;
            String Branch = cbbBranch.Text;
            int Quantity = int.Parse(txtQuantity.Text);
            String Status = cbbStatus.Text;
            bool flag = Bus.insertBRANCHOFFICERECEIPT(HeadQuaterID, Branch, Quantity, Status);
            if (flag == true)
            {
                MessageBox.Show("Insert success");
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
            Load();
        }

        private void lstReceipt_Click(object sender, EventArgs e)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            BranchOfficeReceipt BranchO = new BranchOfficeReceipt();
            BranchOfficeReceiptDetail BranchODetail = new BranchOfficeReceiptDetail();
            if (lstReceipt.SelectedRows.Count == 1)
            {
                var row = lstReceipt.SelectedRows[0];
                var cell = row.Cells["BranchOfficeID"];
                String ID = (String)cell.Value;
                id = ID;
                BranchO = DataAccess.BranchOfficeReceipts.Single(st => st.BranchOfficeID == ID);
                txtBranchOID.Text = BranchO.BranchOfficeID.ToString();
                DTPDate.Text = BranchO.Date.ToShortDateString();
                cbbHeadquater.SelectedItem = BranchO.HeadquaterID.ToString();
                cbbBranch.SelectedIndex = int.Parse(BranchO.Branch.ToString())-1;
                BranchODetail = DataAccess.BranchOfficeReceiptDetails.Single(st => st.BranchOfficeID == ID);
                txtQuantity.Text = BranchODetail.Quantity.ToString();
                cbbStatus.SelectedItem = BranchODetail.Status.ToString();
            }
        }

        ValidationExtensition v = new ValidationExtensition();

        private void Search_TextChanged(object sender, EventArgs e)
        {
            lstReceipt.DataSource = Bus.search(Search.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String BranchOfficeID = txtBranchOID.Text;
            String HeadQuaterID = cbbHeadquater.Text;
            int Quantity = int.Parse(txtQuantity.Text);
            String Status = cbbStatus.Text;
            bool flag = Bus.updataBRANCHOFFICERECEIPT(BranchOfficeID, HeadQuaterID, Quantity, Status);
            if (flag == true)
            {
                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
            Load();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search.Clear();
            Load();
            txtBranchOID.Text = "";
            DTPDate.Text = DateTime.Now.ToShortDateString();
            cbbHeadquater.SelectedIndex = 0;
            cbbBranch.SelectedIndex = 0;
            txtQuantity.Clear();
            cbbStatus.SelectedIndex =0;
        }
    }
}
