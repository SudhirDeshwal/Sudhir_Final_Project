using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sudhir_Final_Project.Classes;

namespace Sudhir_Final_Project
{
    public partial class LoginForm : Form
    {

        public bool Authenticated = false;
        public LoginForm()
        {
            InitializeComponent();
            // set the label visibility to false
            lblUsername.Visible = false;
            lblPassword.Visible = false;
        }

        //public bool authenticated
        //{
        //    get { return Authenticated; }
        //    set { Authenticated = value; }
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //  CrudOperation myObj = new CrudOperation();
            Classes.CrudOperation myobj = new CrudOperation();


            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@un AND password=@pass");
                command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                DataTable table = myobj.getData(command);

                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {

                    lblinvaliddetails.Visible = true;
                    Authenticated = false;

                }


                }

            }

            // check if the username or password are empty
            public Boolean checkFields()
            {
                //// set the label visibility to false
                //lblUsername.Visible = false;
                //lblPassword.Visible = false;

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

       

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblinvaliddetails.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblinvaliddetails.Visible = false;
        }
    }
    }



