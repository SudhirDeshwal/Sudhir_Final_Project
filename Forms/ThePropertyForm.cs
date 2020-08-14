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

namespace Csharp_Real_Estate_App.Forms
{
    public partial class ThePropertyForm : Form
    {
        public ThePropertyForm()
        {
            InitializeComponent();
        }

        Classes.THE_PROPERTY property = new Classes.THE_PROPERTY();

        private void ThePropertyForm_Load(object sender, EventArgs e)
        {
            // populate the combobox with property types
            Classes.PROPERTY_TYPE pType = new Classes.PROPERTY_TYPE();
            comboBoxType.DataSource = pType.getAllTypes();
            comboBoxType.DisplayMember = "name";
            comboBoxType.ValueMember = "id";
        }

        // insert a new property
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
               // int ID = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string comment = textBoxComment.Text;
                int bedrooms = (int)numericUpDownBedrooms.Value;
                int bathrooms = (int)numericUpDownBathrooms.Value;
                int age = (int)numericUpDownAge.Value;

                Boolean hasBalcony = checkBoxBalcony.Checked;
                Boolean hasBackyard = checkBoxBackyard.Checked;
                Boolean hasGarage = checkBoxGarage.Checked;
                Boolean hasPool = checkBoxPool.Checked;
                Boolean hasFireplace = checkBoxFireplace.Checked;

                MessageBox.Show(" *Balcony - " + hasBalcony + " *Balckyard - " + hasBackyard + " *Garage - " + hasGarage + " *Pool - " + hasPool + " *Fireplace - " + hasFireplace);

                if (verifTextBoxes())
                {
                    if (property.insertProperty(new Classes.THE_PROPERTY(0,type,size, age, bedrooms, bathrooms, address, price, comment, hasBalcony, hasBackyard, hasGarage, hasFireplace, hasPool)))
                    {
                        MessageBox.Show("New Property Added", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Property Not Added", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Required Fields ( size - address - price )", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // update the selected property
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
    
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string comment = textBoxComment.Text;
                int bedrooms = (int)numericUpDownBedrooms.Value;
                int bathrooms = (int)numericUpDownBathrooms.Value;
                int age = (int)numericUpDownAge.Value;

                Boolean hasBalcony = checkBoxBalcony.Checked;
                Boolean hasBackyard = checkBoxBackyard.Checked;
                Boolean hasGarage = checkBoxGarage.Checked;
                Boolean hasPool = checkBoxPool.Checked;
                Boolean hasFireplace = checkBoxFireplace.Checked;

                // MessageBox.Show(" *Balcony - " + hasBalcony + " *Balckyard - " + hasBackyard + " *Garage - " + hasGarage + " *Pool - " + hasPool + " *Fireplace - " + hasFireplace);

                if (verifTextBoxes())
                {
                    if (property.updateProperty(new Classes.THE_PROPERTY(id, type,size, age, bedrooms, bathrooms, address, price, comment, hasBalcony, hasBackyard, hasGarage, hasFireplace, hasPool)))
                    {
                        MessageBox.Show("Property Data Updated", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Property Data Not Updated", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Required Fields ( size - address - price )", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // remove the selected property
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                // show a confirmation message before deleting the property
                if(MessageBox.Show("Are You Sure You Want To Delete This Property ?","Delete Property",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (property.deleteProperty(id))
                    {
                        MessageBox.Show("Property Deleted", "Remove Property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Property Not Deleted", "Remove Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Enter a Valid Property ID", "Remove Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // show all properties in a new form
        private void buttonShowAllProperties_Click(object sender, EventArgs e)
        {
            PropertiesListForm propsListF = new PropertiesListForm();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `the_property`");
            
            propsListF.populateDataGridview(command);

            propsListF.ShowDialog();
        }

        // show the selected property images in a new form
        private void buttonShowPropertyImages_Click(object sender, EventArgs e)
        {
            
            
        }

        // search property by id
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // get the property id
                int id = Convert.ToInt32(textBoxID.Text);

                // get the property data using the id
                DataTable propertyData = property.getPropertyById(id);

                // display the property data
     
                textBoxSize.Text = propertyData.Rows[0]["square_feet"].ToString();
                textBoxPrice.Text = propertyData.Rows[0]["price"].ToString();
                textBoxAddress.Text = propertyData.Rows[0]["address"].ToString();
                textBoxComment.Text = propertyData.Rows[0]["comment"].ToString();
                comboBoxType.SelectedValue = propertyData.Rows[0]["type"];
                numericUpDownAge.Value = Convert.ToDecimal(propertyData.Rows[0]["age"]);
                numericUpDownBedrooms.Value = Convert.ToDecimal(propertyData.Rows[0]["bedrooms"]);
                numericUpDownBathrooms.Value = Convert.ToDecimal(propertyData.Rows[0]["bathrooms"]);
                checkBoxBalcony.Checked = (bool)propertyData.Rows[0]["balcony"];
                checkBoxBackyard.Checked = (bool)propertyData.Rows[0]["backyard"];
                checkBoxGarage.Checked = (bool)propertyData.Rows[0]["garage"];
                checkBoxFireplace.Checked = (bool)propertyData.Rows[0]["fireplace"];
                checkBoxPool.Checked = (bool)propertyData.Rows[0]["pool"];
            }
            catch
            {
                if(textBoxID.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter The Property ID First", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("This Property Does Not Exists", "Property Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearFields();
                }
                
            }
            
        }





        // open a new form to select the property owner
        private void buttonSelectOwner_Click(object sender, EventArgs e)
        {
            
        }


        // create a function to verify if any of the required fields is empty
        public bool verifTextBoxes()
        {
            string size = textBoxSize.Text.Trim();
            string price = textBoxPrice.Text.Trim();
            string address = textBoxAddress.Text.Trim();

            // you can verify the other fields if you want

            if (size.Equals("") || price.Equals("") || address.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // create a function to clear all fields
        public void clearFields()
        {
            textBoxID.Text = "";
           
            textBoxSize.Text = "";
            textBoxPrice.Text = "";
            textBoxAddress.Text = "";
            textBoxComment.Text = "";
            comboBoxType.SelectedIndex = 0;
            numericUpDownAge.Value = 0;
            numericUpDownBedrooms.Value = 0;
            numericUpDownBathrooms.Value = 0;
            checkBoxBalcony.Checked = false;
            checkBoxBackyard.Checked = false;
            checkBoxGarage.Checked = false;
            checkBoxFireplace.Checked = false;
            checkBoxPool.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
