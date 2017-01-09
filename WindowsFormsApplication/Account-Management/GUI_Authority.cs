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
    public partial class GUI_Authority : Form
    {
        CMART0Entities db = new CMART0Entities();
        BUS_Authority BUS_Authority = new BUS_Authority();

        public GUI_Authority()
        {
            InitializeComponent();
            LoadAuthority();
            cboRole_SelectedIndexChanged(null, null);
        }

        private void LoadAuthority()
        {
            cboRole.DataSource = db.Accounts.ToList();
            cboRole.DisplayMember = "UserName";
            cboRole.ValueMember = "AccountID";
        }

        public Authority Find(string id, string nameOfAuthority)
        {
            CMART0Entities db = new CMART0Entities();
            Authority aut = new Authority();
            return db.Authorities.FirstOrDefault(x => x.AccountID == id && x.NameOfAuthority == nameOfAuthority);
        }

        public Authority Find(string id)
        {
            CMART0Entities db = new CMART0Entities();
            Authority aut = new Authority();
            return db.Authorities.FirstOrDefault(x => x.AccountID == id);
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Authority aut = new Authority();
            AuthorityName autName = new AuthorityName();
            List<AuthorityName> rs = db.AuthorityNames.ToList();
            string[] arr = new string[rs.Count];
            string accountID = cboRole.SelectedValue.ToString();
            var tam = Find(accountID);
            if (tam == null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rs[i].NameOfAuthority.ToString();
                    string accID = cboRole.SelectedValue.ToString();
                    string nameOfAuthority = arr[i];
                    bool create = false;
                    bool view = false;
                    bool update = false;
                    bool delete = false;
                    BUS_Authority.InsertAuthority(accID, nameOfAuthority, create, update, delete, view);
                }
            }

            lstAuthorities.DataSource = db.Authorities.Where(x => x.AccountID == accountID).ToList();
            lstAuthorities.Columns["Account"].Visible = false;
            lstAuthorities.Columns["AuthorityName"].Visible = false;
            lstAuthorities.Columns["NameOfAuthority"].Width = 200;
        }

        private void btnDecentralize_Click(object sender, EventArgs e)
        {
            bool message = false;
            string accID = cboRole.SelectedValue.ToString();
            foreach (DataGridViewRow row in lstAuthorities.Rows)
            {
                string nameOfAuthority = row.Cells[1].Value.ToString();
                bool create = (bool)row.Cells["Create"].Value;
                bool update = (bool)row.Cells["Update"].Value;
                bool delete = (bool)row.Cells["Delete"].Value;
                bool view = (bool)row.Cells["View"].Value;

                bool flag = BUS_Authority.UpdateAthority(accID, nameOfAuthority, create, update, delete, view);
                if (flag == true)
                {
                    message = true;
                }
                else
                {
                    message = false;
                }
            }
            if (message == true) MessageBox.Show("Decentralize successfully!");
            else MessageBox.Show("Decentralize unsuccessfully!");
        }
    }
}
