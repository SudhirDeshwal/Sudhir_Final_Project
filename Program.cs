﻿using Sudhir_Final_Project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudhir_Final_Project
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
           //  Application.Run(new LoginForm());


        LoginForm loginF = new LoginForm();

            if (loginF.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Home());
            }
            else
            {
                Application.Exit();


            }
        }
    }
}

