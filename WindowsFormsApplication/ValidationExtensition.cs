using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace WindowsFormsApplication
{
    class ValidationExtensition
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
            string strRegex = @"^[a-zA-Z0-9 ]*$";
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
        public bool RegularNumberExpression(TextBox t)
        {
            string strRegex = @"^[0-9]+$";
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
        public bool Compare(TextBox t1, TextBox t2)
        {
            string text1 = t1.Text.ToString();
            string text2 = t2.Text.ToString();
            if (text1 == text2)
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
