using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.BranchOfficeReceipt_Management
{
    class BUS_BRANCHOFFICERECEIPT
    {
        public List<BranchOfficeReceipt> loadList()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<BranchOfficeReceipt> lst = DataAccess.BranchOfficeReceipts.ToList();
            return lst;
        }
        public void loadBRANCHOFFICERECEIPT(String id,TextBox txtbranchID,ComboBox cbbHeadQuater,ComboBox cbbBranch)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            BranchOfficeReceipt Branch = new BranchOfficeReceipt();
            Branch = DataAccess.BranchOfficeReceipts.Single(st => st.BranchOfficeID == id);
            txtbranchID.Text = Branch.BranchOfficeID.ToString();
            cbbHeadQuater.SelectedValue = Branch.HeadquaterID;
            cbbBranch.Text = Branch.Branch;
        }
        public void loadBRANCHOFFICERECEIPTDETAIL(String ID,String ProductID, TextBox txtQuantity, ComboBox cbbStatus)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            BranchOfficeReceiptDetail BranchDetail = new BranchOfficeReceiptDetail();
            BranchDetail = DataAccess.BranchOfficeReceiptDetails.Single(st => st.BranchOfficeID == ID && st.ProductID == ProductID);
            txtQuantity.Text = BranchDetail.Quantity.ToString();
            cbbStatus.Text = BranchDetail.Status;
        }
        public void loadInfoBRANCHOFFICERECEIPTDETAIL(String ID, Label lblIDHeadID, Label lblBranchID, Label lblDate, Label lblBranch,Label lblCreator)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            Account account = new Account();
            BranchOfficeReceipt Branch = new BranchOfficeReceipt();
            Branch = DataAccess.BranchOfficeReceipts.Single(st => st.BranchOfficeID == ID);
            account = DataAccess.Accounts.Single(st => st.AccountID == Branch.AccountID);
            lblBranchID.Text = ID;
            lblBranch.Text = Branch.Branch;
            lblDate.Text = Branch.Date.ToShortDateString();
            lblIDHeadID.Text = Branch.HeadquaterID;
            lblCreator.Text = account.FullName;
        }
        public bool insertBRANCHOFFICERECEIPT(String HeadQuaterID, String Branch,String Account)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_INSERT_BRANCHRECEIPT(HeadQuaterID, Branch,Account);
                flag = true;
            }
            catch 
            {
                flag = false;
            }
            return flag;
        }
        public List<sp_BranchOfficeSearch_Result> search(String input)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<sp_BranchOfficeSearch_Result> lst = DataAccess.sp_BranchOfficeSearch(input).ToList();
            return lst;
        }
        public List<usp_BranchOfficeDetailSearch_Result> searchDetail(String BranchID,String input)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<usp_BranchOfficeDetailSearch_Result> lst = DataAccess.usp_BranchOfficeDetailSearch(BranchID,input).ToList();
            return lst;
        }
        public List<SP_LOAD_BRANCHRECEIPTDETAIL_Result> loadListBranchDetail(String BranchID)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<SP_LOAD_BRANCHRECEIPTDETAIL_Result> lst = DataAccess.SP_LOAD_BRANCHRECEIPTDETAIL(BranchID).ToList();
            return lst;
        }

        public bool updateBRANCHOFFICERECEIPT(String BranchOfficeID,String HeadQuaterID,String Account)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_UPDATE_BRANCHRECEIPT(BranchOfficeID,HeadQuaterID,Account);
                flag = true;
            }
            catch 
            {
                flag = false;
            }
            return flag;
        }
        public bool updateBRANCHOFFICERECEIPTDETAIL(String BranchOfficeID, String ProductID, int Quantity,String Status)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_UPDATE_BRANCHRECEIPTDETAIL(BranchOfficeID, ProductID, Quantity, Status);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //PRINT
        public List<SP_PRINT_BRANCHRECEIPTDETAIL_Result> printBranchOfficeDetail(string billID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.SP_PRINT_BRANCHRECEIPTDETAIL(billID).ToList();
        }
    }
}
