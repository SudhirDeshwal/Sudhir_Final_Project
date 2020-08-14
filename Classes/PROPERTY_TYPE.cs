using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sudhir_Final_Project.Classes;

namespace Csharp_Real_Estate_App.Classes
{
    class PROPERTY_TYPE
    {

        CrudOperation func = new CrudOperation();



        // get all types
        public DataTable getAllTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_type`");

            return func.getData(command);
        }

    }
}
