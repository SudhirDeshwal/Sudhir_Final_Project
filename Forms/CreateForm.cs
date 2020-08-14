using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            String owner = textBoxOwner.Text.ToString();
            String location = comboBoxLocation.SelectedItem.ToString();
            String area = textBoxArea.Text.ToString();
            String bedrooms = (string)comboBoxBedroom.SelectedItem;
            String bathrooms = (string)comboBoxBathroom.SelectedItem;
            String type = comboBoxType.SelectedItem.ToString();
            Boolean basement = checkBoxBasement.Checked;
            Boolean fireplace = checkBoxFireplace.Checked;
            Boolean patio = checkBoxPatio.Checked;

            var ViewForm = new ViewForm();
            ViewForm.Show();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}