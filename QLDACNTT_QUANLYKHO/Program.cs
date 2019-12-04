﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLDACNTT_QUANLYKHO.Employee;
using QLDACNTT_QUANLYKHO.Stock;

namespace QLDACNTT_QUANLYKHO
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

            BonusSkins.Register();
            Application.Run(new frmInput());
            //Application.Run(new frmEmployee());  //Run 1 cai thoi het roi ko thay cai frm 

        }
    }
}
