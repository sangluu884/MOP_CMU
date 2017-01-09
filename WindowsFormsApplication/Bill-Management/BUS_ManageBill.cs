using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Bill_Management
{
    class BUS_ManageBill
    {
        public List<usp_Bill_SelectAll_Result> getAllListBill()
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_Bill_SelectAll().ToList();
        }

        public List<usp_Bill_Search_Result> searchAllList(string search)
        {
            CMART0Entities db = new CMART0Entities();
            return db.usp_Bill_Search(search).ToList();
        }
        public Bill loadBill(string id)
        {
            CMART0Entities db = new CMART0Entities();
            return db.Bills.Single(x => x.BillID == id);
        }

        public List<BillDetail> loadDetailOfBill(string id)
        {
            CMART0Entities db = new CMART0Entities();
            return db.BillDetails.Where(st => st.BillID == id).ToList();
        }
        public bool updateBill(Bill update)
        {
            CMART0Entities db = new CMART0Entities();
            try
            {
                db.usp_Bill_Update(update.BillID, update.SaleDate, update.POS, update.TotalAmount, update.TotalQuantity, update.InputMoney, update.OutputMoney, update.AccountID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool checkexitProductid(string id)
        {
            CMART0Entities db = new CMART0Entities();
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
            CMART0Entities db = new CMART0Entities();
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

        public void updateBillDetail(DataGridView lstbilldetail, TextBox txtid)
        {
            CMART0Entities db = new CMART0Entities();
            List<BillDetail> detail = loadDetailOfBill(txtid.Text);
            for (int i = 0; i < lstbilldetail.Rows.Count - 1; i++)
            {
                int a = 0;
                for (int m = 0; m < detail.Count; m++)
                {
                    if (detail[m].ProductID.ToString() == lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString())
                    {
                        string productid = lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString();
                        string billid = txtid.Text;
                        BillDetail edit = db.BillDetails.Single(st => st.BillID == billid && st.ProductID == productid);
                        edit.Quantity = (int)lstbilldetail.Rows[i].Cells["Quantity"].Value;
                        edit.Price = float.Parse(lstbilldetail.Rows[i].Cells["Price"].Value.ToString());
                        db.SaveChanges();
                        a = 1;
                    }
                }
                if (a == 0)
                {
                    db.usp_BillDetail_Add(txtid.Text, lstbilldetail.Rows[i].Cells["ProductID"].Value.ToString(), (int)lstbilldetail.Rows[i].Cells["Quantity"].Value, (float)lstbilldetail.Rows[i].Cells["Price"].Value);
                }
            }
            for (int i = 0; i < detail.Count; i++)
            {
                int b = 0;
                for (int m = 0; m < lstbilldetail.Rows.Count - 1; m++)
                {
                    if (lstbilldetail.Rows[m].Cells["ProductID"].Value.Equals(detail[i].ProductID.ToString()))
                    {
                        b = 1;
                    }
                }
                if (b == 0)
                {
                    db.usp_BillDetail_Delete(txtid.Text, detail[i].ProductID);
                }
            }
        }

        //public List<SP_BILL_PRINTBILL_Result> printbill(string billID)
        //{
        //    CMART0Entities db = new CMART0Entities();
        //    return db.SP_BILL_PRINTBILL(billID).ToList();
        //}

        public List<SP_INVOICE_PRINT_Result> printbilldetail(string billID)
        {
            CMART0Entities db = new CMART0Entities();
            return db.SP_INVOICE_PRINT(billID).ToList();
        }
    }
}
