using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.BRANCHOFFICERECEIPT
{
    class BUS_BRANCHOFFICERECEIPT
    {
        CMART0Entities DataAccess = new CMART0Entities();
        public List<BranchOfficeReceipt> loadList()
        {
            CMART0Entities DataAccess = new CMART0Entities();
            List<BranchOfficeReceipt> lst = DataAccess.BranchOfficeReceipts.ToList();
            return lst;
        }
        public bool insertBRANCHOFFICERECEIPT(String HeadQuaterID, String Branch, int Quantity, String Status)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_INSERT_BRANCHRECEIPT(HeadQuaterID, Branch, "ACC00001", Quantity, Status);
                flag = true;
            }
            catch (Exception g)
            {
                flag = false;
            }
            return flag;
        }
        public List<usp_BranchOfficeSearch_Result> search(String input)
        {
            CMART0Entities DataAccess = new CMART0Entities();
            return DataAccess.usp_BranchOfficeSearch(input).ToList();
        }

        public bool updataBRANCHOFFICERECEIPT(String BranchOfficeID,String HeadQuaterID,int Quantity, String Status)
        {
            bool flag = false;
            CMART0Entities DataAccess = new CMART0Entities();
            try
            {
                DataAccess.SP_UPDATE_BRANCHRECEIPT(BranchOfficeID, HeadQuaterID, Quantity, Status);
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
