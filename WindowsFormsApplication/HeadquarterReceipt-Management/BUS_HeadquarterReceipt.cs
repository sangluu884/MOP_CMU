using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.HeadquarterReceipt_Management
{
    class BUS_HeadquarterReceipt
    {
        CMART0Entities db = new CMART0Entities();

        //LOAD PROPOSED ID
        public List<ProposeReceipt> LoadProposed()
        {
            var proposed = db.ProposeReceipts.ToList();
            return proposed;
        }

        //LOAD HEADQUARTER
        public List<HeadquaterReceipt> LoadHeadquarterR()
        {
            CMART0Entities db = new CMART0Entities();
            return db.HeadquaterReceipts.ToList();
        }

        // INSERT
        public bool InsertHeadquarter(string proposedID,double totalAmount, string accountID)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_HEADQUATER(proposedID, totalAmount, accountID);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //UPDATE
        public bool UpdateAccount(string headID, string proposedID, double totalAmount, string accountID)
        {
            bool flag = false;
            try
            {
                db.SP_UPDATE_HEADQUATERRECEIPT(headID, proposedID, totalAmount, accountID);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //DELETE
        public bool Delete(string headquarterID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            HeadquaterReceipt headquarter = db.HeadquaterReceipts.Single(x => x.HeadquaterID == headquarterID);
            try
            {
                db.HeadquaterReceipts.Remove(headquarter);
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

        //SEARCH
        public List<usp_HEADQUATERRECEIPTSearch_Result> Search(string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_HEADQUATERRECEIPTSearch(input).ToList();
        }
    }
}
