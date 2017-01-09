using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Bill_Management
{
    class BUS_InsertBill
    {
        CMART0Entities db = new CMART0Entities();
        public bool checkexitProductid(string id)
        {
            try
            {
                Product add = db.Products.Single(st => st.ProductID == id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float countmoney(string id, int number)
        {
            try
            {
                Price add = db.Prices.Single(st => st.ProductID == id);
                try
                {
                    Promotion addpro = db.Promotions.Single(st => st.ProductID == id);
                    if (add.EffectiveDay < addpro.StartDate)
                    {
                        return (float)addpro.PromotionPrice * number;
                    }
                    else
                    {
                        return (float)add.Price1 * number;
                    }
                }
                catch (Exception)
                {
                    return (float)add.Price1 * number;
                }
            }
            catch
            {
                float vogia = -1;
                return vogia;
            }
            

        }

        public string createBilldetail(DataGridView lstbilldetail, TextBox txtamount, TextBox txtsl, TextBox txtinmoney, TextBox txtoutmoney, ComboBox txtbranch, ComboBox txtpos, TextBox txtuser)
        {
            try
            {
                List<usp_Bill_Insert_returnid_Result> add = db.usp_Bill_Insert_returnid(float.Parse(txtamount.Text), int.Parse(txtsl.Text), float.Parse(txtinmoney.Text), float.Parse(txtoutmoney.Text), txtbranch.Text.ToString(), int.Parse(txtpos.Text), txtuser.Text.ToString()).ToList();
                for (int i = 0; i < lstbilldetail.Rows.Count - 1; i++)
                {
                    BillDetail adddetail = new BillDetail();
                    adddetail.ProductID = lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString();
                    adddetail.BillID = add[0].BillID;
                    adddetail.Quantity = (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                    adddetail.Price = (float)lstbilldetail.Rows[i].Cells["Price"].Value;
                    db.BillDetails.Add(adddetail);
                    db.SaveChanges();

                }
                return add[0].BillID.ToString();
            }
            catch
            {
                string rs = "false";
                return rs;
            }

        }
    }
}
