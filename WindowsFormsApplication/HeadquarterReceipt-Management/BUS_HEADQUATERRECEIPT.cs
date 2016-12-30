using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.HeadquarterReceipt
{
    class BUS_HEADQUATERCEREIPT
    {
        CMART0Entities DataAccess = new CMART0Entities();
        public List<HeadquaterReceipt> loadList()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<HeadquaterReceipt> lst = DataAccess.HeadquaterReceipts.ToList();
            return lst;
        }
        public bool insertHEADQUATERCEREIPT(String ProposeID, double TotalAmount, int Quantity, String Status,String Account,String ProductID,double price,DateTime day)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_INSERT_HEADQUATERRECEIPT(ProposeID,TotalAmount,Account,ProductID,Quantity,price,day,Status);
                flag = true;
            }
            catch (Exception g)
            {
                flag = false;
            }
            return flag;
        }
        public List<usp_HEADQUATERRECEIPTSearch_Result> search(String input)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            return DataAccess.usp_HEADQUATERRECEIPTSearch(input).ToList();
        }

        public bool updataHEAQUATERRECEIPT(String headquaterID, String ProposeID, double TotalAmount,String account,String productID, int Quantity,double price,DateTime day, String Status)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_UPDATE_HEADQUATERRECEIPT(headquaterID,ProposeID,TotalAmount,account,productID,Quantity,price,day,Status);
                flag = true;
            }
            catch (Exception g)
            {
                flag = false;
            }
            return flag;
        }
    }
}
