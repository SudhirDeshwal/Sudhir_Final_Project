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
    public partial class PropertiesListForm : Form
    {
        public PropertiesListForm()
        {
            InitializeComponent();
        }

        private void PropertiesListForm_Load(object sender, EventArgs e)
        {
            
        }

        public void populateDataGridview(MySqlCommand command)
        {
            // change the datagridview row height
            dataGridView1.RowTemplate.Height = 40;

            // populate the datagridview
            CrudOperation func = new CrudOperation();
            dataGridView1.DataSource = func.getData(command);

            // display properties count
            labelCount.Text = "[ " + func.getData(command).Rows.Count + " ] Properties";

            // clear the selection form the datagridview
            dataGridView1.ClearSelection();
        }
    }
}
