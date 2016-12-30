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
using WindowsFormsApplication.Promotion_Test;
using WindowsFormsApplication.Supplier_Management;
using WindowsFormsApplication.ProposeReceipt_Management;
using WindowsFormsApplication.HeadquarterReceipt_Management;
using WindowsFormsApplication.Bill_Management;
namespace WindowsFormsApplication
{
    public partial class GUI_MainFrm : Form
    {
        string getAccount;
        CMART0Entities db = new CMART0Entities();

        public GUI_MainFrm(string re)
        {
            getAccount = re;
            InitializeComponent();
            this.btnManageAccount.Click += btnManageAccount_Click;

            //AUTHORITY
            //Category
            bool viewCategory = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Category").View;
            if (viewCategory == false)
            {
                btnManageCategory.Enabled = false;
            }
            else btnManageCategory.Enabled = true;
            //Supplier
            bool viewSupplier = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Supplier").View;
            if (viewSupplier == false)
            {
                btnSupplier.Enabled = false;
            }
            else btnSupplier.Enabled = true;
            //Product
            bool viewProduct = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Product").View;
            if (viewProduct == false)
            {
                btnProduct.Enabled = false;
            }
            else btnProduct.Enabled = true;
            //Price
            bool viewPrice = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Price").View;
            if (viewPrice == false)
            {
                btnPrice.Enabled = false;
            }
            else btnPrice.Enabled = true;
            //Promotion
            bool viewPromotion = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Promotion").View;
            if (viewPromotion == false)
            {
                btnPromotion.Enabled = false;
            }
            else btnPromotion.Enabled = true;

            //Proposed
            bool viewProposed = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Propose Receipts").View;
            if (viewProposed == false)
            {
                btnProposed.Enabled = false;
            }
            else btnProposed.Enabled = true;
            //Headquarter
            bool viewHeadquarter = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Headquarters Receipts").View;
            if (viewHeadquarter == false)
            {
                btnHeadquater.Enabled = false;
            }
            else btnHeadquater.Enabled = true;
            //Branch
            bool viewBranch = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Branch Office Receipts").View;
            if (viewBranch == false)
            {
                btnBranchOffice.Enabled = false;
            }
            else btnBranchOffice.Enabled = true;

            //Invoice
            bool viewInvoice = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Invoice").View;
            if (viewInvoice == false)
            {
                btnInvoice.Enabled = false;
            }
            else btnInvoice.Enabled = true;
            //Account
            bool viewAccount = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Account").View;
            if (viewAccount == false)
            {
                btnManageAccount.Enabled = false;
            }
            else btnManageAccount.Enabled = true;
            //Statistic
            bool viewStatistic = db.Authorities.Single(x => x.AccountID == getAccount && x.NameOfAuthority == "Manage Statistics").View;
            if (viewStatistic == false)
            {
                btnStatistic.Enabled = false;
            }
            else btnStatistic.Enabled = true;
        }

        void btnManageAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Account acc = new GUI_Account(getAccount);
            acc.Closed += (s, args) => this.Close();
            acc.ShowDialog();
        }

        private void ManageCategory_Click(object sender, EventArgs e)
        {
            GUI_Category category = new GUI_Category();
            category.ShowDialog();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            PRICE.GUI_PRICE PRICE = new PRICE.GUI_PRICE();
            PRICE.ShowDialog();
           
        }

        private void btnBranchOffice_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchOfficeReceipt_Management.GUI_BRANCHOFFICERECEIPT branchOffice = new BranchOfficeReceipt_Management.GUI_BRANCHOFFICERECEIPT(getAccount);
            branchOffice.Closed += (s, args) => this.Close();
            branchOffice.ShowDialog();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_LoginFrm login = new GUI_LoginFrm();
            login.Closed += (s, args) => this.Close();
            login.ShowDialog();
        }

        private void btnHeadquater_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_HeadquarterReceipt headquarter = new GUI_HeadquarterReceipt(getAccount);
            headquarter.Closed += (s, args) => this.Close();
            headquarter.ShowDialog();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            GUI_Promote promotion = new GUI_Promote();
            promotion.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_InsertBill bill = new GUI_InsertBill(getAccount);
            bill.Closed += (s, args) => this.Close();
            bill.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product_Management.frmGUI product = new Product_Management.frmGUI();
            product.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            GUI_Supplier supplier = new GUI_Supplier();
            supplier.ShowDialog();
        }

        private void btnProposed_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Propose proposed = new GUI_Propose(getAccount);
            proposed.Closed += (s, args) => this.Close();
            proposed.ShowDialog();
        }

     
    }
}
