using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Account_Management
{
    public partial class GUI_Account : Form
    {
        BUS_Account BUS_Acc = new BUS_Account();
        ValidationExtensition validation = new ValidationExtensition();
        string getAccount;

        public GUI_Account(string re)
        {
            InitializeComponent();
            LoadAccount();
            getAccount=re;
        }

        private void LoadAccount()
        {
            lstAccounts.DataSource = BUS_Acc.LoadListAccount();
            lstAccounts.Columns["Authorities"].Visible = false;
            lstAccounts.Columns["Bills"].Visible = false;
            lstAccounts.Columns["ProposeReceipts"].Visible = false;
            lstAccounts.Columns["BranchOfficeReceipts"].Visible = false;
            lstAccounts.Columns["HeadquaterReceipts"].Visible = false;
        }

        public void Clean()
        {
            txtAddress.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string tmp = null;
            string accountID = txtAccountID.Text;
            string fullName = txtFullName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string cMND = txtCMND.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (validation.Required(txtFullName) || validation.Required(txtAddress) || validation.Required(txtPhoneNumber) || validation.Required(txtCMND) || validation.Required(txtUserName) || validation.Required(txtPassword) || validation.RegularNumberExpression(txtPhoneNumber) || validation.RegularNumberExpression(txtCMND))
            {
                if (validation.Required(txtFullName))
                {
                    tmp += "Full Name can't empty \n";
                } if (validation.Required(txtAddress))
                {
                    tmp += "Address can't empty \n";
                } if (validation.Required(txtPhoneNumber))
                {
                    tmp += "Phone Number can't empty \n";
                }
                if (!validation.Required(txtPhoneNumber) && validation.RegularNumberExpression(txtPhoneNumber))
                {
                    tmp += "Phone Number must be numbers only \n";
                }
                if (validation.Required(txtCMND))
                {
                    tmp += "CMND can't empty \n";
                }
                if (!validation.Required(txtCMND) && validation.RegularNumberExpression(txtCMND))
                {
                    tmp += "CMND must be numbers only\n";
                }
                if (validation.Required(txtUserName))
                {
                    tmp += "User can't empty \n";
                }
                if (validation.Required(txtPassword))
                {
                    tmp += "Password can't empty \n";
                }
                if (validation.Required(txtConfirmPassword))
                {
                    tmp += "Confirm Password can't empty \n";
                }
                if (tmp != null)
                {
                    MessageBox.Show(tmp);
                }
            }
            else
            {
                if (txtConfirmPassword.Text == password)
                {
                    bool flag = BUS_Acc.InsertAccount(accountID, fullName, address, phoneNumber, cMND, userName, password);
                    if (flag == true)
                        MessageBox.Show("Create account successfully!");
                    else MessageBox.Show("Create account unsuccessfully!");
                    Clean();
                    LoadAccount();
                }
                else MessageBox.Show("Confirm password is not correct");

            }
            
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string accountID = txtAccountID.Text;
            string fullName = txtFullName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string cMND = txtCMND.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (txtConfirmPassword.Text == password)
            {
                bool flag = BUS_Acc.UpdateAccount(accountID, fullName, address, phoneNumber, cMND, userName, password);
                if (flag == true)
                    MessageBox.Show("Update account successfully!");
                else MessageBox.Show("Update account unsuccessfully!");
                Clean();
                LoadAccount();
            }
            else MessageBox.Show("Confirm password is not correct");
        }

        private void lstAccounts_DoubleClick(object sender, EventArgs e)
        {
            Account acc = new Account();
            CMART0Entities db = new CMART0Entities();
            
            if (lstAccounts.SelectedRows.Count == 1)
            {
                var row = lstAccounts.SelectedRows[0];
                var cell = row.Cells["AccountID"];
                string accountID = (string)cell.Value;
                acc = db.Accounts.Single(x => x.AccountID == accountID);
                txtAccountID.Text = acc.AccountID;
                txtFullName.Text = acc.FullName;
                txtAddress.Text = acc.Address;
                txtPhoneNumber.Text = acc.PhoneNumber;
                txtCMND.Text = acc.CMND;
                txtUserName.Text = acc.UserName;
                txtPassword.Text = acc.Password;
                txtConfirmPassword.Text = acc.Password;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (lstAccounts.SelectedRows.Count == 1)
            {
                var row = lstAccounts.SelectedRows[0];
                var cell = row.Cells["AccountID"];
                string accountID = (string)cell.Value;
                DialogResult result = MessageBox.Show("Do you really want to delete the Account \"" + accountID + "\"?", "Confirm product deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    BUS_Acc.Delete(accountID);
                    LoadAccount();
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string searchText = txtSearch.Text;
            lstAccounts.DataSource = BUS_Acc.Search(txtSearch.Text);
        }

        private void btnAuthorityManagement_Click(object sender, EventArgs e)
        {
            GUI_Authority aut = new GUI_Authority();
            aut.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MainFrm main = new GUI_MainFrm(getAccount);
            main.Closed += (s, args) => this.Close();
            main.ShowDialog();
        }
    }
}
