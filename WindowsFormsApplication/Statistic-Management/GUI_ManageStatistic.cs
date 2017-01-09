using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistic_Management
{
    public partial class GUI_ManageStatistic : Form
    {
        BUS_Statistic bus = new BUS_Statistic();
        public GUI_ManageStatistic()
        {
           
            InitializeComponent();
        }
        private void rbdate_CheckedChanged(object sender, EventArgs e)
        {
            cboday.Enabled = true;
            cbomonth.Enabled = true;
            cboyear.Enabled = true;
            dtfrom.Enabled = false;
            dtto.Enabled = false;
        }

        private void rbdistance_CheckedChanged(object sender, EventArgs e)
        {
            cboday.Enabled = false;
            cbomonth.Enabled = false;
            cboyear.Enabled = false;
            dtfrom.Enabled = true;
            dtto.Enabled = true;
        }

        public void showinformationdate(int ngay, int thang, int nam)
        {
            lstdata.DataSource = bus.showinformationdate(ngay, thang, nam);
        }
        public void showinformationdistance(DateTime from, DateTime to)
        {
            lstdata.DataSource = bus.showinformationdistance(from, to);
        }
        public void showinformationdatetop5(int ngay, int thang, int nam)
        {
            lstdata.DataSource = bus.showinformationdatetop5(ngay, thang, nam);
        }
        public void showinformationdistancetop5(DateTime from, DateTime to)
        {
            lstdata.DataSource = bus.showinformationdistancetop5(from, to);
        }
        public void showinformationdatetop10(int ngay, int thang, int nam)
        {
            lstdata.DataSource = bus.showinformationdatetop10(ngay, thang, nam);
        }
        public void showinformationdistancetop10(DateTime from, DateTime to)
        {
            lstdata.DataSource = bus.showinformationdistancetop10(from, to);
        }
        public void showinformationdatetop20(int ngay, int thang, int nam)
        {
            lstdata.DataSource = bus.showinformationdatetop20(ngay, thang, nam);
        }
        public void showinformationdistancetop20(DateTime from, DateTime to)
        {
            lstdata.DataSource = bus.showinformationdistancetop20(from, to);
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        public bool loaddata()
        {
            bool flag = false;
            if (rbdate.Checked == true)
            {
                string aaa = sumextension();
                if (aaa == "")
                {
                    if (cbofill.Text == "All")
                    {

                        int ngay = 0;
                        int thang = 0;
                        int nam = 0;
                        if (cboday.Text != "All")
                        {
                            ngay = int.Parse(cboday.Text);
                        }
                        if (cbomonth.Text != "All")
                        {
                            thang = int.Parse(cbomonth.Text);
                        }
                        if (cboyear.Text != "All")
                        {
                            nam = int.Parse(cboyear.Text);
                        }
                        showinformationdate(ngay, thang, nam);
                        flag = true;
                    }
                    if (cbofill.Text == "Top 5")
                    {
                        int ngay = 0;
                        int thang = 0;
                        int nam = 0;
                        if (cboday.Text != "All")
                        {
                            ngay = int.Parse(cboday.Text);
                        }
                        if (cbomonth.Text != "All")
                        {
                            thang = int.Parse(cbomonth.Text);
                        }
                        if (cboyear.Text != "All")
                        {
                            nam = int.Parse(cboyear.Text);
                        }
                        showinformationdatetop5(ngay, thang, nam);
                        flag = true;

                    }
                    if (cbofill.Text == "Top 10")
                    {
                        int ngay = 0;
                        int thang = 0;
                        int nam = 0;
                        if (cboday.Text != "All")
                        {
                            ngay = int.Parse(cboday.Text);
                        }
                        if (cbomonth.Text != "All")
                        {
                            thang = int.Parse(cbomonth.Text);
                        }
                        if (cboyear.Text != "All")
                        {
                            nam = int.Parse(cboyear.Text);
                        }
                        showinformationdatetop10(ngay, thang, nam);
                        flag = true;

                    }
                    if (cbofill.Text == "Top 20")
                    {
                        int ngay = 0;
                        int thang = 0;
                        int nam = 0;
                        if (cboday.Text != "All")
                        {
                            ngay = int.Parse(cboday.Text);
                        }
                        if (cbomonth.Text != "All")
                        {
                            thang = int.Parse(cbomonth.Text);
                        }
                        if (cboyear.Text != "All")
                        {
                            nam = int.Parse(cboyear.Text);
                        }
                        showinformationdatetop20(ngay, thang, nam);
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show(aaa);
                    flag = false;
                }

            }


            if (rbdistance.Checked == true)
            {
                Validate_Statistic vali = new Validate_Statistic();
                if (vali.Rangetextcbo(cbofill, "All", "Top 5", "Top 10", "Top 20") == true)
                {
                    if (cbofill.Text == "All")
                    {
                        showinformationdistance((DateTime)dtfrom.Value, (DateTime)dtto.Value);
                        flag = true;
                    }

                    if (cbofill.Text == "Top 5")
                    {
                        showinformationdistancetop5((DateTime)dtfrom.Value, (DateTime)dtto.Value);
                        flag = true;
                    }

                    if (cbofill.Text == "Top 10")
                    {
                        showinformationdistancetop10((DateTime)dtfrom.Value, (DateTime)dtto.Value);
                        flag = true;
                    }

                    if (cbofill.Text == "Top 20")
                    {
                        showinformationdistancetop20((DateTime)dtfrom.Value, (DateTime)dtto.Value);
                        flag = true;
                    }

                }
                else
                {
                    MessageBox.Show("Choose valid filter");
                    flag = false;
                }

            }
            return flag;
        }

        public string sumextension()
        {
            string sum = "";
            Validate_Statistic vali = new Validate_Statistic();
            if (vali.Requiredcbo(cboday, 1, 31) == false)
            {
                sum += "\n Choose valid day";
            }
            if (vali.Requiredcbo(cbomonth, 1, 12) == false)
            {
                sum += "\n Choose valid month";
            }
            if (vali.Requiredcbo(cboyear, 2010, 2020) == false)
            {
                sum += "\n Choose valid year";
            }
            if (vali.Rangetextcbo(cbofill, "All", "Top 5", "Top 10", "Top 20") == false)
            {
                sum += "\n Choose valid filter";
            }
            return sum;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (rbdate.Checked == true && loaddata() == true)
            {
                int ngay = 0;
                int thang = 0;
                int nam = 0;
                int fill = 2006;
                if (cboday.Text != "All")
                {
                    ngay = int.Parse(cboday.Text);

                }
                if (cbomonth.Text != "All")
                {
                    thang = int.Parse(cbomonth.Text);

                }
                if (cboyear.Text != "All")
                {
                    nam = int.Parse(cboyear.Text);
                }
                if (cbofill.Text == "All")
                {
                    fill = 0;
                }
                if (cbofill.Text == "Top 5")
                {
                    fill = 5;
                }
                if (cbofill.Text == "Top 10")
                {
                    fill = 10;
                }
                if (cbofill.Text == "Top 20")
                {
                    fill = 20;
                }
                DateTime from = new DateTime(1900, 1, 1);
                DateTime to = new DateTime(1900, 1, 1);
                GUI_ReviewsStatistic f = new GUI_ReviewsStatistic(ngay, thang, nam, from, to, 1, fill);
                f.ShowDialog();
            }
            if (rbdistance.Checked == true && loaddata() == true)
            {
                int ngay = 0;
                int thang = 0;
                int nam = 0;
                int fill = 2006;
                DateTime form = dtfrom.Value;
                DateTime to = dtto.Value;
                if (cbofill.Text == "All")
                {
                    fill = 0;
                }
                if (cbofill.Text == "Top 5")
                {
                    fill = 5;
                }
                if (cbofill.Text == "Top 10")
                {
                    fill = 10;
                }
                if (cbofill.Text == "Top 20")
                {
                    fill = 20;
                }
                GUI_ReviewsStatistic f = new GUI_ReviewsStatistic(nam, thang, ngay, form, to, 0, fill);
                f.ShowDialog();
            }

        }     
    }
}
