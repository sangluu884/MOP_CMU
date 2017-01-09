using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Promotion_Test
{
    class BUS_Promotion
    {
        CMART0Entities cmart7 = new CMART0Entities();

        public List<Promotion> loadListPromotion()
        {
            CMART0Entities cmart7 = new CMART0Entities();
            return cmart7.Promotions.ToList();
        }

        public List<PROMOTION_SEARCH_Result> search(String input)
        {
            return cmart7.PROMOTION_SEARCH(input).ToList();
        }

        public bool deletePromotion(string PromotionID)
        {
            bool flag = false;
            Promotion promotion = cmart7.Promotions.Single(st => st.PromotionID == PromotionID);
            try
            {
                cmart7.Promotions.Remove(promotion);
                cmart7.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        public bool Delete(string ID)
        {
            bool flag = false;
            CMART0Entities db = new CMART0Entities();
            Promotion pro = db.Promotions.Single(x => x.PromotionID == ID);
            try
            {
                db.Promotions.Remove(pro);
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

        public bool Insert(string id, float PromotionPrice, DateTime StartDate, DateTime EndDdate, string Content, string Image, string ProductID)
        {
            bool flag = false;
            try
            {
                cmart7.SP_PROMOTION_INSERT(PromotionPrice, StartDate,EndDdate, Content, Image, ProductID);
                cmart7.SaveChanges();
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool Update(string id, float PromotionPrice, DateTime StartDate, DateTime EndDdate, string Content, string Image, string ProductID)
        {
            bool flag = false;
            try
            {
                cmart7.usp_PromotionUpdate(id, PromotionPrice, StartDate, EndDdate, Content, Image, ProductID);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool UpdateTest(string id, float PromotionPrice, string Content, string Image, string ProductID)
        {
            CMART0Entities db = new CMART0Entities();
            bool flag = false;
            try
            {
                db.usp_PromotionUpdateTest(id, PromotionPrice, Content, Image, ProductID);
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
