using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Statistic_Management
{
    class BUS_Statistic
    {
        CMART0Entities db = new CMART0Entities();
        public List<SP_THONGKEDOANHTHU_Result> showinformationdate(int ngay, int thang, int nam)
        {
            return db.SP_THONGKEDOANHTHU(ngay, thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_KTG_Result> showinformationdistance(DateTime from, DateTime to)
        {
            return db.SP_THONGKEDOANHTHU_KTG(from, to).ToList();
        }
        public List<SP_THONGKEDOANHTHU_TOP5_Result> showinformationdatetop5(int ngay, int thang, int nam)
        {
            return db.SP_THONGKEDOANHTHU_TOP5(ngay, thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_KTG_TOP5_Result> showinformationdistancetop5(DateTime from, DateTime to)
        {
            return db.SP_THONGKEDOANHTHU_KTG_TOP5(from, to, 1).ToList();
        }
        public List<SP_THONGKEDOANHTHU_TOP10_Result> showinformationdatetop10(int ngay, int thang, int nam)
        {
            return db.SP_THONGKEDOANHTHU_TOP10(ngay, thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_KTG_TOP10_Result> showinformationdistancetop10(DateTime from, DateTime to)
        {
            return db.SP_THONGKEDOANHTHU_KTG_TOP10(from, to, 1).ToList();
        }
        public List<SP_THONGKEDOANHTHU_TOP20_Result> showinformationdatetop20(int ngay, int thang, int nam)
        {
            return db.SP_THONGKEDOANHTHU_TOP20(ngay, thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_KTG_TOP20_Result> showinformationdistancetop20(DateTime from, DateTime to)
        {
            return db.SP_THONGKEDOANHTHU_KTG_TOP20(from, to, 1).ToList();
        }
        public List<SP_SUMREPORT_Result> showinformationsum(int ngay, int thang, int nam, DateTime from, DateTime to, int pick, int fill)
        {
            return db.SP_SUMREPORT(ngay, thang, nam, from, to, pick, fill).ToList();
        }
    }
}
