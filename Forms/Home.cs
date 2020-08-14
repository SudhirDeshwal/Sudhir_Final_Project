using Csharp_Real_Estate_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudhir_Final_Project.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThePropertyForm propertyF = new ThePropertyForm();
            propertyF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaleForm salef = new SaleForm();
            salef.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
