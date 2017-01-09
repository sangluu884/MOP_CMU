using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Bill_Management
{
    class ValidationExtension
    {
        public bool Required(TextBox t)
        {
            string a = t.Text.ToString();
            if (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Requiredcbo(ComboBox t)
        {
            if (t.SelectedIndex == -1)//Nothing selected
            {

                return false;
            }

            else
            {
                return true;
            }
        }
        public bool Compared(float a, float b)
        {
            if (a <= b)
            {
                return true;
            }
            return false;
        }
    }
}
