using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Promotion_Management
{
    class Validation_Promotion
    {
        public bool Required(TextBox txt)
        {
            string a = txt.Text.ToString();
            if (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MaxLength(TextBox txt, int maxLength)
        {
            string a = txt.Text.ToString();
            if (a.Length <= maxLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MinLength(TextBox txt, int minLength)
        {
            string a = txt.Text.ToString();
            if (a.Length >= minLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Compared(TextBox txt1, TextBox txt2)
        {
            string a = txt1.Text.ToString();
            string b = txt2.Text.ToString();
            if (a == b) { return true; }
            else { return false; }
        }
        public bool Range(TextBox txt, int value1, int value2)
        {
            bool flag = false;
            if (txt.Text == null)
            {
                string s = txt.Text;
                int a = Int32.Parse(s);
                if (a >= value1 || a <= value2)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool IsNumber(string pValue) //hàm kiểm tra có phải số ko
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
