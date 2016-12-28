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
        CMART0Entities db = new CMART0Entities();
       
        public GUI_LoginFrm()
        {
            InitializeComponent();
            lblAUsername.Visible = false;
            lblAPassword.Visible = false;
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

        public void btnLogin_Click(object sender, EventArgs e)
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
                this.Hide();
                GUI_MainFrm main = new GUI_MainFrm(Test());
                main.Closed += (s, args) => this.Close();
                main.ShowDialog();
            }
           
        }

        public string Test()
        {
            Account kq=null;
            var nv = Find(txtUserName.Text);
            if ((nv != null) && (nv.Password.Equals(txtPassoword.Text)))
            {
                kq = nv;
            }
            string re = kq.AccountID;
            return re;
        }

        public Account Find(string userName)
        {
            CMART0Entities db = new CMART0Entities();
            Account acc = new Account();
            return db.Accounts.FirstOrDefault(x => x.UserName == userName);
        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    this.Hide();
                    GUI_MainFrm main = new GUI_MainFrm(Test());
                    main.Closed += (s, args) => this.Close();
                    main.ShowDialog();
                }
            }
        }

    }
}
