using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistic_Management
{
    public partial class GUI_ReviewsStatistic : Form
    {
        BUS_Statistic bus = new BUS_Statistic();
        int ngayn;
        int thangn;
        int namn;
        int pickn;
        int filln;
        DateTime fromn;
        DateTime ton;
        public GUI_ReviewsStatistic(int ngay, int thang, int nam, DateTime from, DateTime to, int pick, int fill)
        {
            InitializeComponent();
            ngayn = ngay;
            thangn = thang;
            namn = nam;
            pickn = pick;
            filln = fill;
            fromn = from;
            ton = to;
        }
        private void GUI_PrintReport_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bus.showinformationsum(ngayn, thangn, namn, fromn, ton, pickn, filln);
            CrystalReportStatistic rp = new CrystalReportStatistic();
            rp.SetDataSource(bs);
            crvStatistic.ReportSource = rp;
            crvStatistic.RefreshReport();
        }
    }
}
