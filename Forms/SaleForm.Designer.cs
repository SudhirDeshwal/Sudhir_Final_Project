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
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(518, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 90);
            this.label1.TabIndex = 27;
            this.label1.Text = "SALE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSellingPrice
            // 
            this.textBoxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSellingPrice.Location = new System.Drawing.Point(177, 350);
            this.textBoxSellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            this.textBoxSellingPrice.Size = new System.Drawing.Size(184, 34);
            this.textBoxSellingPrice.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "Selling Price:";
            // 
            // textBoxPropertyId
            // 
            this.textBoxPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPropertyId.Location = new System.Drawing.Point(177, 222);
            this.textBoxPropertyId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPropertyId.Name = "textBoxPropertyId";
            this.textBoxPropertyId.ReadOnly = true;
            this.textBoxPropertyId.Size = new System.Drawing.Size(141, 34);
            this.textBoxPropertyId.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Property Id:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(177, 161);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(141, 34);
            this.textBoxID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(7, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 4);
            this.panel1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(105, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date:";
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(177, 411);
            this.dateTimePickerSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(184, 34);
            this.dateTimePickerSaleDate.TabIndex = 47;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(21, 618);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(341, 46);
            this.buttonRemove.TabIndex = 50;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(21, 554);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(341, 46);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(21, 487);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(341, 46);
            this.buttonAdd.TabIndex = 48;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(413, 196);
            this.dataGridViewSales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.Size = new System.Drawing.Size(467, 431);
            this.dataGridViewSales.TabIndex = 51;
            this.dataGridViewSales.Click += new System.EventHandler(this.dataGridViewSales_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProperties.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(912, 196);
            this.dataGridViewProperties.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersWidth = 51;
            this.dataGridViewProperties.Size = new System.Drawing.Size(369, 431);
            this.dataGridViewProperties.TabIndex = 53;
            this.dataGridViewProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProperties_CellContentClick);
            this.dataGridViewProperties.Click += new System.EventHandler(this.dataGridViewProperties_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(408, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Sales List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(995, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 29);
            this.label9.TabIndex = 56;
            this.label9.Text = "Properties List";
            // 
            // buttonSoldProperties
            // 
            this.buttonSoldProperties.BackColor = System.Drawing.Color.White;
            this.buttonSoldProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoldProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoldProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonSoldProperties.Location = new System.Drawing.Point(912, 632);
            this.buttonSoldProperties.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSoldProperties.Name = "buttonSoldProperties";
            this.buttonSoldProperties.Size = new System.Drawing.Size(369, 32);
            this.buttonSoldProperties.TabIndex = 58;
            this.buttonSoldProperties.Text = "Properties Sold";
            this.buttonSoldProperties.UseVisualStyleBackColor = false;
            this.buttonSoldProperties.Click += new System.EventHandler(this.buttonSoldProperties_Click);
            // 
            // buttonNotSoldProperties
            // 
            this.buttonNotSoldProperties.BackColor = System.Drawing.Color.White;
            this.buttonNotSoldProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotSoldProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotSoldProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonNotSoldProperties.Location = new System.Drawing.Point(912, 672);
            this.buttonNotSoldProperties.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNotSoldProperties.Name = "buttonNotSoldProperties";
            this.buttonNotSoldProperties.Size = new System.Drawing.Size(369, 32);
            this.buttonNotSoldProperties.TabIndex = 59;
            this.buttonNotSoldProperties.Text = "Properties Not Sold";
            this.buttonNotSoldProperties.UseVisualStyleBackColor = false;
            this.buttonNotSoldProperties.Click += new System.EventHandler(this.buttonNotSoldProperties_Click);
            // 
            // buttonAllProperties
            // 
            this.buttonAllProperties.BackColor = System.Drawing.Color.White;
            this.buttonAllProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllProperties.ForeColor = System.Drawing.Color.Black;
            this.buttonAllProperties.Location = new System.Drawing.Point(912, 712);
            this.buttonAllProperties.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllProperties.Name = "buttonAllProperties";
            this.buttonAllProperties.Size = new System.Drawing.Size(369, 32);
            this.buttonAllProperties.TabIndex = 60;
            this.buttonAllProperties.Text = "All Properties";
            this.buttonAllProperties.UseVisualStyleBackColor = false;
            this.buttonAllProperties.Click += new System.EventHandler(this.buttonAllProperties_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1301, 750);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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