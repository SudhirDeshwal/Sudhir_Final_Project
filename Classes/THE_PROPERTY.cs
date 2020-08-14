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
    class THE_PROPERTY
    {

        private int id;
        private int type;
        private int size;
        private int age;
        private int bedrooms;
        private int bathrooms;
        private string price;
        private string address;
        private string comment;
        private bool balcony;
        private bool backyard;
        private bool fireplace;
        private bool garage;
        private bool pool;


        CrudOperation func = new CrudOperation();


        public THE_PROPERTY() { }

        public THE_PROPERTY(int ID , int TYPE,int SIZE, int AGE, int BEDROOMS, int BATHROOMS, string ADDRESS,
                            string PRICE, string COMMENT, bool BALCONY, bool BACKYARD, bool GARAGE,bool FIREPLACE, bool POOL)
        {
           this.id = ID;
            this.type = TYPE;
            this.size = SIZE;
            this.price = PRICE;
            this.age = AGE;
            this.bedrooms = BEDROOMS;
            this.bathrooms = BATHROOMS;
            this.address = ADDRESS;
            this.comment = COMMENT;
            this.balcony = BALCONY;
            this.backyard = BACKYARD;
            this.garage = GARAGE;
            this.fireplace = FIREPLACE;
            this.pool = POOL;
        }

        // insert a new property
        public Boolean insertProperty(THE_PROPERTY property)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `the_property`(`type`, `square_feet`, `price`, `address`, `bedrooms`, `bathrooms`, `age`, `balcony`, `backyard`, `pool`, `garage`, `fireplace`, `comment`) VALUES (@tp,@size,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt)");

            // (@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt)
          //  command.Parameters.Add("@tp", MySqlDbType.Int32).Value = property.id;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = property.type;
            command.Parameters.Add("@size", MySqlDbType.VarChar).Value = property.size;
           // command.Parameters.Add("@owner", MySqlDbType.Int32).Value = property.ownerId;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = property.price;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = property.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = property.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = property.bathrooms;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = property.age;
            command.Parameters.AddWithValue("@balc", property.balcony);
            command.Parameters.AddWithValue("@backy", property.backyard);
            command.Parameters.AddWithValue("@pool", property.pool);
            command.Parameters.AddWithValue("@grg", property.garage);
            command.Parameters.AddWithValue("@fire", property.fireplace);
            command.Parameters.Add("@cmnt", MySqlDbType.VarChar).Value = property.comment;

            return func.ExecQuery(command);

        }

        // edit the selected property
        public Boolean updateProperty(THE_PROPERTY property)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `the_property` SET `type`=@tp,`square_feet`=@size,`price`=@price,`address`=@adrs,`bedrooms`=@bedr,`bathrooms`=@bathr,`age`=@age,`balcony`=@balc,`backyard`=@backy,`pool`=@pool,`garage`=@grg,`fireplace`=@fire,`comment`=@cmnt WHERE `id`=@id");

            // (@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt)
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = property.id;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = property.type;
            command.Parameters.Add("@size", MySqlDbType.VarChar).Value = property.size;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = property.price;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = property.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = property.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = property.bathrooms;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = property.age;
            command.Parameters.AddWithValue("@balc", property.balcony);
            command.Parameters.AddWithValue("@backy", property.backyard);
            command.Parameters.AddWithValue("@pool", property.pool);
            command.Parameters.AddWithValue("@grg", property.garage);
            command.Parameters.AddWithValue("@fire", property.fireplace);
            command.Parameters.Add("@cmnt", MySqlDbType.VarChar).Value = property.comment;

            return func.ExecQuery(command);

        }

        // remove the selected property
        public Boolean deleteProperty(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `the_property` WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);

        }

        // get all properties


        // get property by id
        public DataTable getPropertyById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `the_property` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return func.getData(command);
        }
    }
}
