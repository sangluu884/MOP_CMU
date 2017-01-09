using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Supplier_Management
{
    class BUS_Supplier
    {
        CMART0Entities db = new CMART0Entities();

        // LOAD LIST
        public List<Supplier> LoadListSupplier()
        {
            CMART0Entities db = new CMART0Entities();
            List<Supplier> lst = db.Suppliers.ToList();
            return lst;
        }

        // INSERT
        public bool InsertSupplier(string iD, string name, string address, string phoneNumber)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_SUPPLIER(name, address, phoneNumber);
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
        public bool UpdateSupplier(string iD, string name, string address, string phoneNumber)
        {
            bool flag = false;
            try
            {
                db.usp_SupplierUpdate(iD, name, address, phoneNumber);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //DELETE
        public bool Delete(string iD)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            Supplier supplier = db.Suppliers.Single(x => x.SupplierID == iD);
            try
            {
                
                db.Suppliers.Remove(supplier);
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

        public List<usp_SupplierSearch_Result> Search(string input)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_SupplierSearch(input).ToList();
        }
    }
}
