﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudhir_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            checkFields();
        }

        // check if the username or password are empty
        public Boolean checkFields()
        {
            // set the label visibility to false
            lblUsername.Visible = false;
            lblPassword.Visible = false;

            if (txtUsername.Text.Trim().Equals("") && txtPassword.Text.Trim().Equals(""))
            {
                lblUsername.Visible = true;
                lblPassword.Visible = true;
                return false;
            }

            else if (txtUsername.Text.Trim().Equals(""))
            {
                lblUsername.Visible = true;
                return false;
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                lblPassword.Visible = true;
                return false;
            }

            else
            {
                return true;
            }
        }




    }
}
