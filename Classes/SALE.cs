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
    class SALE
    {
        private int id;
        private int propertyid;
        private DateTime sellingdate;
        private string sellingprice;


        public SALE() { }

        public SALE(int ID, int PR_ID,DateTime SALE_DATE,string SALE_PRICE)
        {
            this.id = ID;
            this.propertyid = PR_ID;
           
            this.sellingdate = SALE_DATE;
            this.sellingprice = SALE_PRICE;
        }

        CrudOperation func = new CrudOperation();



        // insert a sale
        public bool insertSale(SALE sale)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `sale`(`property_id`,`selling_price`, `sale_date`) VALUES (@pid,@slprice,@sldate)");

            // @pid,@clid,@slprice,@sldate
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = sale.propertyid;
            command.Parameters.Add("@slprice", MySqlDbType.Int32).Value = sale.sellingprice;
            command.Parameters.Add("@sldate", MySqlDbType.Date).Value = sale.sellingdate;

            return func.ExecQuery(command);
        }


        // edit the selected sale
        public bool updateSale(SALE sale)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `sale` SET `property_id`=@pid,`selling_price`=@slprice,`sale_date`=@sldate WHERE `id`=@id");

            //@id,@pid,@clid,@slprice,@sldate
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = sale.propertyid;
            
            command.Parameters.Add("@slprice", MySqlDbType.Int32).Value = sale.sellingprice;
            command.Parameters.Add("@sldate", MySqlDbType.Date).Value = sale.sellingdate;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = sale.id;

            return func.ExecQuery(command);
        }

        // remove the selected sale
        public bool deleteSale(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `sale` WHERE `id`=@id");

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);
        }



        // get all sales
        public DataTable getSales()
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `property_id` as 'Property', `selling_price` as 'Price', `sale_date` as 'Date' FROM `sale`");
            return func.getData(command);
        }

    }
}
