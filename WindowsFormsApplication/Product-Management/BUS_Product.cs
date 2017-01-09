using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Product_Management
{
    class BUS_Product
    {
        CMART0Entities db = new CMART0Entities();
        public List<SP_SELECTALL_PRODUCT_Result> load()
        {
            CMART0Entities db = new CMART0Entities();
            return db.SP_SELECTALL_PRODUCT().ToList();
        }
           
        public List<SP_SEARCH_PRODUCT_Result> search(string id)
        {
            return db.SP_SEARCH_PRODUCT(id).ToList();
        }

        public List<Product> loadList()
        {
            CMART0Entities db = new CMART0Entities();
            List<Product> lst = db.Products.ToList();
            return lst;
        }
        public bool insertProduct(String Name, String Image, String SupplierID, String CategoryID)
        {
            bool flag = false;
            try
            {
                db.SP_INSERT_PRODUCT(Name, SupplierID, CategoryID, Image);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }


        public bool updateProduct(String id,String Name, String SupplierID, String CategoryID, String Image)
        {
            bool flag = false;
            try
            {
                db.SP_UPDATE_PRODUCT(id,Name,SupplierID,CategoryID, Image);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool Delete(string ID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            Product pro = db.Products.Single(x => x.ProductID == ID);
            try
            {
                db.Products.Remove(pro);
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
    }
}
