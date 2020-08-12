using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sudhir_Final_Project.Classes
{
    class DB_CONNECTION
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306;username = root;password =;database=sudhir_project");

        // get the connection
        public MySqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }


        // open the connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        // close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
