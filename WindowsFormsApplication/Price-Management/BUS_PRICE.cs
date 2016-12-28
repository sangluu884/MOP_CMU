using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.PRICE
{
    class BUS_PRICE
    {
        CMART0Entities DataAccess = new CMART0Entities();
        public List<Price> loadList()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<Price> lst = DataAccess.Prices.ToList();
            return lst;
        }
        public bool insertPRICE(String ProductID, float Price, DateTime Date)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.usp_PriceInsert(ProductID, Price, Date);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
        public List<usp_PriceSearch_Result> search(String input)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            return DataAccess.usp_PriceSearch(input).ToList();
        }

        public bool updatePRICE(String ProductID, float Price, DateTime Date)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.usp_PriceUpdate(ProductID, Price, Date);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
        public bool deletePRICE(String ProductID, float Price, DateTime Date)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.usp_PriceDelete(ProductID, Price, Date);
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



