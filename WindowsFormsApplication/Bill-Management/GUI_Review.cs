using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Bill_Management
{
    public partial class GUI_Review : Form
    {
        BUS_ManageBill bus = new BUS_ManageBill();
        string billID;
        public GUI_Review(string id)
        {
            InitializeComponent();
            billID = id;
        }

        private void GUI_Review_Load(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = bus.printbill(billID);

            BindingSource bs1 = new BindingSource();
            bs1.DataSource = bus.printbilldetail(billID);
            CrystalReportInvoice rp = new CrystalReportInvoice();
            rp.SetDataSource(bs1);
            crvReview.ReportSource = rp;
            crvReview.RefreshReport(); 
        }
    }
}
