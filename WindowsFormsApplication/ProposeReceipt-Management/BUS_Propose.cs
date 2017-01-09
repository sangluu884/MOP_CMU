using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.ProposeReceipt_Management
{
    class BUS_Propose
    {
        CMART0Entities db = new CMART0Entities();
        // LOAD LIST
        public List<ProposeReceipt> LoadListProposed()
        {
            CMART0Entities db = new CMART0Entities();
            List<ProposeReceipt> lst = db.ProposeReceipts.ToList();
            return lst;
        }

        // INSERT
        public bool InsertProposed(string ID, string supplierID, string accountID)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_PROPOSE(supplierID, accountID);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool UpdateProposed(string ID, string supplierID, string accountID)
        {
            bool flag = false;
            try
            {
                db.usp_ProposedUpdate(ID,supplierID, accountID);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //DELETE
        public bool Delete(string ID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            ProposeReceipt pR = db.ProposeReceipts.Single(x => x.ProposeID == ID);
            try
            {
                db.ProposeReceipts.Remove(pR);
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

        public List<usp_ProposedSearch_Result> Search(string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_ProposedSearch(input).ToList();
        }
    }
}
