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

        // insert a new type
        public Boolean insertType(string name, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `property_type`(`name`, `description`) VALUES (@nm,@dscr)");

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            return func.ExecQuery(command);

        }

        // update the selected type
        public Boolean updateType(int id, string name, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `property_type` SET `name`=@nm,`description`=@dscr WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            return func.ExecQuery(command);

        }


        // delete the selected type
        public Boolean deleteType(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `property_type` WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);

        }


        // get all types
        public DataTable getAllTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_type`");

            return func.getData(command);
        }

    }
}
