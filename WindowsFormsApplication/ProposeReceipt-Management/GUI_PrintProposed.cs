using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.ProposeReceipt_Management
{
    public partial class GUI_PrintProposed : Form
    {
        BUS_ProposedDetail Bus_Detail = new BUS_ProposedDetail();
        string proposedID;

        public GUI_PrintProposed(string id)
        {
            InitializeComponent();
            proposedID = id;
            LoadPrint();
        }

        private void LoadPrint()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Bus_Detail.printProposedDetail(proposedID);
            CrystalReportProposed rp = new CrystalReportProposed();
            rp.SetDataSource(bs);
            crv_ProposedView.ReportSource = rp;
            crv_ProposedView.RefreshReport(); 
        }
    }
}
