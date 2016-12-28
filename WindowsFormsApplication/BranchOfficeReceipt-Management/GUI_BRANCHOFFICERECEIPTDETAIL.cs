﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.BranchOfficeReceipt_Management
{
    public partial class GUI_BRANCHOFFICERECEIPTDETAIL : Form
    {
        BUS_BRANCHOFFICERECEIPT bus = new BUS_BRANCHOFFICERECEIPT();
        String Branchid;
        String Productid;
        public GUI_BRANCHOFFICERECEIPTDETAIL(String BranchID)
        {
            InitializeComponent();
            dgBranchDetail.DataSource = bus.loadListBranchDetail(BranchID);
            Branchid = BranchID;
            bus.loadInfoBRANCHOFFICERECEIPTDETAIL(Branchid, lblHeadQuater, lblID, lblDate, lblBranch,lblAccount);
        }

        private void dgBranchDetail_Click(object sender, EventArgs e)
        {
            if (dgBranchDetail.SelectedRows.Count == 1)
            {
                var row = dgBranchDetail.SelectedRows[0];
                var cell = row.Cells["ProductID"];
                String ID = (String)cell.Value;
                Productid = ID;
                bus.loadBRANCHOFFICERECEIPTDETAIL(Branchid, ID, txtQuatity, cbbStatus);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = bus.updateBRANCHOFFICERECEIPTDETAIL(Branchid, Productid, int.Parse((txtQuatity.Text)), cbbStatus.Text);
           if (flag == true)
           {
               MessageBox.Show("Update successfully");
           }
           else
           {
               MessageBox.Show("Update unsuccessfully");
           }
           dgBranchDetail.DataSource = bus.loadListBranchDetail(Branchid);
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            dgBranchDetail.DataSource = bus.searchDetail(Branchid,txtSearch.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GUI_PrintBranch print = new GUI_PrintBranch(Branchid);
            print.ShowDialog();
        }
       
    }
}
