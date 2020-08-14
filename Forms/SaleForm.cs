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

namespace Csharp_Real_Estate_App.Forms
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        Classes.SALE sale = new Classes.SALE();
        CrudOperation func = new CrudOperation();
        string query;

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // populate datagridview sales
            dataGridViewSales.DataSource = sale.getSales();


            // populate datagridview properties
            query = "SELECT `id`,`price`, `address` FROM `the_property`";
            populateDatagridview(dataGridViewProperties, query);

            // clear selection form gridviews
            dataGridViewSales.ClearSelection();
          
            dataGridViewProperties.ClearSelection();
        }

        // add a new sale
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // we don't need the id 
                //int id = Convert.ToInt32(textBoxID.Text);
                int propertyId = Convert.ToInt32(textBoxPropertyId.Text);
                
                string sellingPrice = textBoxSellingPrice.Text;
                DateTime sellingDate = dateTimePickerSaleDate.Value;
 
                if(sale.insertSale(new Classes.SALE(0,propertyId,sellingDate,sellingPrice)))
                {
                    MessageBox.Show("New Sale Added", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // refresh datagridview sales
                    dataGridViewSales.DataSource = sale.getSales();
                }
                else
                {
                    MessageBox.Show("Sale Not Added", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // edit the selected sale
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            { 
                int id = Convert.ToInt32(textBoxID.Text);
                int propertyId = Convert.ToInt32(textBoxPropertyId.Text);
                
                string sellingPrice = textBoxSellingPrice.Text;
                DateTime sellingDate = dateTimePickerSaleDate.Value;

                if (sale.updateSale(new Classes.SALE(id, propertyId, sellingDate, sellingPrice)))
                {
                    MessageBox.Show("Sale Edited", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // refresh datagridview sales
                    dataGridViewSales.DataSource = sale.getSales();
                }
                else
                {
                    MessageBox.Show("Sale Not Edited", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // remove the selected sale
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                if (sale.deleteSale(id))
                {
                    MessageBox.Show("Sale Deleted", "Remove Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // refresh datagridview sales
                    dataGridViewSales.DataSource = sale.getSales();

                    // clear fields
                    textBoxID.Text = "";
                    
                    textBoxPropertyId.Text = "";
                    textBoxSellingPrice.Text = "";
                    dateTimePickerSaleDate.Value = DateTime.Now;

                    // clear selection form gridviews
                    dataGridViewSales.ClearSelection();
                   
                    dataGridViewProperties.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Sale Not Deleted", "Remove Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get the client id
        private void dataGridViewClients_Click(object sender, EventArgs e)
        {
            //textBoxClientId.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
        }


        // get the property id and price
        private void dataGridViewProperties_Click(object sender, EventArgs e)
        {
            textBoxPropertyId.Text = dataGridViewProperties.CurrentRow.Cells[0].Value.ToString();
            textBoxSellingPrice.Text = dataGridViewProperties.CurrentRow.Cells[1].Value.ToString();
        }

        // display the selected sale data
        private void dataGridViewSales_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewSales.CurrentRow.Cells[0].Value.ToString();
            textBoxPropertyId.Text = dataGridViewSales.CurrentRow.Cells[1].Value.ToString();
          
            textBoxSellingPrice.Text = dataGridViewSales.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerSaleDate.Value = Convert.ToDateTime(dataGridViewSales.CurrentRow.Cells[3].Value);
        }


        // button refresh the datagridview clients
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // populate datagridview clients
            //populateDatagridview(dataGridViewClients, "SELECT `id`, `first_name`, `last_name` FROM `property_client`");

        }

        // button display only the properties sold
        private void buttonSoldProperties_Click(object sender, EventArgs e)
        {
            query = "SELECT `id`,`price`, `address` FROM `the_property` WHERE `id` IN (SELECT property_id from sale)";
            populateDatagridview(dataGridViewProperties, query);
        }

        // button display the properties not sold
        private void buttonNotSoldProperties_Click(object sender, EventArgs e)
        {
            query = "SELECT `id`, `price`, `address` FROM `the_property` WHERE `id` not IN (SELECT property_id from sale)";
            populateDatagridview(dataGridViewProperties, query);
        }

        // button display all properties
        private void buttonAllProperties_Click(object sender, EventArgs e)
        {
            query = "SELECT `id`, `price`, `address` FROM `the_property`";
            populateDatagridview(dataGridViewProperties, query);
        }

        // create a function to populate the datagridview
        public void populateDatagridview(DataGridView dgv, string query)
        {
            MySqlCommand command = new MySqlCommand(query);
            dgv.DataSource = func.getData(command);
        }

        // button show client form
        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            //PropertyClientForm propClientF = new PropertyClientForm();
            //propClientF.Show();
        }

        private void dataGridViewProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

