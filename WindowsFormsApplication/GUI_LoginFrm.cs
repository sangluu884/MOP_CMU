using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class GUI_LoginFrm : Form
    {
        public GUI_LoginFrm()
        {
            InitializeComponent();
            lblAUsername.Visible = false;
            lblAPassword.Visible = false;
        }

        public Account Find(string userName)
        {
            CMART0Entities db = new CMART0Entities();
            Account acc = new Account();
            return db.Accounts.FirstOrDefault(x => x.UserName == userName);
        }

        public bool Required(TextBox txt)
        {
            string tam = txt.Text.ToString();
            if (string.IsNullOrEmpty(tam) || string.IsNullOrWhiteSpace(tam))
            {
                return false;
            }
            else return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var nv = Find(txtUserName.Text);
            if (nv == null)
            {
                lblAUsername.Text = "Incorrect User name";
                lblAUsername.Visible = true;

            }
            else
            {
                lblAUsername.Visible = false;
                if (!nv.Password.Equals(txtPassoword.Text))
                {
                    lblAPassword.Text = "Incorrect Password";
                    lblAPassword.Visible = true;
                }
                else lblAPassword.Visible = false;
            }
            if ((nv != null) && (nv.Password.Equals(txtPassoword.Text)))
            {
                GUI_MainFrm main = new GUI_MainFrm();
                //GUI_LoginFrm login = new GUI_LoginFrm();
                //login.Close();
                main.Show();
            }
        }
    }
}
