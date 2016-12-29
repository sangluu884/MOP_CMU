using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.BranchOfficeReceipt_Management
{
    public partial class GUI_PrintBranch : Form
    {
        BUS_BRANCHOFFICERECEIPT Bus_Detail = new BUS_BRANCHOFFICERECEIPT();
        string id;
        public GUI_PrintBranch(string bID)
        {
            InitializeComponent();
            id = bID;
            LoadPrint();
        }

        private void LoadPrint()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Bus_Detail.printBranchOfficeDetail(id);
            CrystalReportBranchOffice rp = new CrystalReportBranchOffice();
            rp.SetDataSource(bs);
            crvBranchOffice.ReportSource = rp;
            crvBranchOffice.RefreshReport();
        }
    }
}
