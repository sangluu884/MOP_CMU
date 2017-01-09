using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Category_Management
{
    class BUS_Category
    {
        CMART0Entities db = new CMART0Entities();

        //load list
        public List<Category> LoadListCategory()
        {
            CMART0Entities db = new CMART0Entities();
            return db.Categories.ToList();
        }

        //add
        public bool InsertCategory(string id, string name, int quantity)
        {
            bool flag = false;
            try
            {
                db.sp_CATEGORY_insert(name, quantity);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //update
        public bool UpdateCategory(string id, string name, int quantity)
        {
            bool flag = false;
            try
            {
                db.usp_CategoryUpdate(id, name, quantity);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool UpdateCategory2(string id, int quantity)
        {
            bool flag = false;
            try
            {
                db.usp_CategoryUpdate2(id, quantity);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //delete
        public bool DeleteCategory(string id)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            Category category = db.Categories.Single(x => x.CategoryID == id);
            try
            {
                db.Categories.Remove(category);
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

        //search
        public List<usp_CategorySearch_Result> Search(string input)
        {
            return db.usp_CategorySearch(input).ToList();
        }
    }
}
