using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.HeadquarterReceipt_Management
{
    class BUS_HeadquarterReceiptDetail
    {
        CMART0Entities db = new CMART0Entities();

        //LOAD HEADQUARTER ID
        public List<HeadquaterReceipt> LoadHeadquarterID()
        {
            return db.HeadquaterReceipts.ToList();
        }

        //LOAD HEADQUARTER RECEIPT
        public List<HeadquaterReceiptDetail> LoadDetail(string headquarterID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.HeadquaterReceiptDetails.Where(x=>x.HeadquaterID==headquarterID).ToList();
        }

        // INSERT
        public bool InsertHeadquarterDetail(string headquarterID, string productID, int quantity, double price, string status)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_HEADQUATERRECEIPTDETAIL(headquarterID, productID, quantity, price, status);
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
        public bool UpdateHeadquarterDetail(string headquarterID, string productID, string status)
        {
            bool flag = false;
            try
            {
                db.SP_UPDATE_HEADQUATERRECEIPTDETAIL(headquarterID, productID, status);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //SEARCH
        public List<usp_HeadquarterReceiptDetailSearch_Result> Search(string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_HeadquarterReceiptDetailSearch(input).ToList();
        }

        //DELETE
        public bool Delete(string headquarter, string productID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            HeadquaterReceiptDetail detail = db.HeadquaterReceiptDetails.Single(x =>x.HeadquaterID==headquarter && x.ProductID == productID);
            try
            {
                db.DeleteObject(detail);
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
        public bool DeleteAll(string headquarterID)
        {
            bool flag = false;
            try
            {
                db.usp_HeadquarterDetailDeleteAll(headquarterID);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //PRINT
        public List<SP_PRINT_Headquarter_Result> printHeadquarterDetail(string billID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.SP_PRINT_Headquarter(billID).ToList();
        }
    }
}
