using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.ProposeReceipt_Management
{
    class BUS_ProposedDetail
    {
        CMART0Entities db = new CMART0Entities();

        // LOAD LIST
        public List<ProposeReceiptDetail> LoadListProposedDetail(string proposedID)
        {
            CMART0Entities db = new CMART0Entities();
            List<ProposeReceiptDetail> lst = db.ProposeReceiptDetails.Where(x => x.ProposeID == proposedID).ToList();
            return lst;
        }

        // INSERT
        public bool InsertProposedDetail(string productID, string proposedID, int quantity)
        {
            bool flag = false;
            try
            {
                db.sp_ProposedDetail_Insert(productID, proposedID, quantity);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        // UPDATE
        public bool UpdateProposedDetail(string productID, string proposedID, int quantity)
        {
            bool flag = false;
            try
            {
                db.usp_ProposedDetailUpdate(productID, proposedID, quantity);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //SEARCH
        public List<usp_ProposedDetailSearch_Result> Search(string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_ProposedDetailSearch(input).ToList();
        }

        //DELETE
        public bool Delete(string productID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            ProposeReceiptDetail pR = db.ProposeReceiptDetails.Single(x => x.ProductID == productID);
            try
            {
                db.ProposeReceiptDetails.Remove(pR);
                //db.usp_Account_Delete(accountID);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //DELETE ALL
        public bool DeleteAll(string proposedID)
        {
            bool flag = false;
            try
            {
                db.usp_ProposedDetailDeleteAll(proposedID);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //PRINT
        public List<SP_PRINT_Proposed_Result> printProposedDetail(string billID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.SP_PRINT_Proposed(billID).ToList();
        }
    }
}
