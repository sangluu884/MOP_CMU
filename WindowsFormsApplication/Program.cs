﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication.ProposeReceipt_Management;

namespace WindowsFormsApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI_Propose());
            Application.Run(new GUI_LoginFrm());
            //Product_Management.frmGUI
            //GUI_LoginFrm()
            //Promotion_Management.GUI_Promotion
        }
    }
}
