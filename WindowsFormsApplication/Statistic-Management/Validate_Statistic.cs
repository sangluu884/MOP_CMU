using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistic_Management
{
    class Validate_Statistic
    {
        public bool Requiredcbo(ComboBox t, int min, int max)
        {
            bool flag = false;
            if (t.Text == "All")
            {
                flag = true;
            }
            else
            {
                try
                {
                    int a = int.Parse(t.Text);
                    if (a < min || a > max)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                catch (Exception e1)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public bool Rangetextcbo(ComboBox t, string a, string b, string c, string d)
        {
            if (t.Text == a)
            {
                return true;
            }
            if (t.Text == b)
            {
                return true;
            }
            if (t.Text == c)
            {
                return true;
            }
            if (t.Text == d)
            {
                return true;
            }
            return false;
        }
    }
}
