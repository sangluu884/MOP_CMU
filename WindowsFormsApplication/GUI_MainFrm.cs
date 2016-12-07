using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication.Account_Management;
using WindowsFormsApplication.Category_Management;

namespace WindowsFormsApplication
{
    public partial class GUI_MainFrm : Form
    {
        public GUI_MainFrm()
        {
            InitializeComponent();
            this.btnManageAccount.Click += btnManageAccount_Click;
        }

        void btnManageAccount_Click(object sender, EventArgs e)
        {
            GUI_Account acc = new GUI_Account();
            acc.ShowDialog();
        }

        private void ManageCategory_Click(object sender, EventArgs e)
        {
            GUI_Category category = new GUI_Category();
            category.ShowDialog();
        }
    }
}
