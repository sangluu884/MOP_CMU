using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Account_Management
{
    class BUS_Authority
    {
        CMART0Entities db = new CMART0Entities();
        public List<Authority> SelectAuthority()
        {
            CMART0Entities db = new CMART0Entities();
            Account acc = new Account();
            var lst = db.Authorities.ToList();
            return lst;
        }

        // INSERT
        public bool InsertAuthority(string accountID, string nameOfAuthority, bool view, bool create, bool update, bool delete)
        {
            bool flag = false;
            try
            {
                db.sp_Authority_Insert(accountID, nameOfAuthority, view, create, update, delete);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool InsertAuthority(Authority authority)
        {
            bool flag = false;
            try
            {
                db.Authorities.AddObject(authority);
                db.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        //public bool UpdateAthority(string id, string nameOfAuthority, bool create, bool update1, bool delete, bool view)
        //{
        //    bool flag = false;
        //    try
        //    {
        //        db.usp_AuthorityUpdate(id, nameOfAuthority, create, update1, delete, view);
        //        flag = true;
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return flag;
        //}

        public bool UpdateAthority(string id, string nameOfAuthority, bool create, bool update1, bool delete, bool view)
        {
            bool flag = false;
            try
            {
                Authority aut = db.Authorities.Single(x => x.AccountID == id && x.NameOfAuthority == nameOfAuthority);
                aut.Create = create;
                aut.Update = update1;
                aut.Delete = delete;
                aut.View = view;
                db.SaveChanges();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }
    }
}
