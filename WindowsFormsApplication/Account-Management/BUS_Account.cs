using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Account_Management
{
    class BUS_Account
    {
        CMART0Entities db = new CMART0Entities();

        // LOAD LIST
        public List<Account> LoadListAccount()
        {
            List<Account> lst = db.Accounts.ToList();
            return lst;
        }

        // INSERT
        public bool InsertAccount(string accountID, string fullName, string address, string phoneNumber, string cMND, string userName, string password)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_ACCOUNTID(fullName, address, phoneNumber, cMND, userName, password);
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
        public bool UpdateAccount(string account, string fullName, string address, string phoneNumber, string cMND, string userName, string password)
        {
            bool flag = false;
            try
            {
                db.usp_AccountUpdate(account, fullName, address, phoneNumber, cMND, userName, password);
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        //DELETE
        public bool Delete(string accountID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            Account acc = db.Accounts.Single(x => x.AccountID == accountID);
            try
            {
                db.DeleteObject(acc);
                //db.usp_Account_Delete(accountID);
                db.SaveChanges();
                flag = true;
            }
            catch (Exception g)
            {
                flag = false;
            }
            return flag;
        }

        public List<usp_AccountSearch_Result> Search (string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_AccountSearch(input).ToList();
        }
    }
}
