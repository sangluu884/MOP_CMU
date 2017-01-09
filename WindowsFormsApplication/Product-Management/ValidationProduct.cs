using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication.Product_Management
{
    class ValidationProduct
    {
        public bool Required(TextBox t)
        {
            string a = t.Text.ToString();
            if (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Range(TextBox t, int min, int max)
        {
            int n = t.TextLength;
            if (n >= min && n <= max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool RegularExpression(TextBox t)
        {
            string strRegex = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(strRegex);
            string n = t.Text;
            if (re.IsMatch(n))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
