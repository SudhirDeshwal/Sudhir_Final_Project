namespace Csharp_Real_Estate_App.Forms
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPropertyId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSoldProperties = new System.Windows.Forms.Button();
            this.buttonNotSoldProperties = new System.Windows.Forms.Button();
            this.buttonAllProperties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Name = "label1";
            // 
            // textBoxSellingPrice
            // 
            resources.ApplyResources(this.textBoxSellingPrice, "textBoxSellingPrice");
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // textBoxPropertyId
            // 
            resources.ApplyResources(this.textBoxPropertyId, "textBoxPropertyId");
            this.textBoxPropertyId.Name = "textBoxPropertyId";
            this.textBoxPropertyId.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // textBoxID
            // 
            resources.ApplyResources(this.textBoxID, "textBoxID");
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // dateTimePickerSaleDate
            // 
            resources.ApplyResources(this.dateTimePickerSaleDate, "dateTimePickerSaleDate");
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            // 
            // buttonRemove
            // 
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSales
            // 
            resources.ApplyResources(this.dataGridViewSales, "dataGridViewSales");
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Click += new System.EventHandler(this.dataGridViewSales_Click);
            // 
            // dataGridViewProperties
            // 
            resources.ApplyResources(this.dataGridViewProperties, "dataGridViewProperties");
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProperties.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProperties_CellContentClick);
            this.dataGridViewProperties.Click += new System.EventHandler(this.dataGridViewProperties_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // buttonSoldProperties
            // 
            resources.ApplyResources(this.buttonSoldProperties, "buttonSoldProperties");
            this.buttonSoldProperties.BackColor = System.Drawing.Color.White;
            this.buttonSoldProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonSoldProperties.Name = "buttonSoldProperties";
            this.buttonSoldProperties.UseVisualStyleBackColor = false;
            this.buttonSoldProperties.Click += new System.EventHandler(this.buttonSoldProperties_Click);
            // 
            // buttonNotSoldProperties
            // 
            resources.ApplyResources(this.buttonNotSoldProperties, "buttonNotSoldProperties");
            this.buttonNotSoldProperties.BackColor = System.Drawing.Color.White;
            this.buttonNotSoldProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonNotSoldProperties.Name = "buttonNotSoldProperties";
            this.buttonNotSoldProperties.UseVisualStyleBackColor = false;
            this.buttonNotSoldProperties.Click += new System.EventHandler(this.buttonNotSoldProperties_Click);
            // 
            // buttonAllProperties
            // 
            resources.ApplyResources(this.buttonAllProperties, "buttonAllProperties");
            this.buttonAllProperties.BackColor = System.Drawing.Color.White;
            this.buttonAllProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonAllProperties.Name = "buttonAllProperties";
            this.buttonAllProperties.UseVisualStyleBackColor = false;
            this.buttonAllProperties.Click += new System.EventHandler(this.buttonAllProperties_Click);
            // 
            // SaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.buttonAllProperties);
            this.Controls.Add(this.buttonNotSoldProperties);
            this.Controls.Add(this.buttonSoldProperties);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProperties);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSellingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPropertyId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSellingPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPropertyId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSoldProperties;
        private System.Windows.Forms.Button buttonNotSoldProperties;
        private System.Windows.Forms.Button buttonAllProperties;
    }
}