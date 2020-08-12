using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sudhir_Final_Project.Classes
{
    class CrudOperation
    {

        //importing connection.
        DB_CONNECTION connection = new DB_CONNECTION();


        //exe. query
        public Boolean ExecQuery(MySqlCommand command)
        {
            command.Connection = connection.getConnection;

            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        // get data
        public DataTable getData(MySqlCommand command)
        {

            command.Connection = connection.getConnection;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }




    }
}
