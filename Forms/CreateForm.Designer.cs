namespace WindowsFormsApp
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxBasement = new System.Windows.Forms.CheckBox();
            this.checkBoxFireplace = new System.Windows.Forms.CheckBox();
            this.checkBoxPatio = new System.Windows.Forms.CheckBox();
            this.comboBoxBedroom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxBathroom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Brampton",
            "Toronto",
            "Mississauga",
            "Etobicoke",
            "Caledon",
            "Vaughan",
            "Burlington",
            "Barrie",
            "Malton"});
            this.comboBoxLocation.Location = new System.Drawing.Point(215, 149);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(164, 33);
            this.comboBoxLocation.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Condo",
            "Deattached",
            "Studio",
            "Single",
            "Town House",
            "Apartment"});
            this.comboBoxType.Location = new System.Drawing.Point(603, 250);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(164, 33);
            this.comboBoxType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(212, 234);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(136, 31);
            this.textBoxArea.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sq, ft";
            // 
            // checkBoxBasement
            // 
            this.checkBoxBasement.AutoSize = true;
            this.checkBoxBasement.Location = new System.Drawing.Point(82, 311);
            this.checkBoxBasement.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxBasement.Name = "checkBoxBasement";
            this.checkBoxBasement.Size = new System.Drawing.Size(120, 29);
            this.checkBoxBasement.TabIndex = 8;
            this.checkBoxBasement.Text = "Basement";
            this.checkBoxBasement.UseVisualStyleBackColor = true;
            // 
            // checkBoxFireplace
            // 
            this.checkBoxFireplace.AutoSize = true;
            this.checkBoxFireplace.Location = new System.Drawing.Point(322, 311);
            this.checkBoxFireplace.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxFireplace.Name = "checkBoxFireplace";
            this.checkBoxFireplace.Size = new System.Drawing.Size(113, 29);
            this.checkBoxFireplace.TabIndex = 9;
            this.checkBoxFireplace.Text = "Fireplace";
            this.checkBoxFireplace.UseVisualStyleBackColor = true;
            // 
            // checkBoxPatio
            // 
            this.checkBoxPatio.AutoSize = true;
            this.checkBoxPatio.Location = new System.Drawing.Point(603, 311);
            this.checkBoxPatio.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxPatio.Name = "checkBoxPatio";
            this.checkBoxPatio.Size = new System.Drawing.Size(80, 29);
            this.checkBoxPatio.TabIndex = 10;
            this.checkBoxPatio.Text = "Patio";
            this.checkBoxPatio.UseVisualStyleBackColor = true;
            // 
            // comboBoxBedroom
            // 
            this.comboBoxBedroom.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "",
            "",
            "",
            ""});
            this.comboBoxBedroom.FormattingEnabled = true;
            this.comboBoxBedroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBedroom.Location = new System.Drawing.Point(603, 65);
            this.comboBoxBedroom.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxBedroom.Name = "comboBoxBedroom";
            this.comboBoxBedroom.Size = new System.Drawing.Size(164, 33);
            this.comboBoxBedroom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bedrooms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bathrooms";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(216, 67);
            this.textBoxOwner.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(136, 31);
            this.textBoxOwner.TabIndex = 15;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(77, 73);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 25);
            this.label.TabIndex = 16;
            this.label.Text = "Owner Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.Location = new System.Drawing.Point(292, 407);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 52);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add Property";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxBathroom
            // 
            this.comboBoxBathroom.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "",
            "",
            "",
            ""});
            this.comboBoxBathroom.FormattingEnabled = true;
            this.comboBoxBathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBathroom.Location = new System.Drawing.Point(603, 152);
            this.comboBoxBathroom.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxBathroom.Name = "comboBoxBathroom";
            this.comboBoxBathroom.Size = new System.Drawing.Size(164, 33);
            this.comboBoxBathroom.TabIndex = 18;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1312, 603);
            this.Controls.Add(this.comboBoxBathroom);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBedroom);
            this.Controls.Add(this.checkBoxPatio);
            this.Controls.Add(this.checkBoxFireplace);
            this.Controls.Add(this.checkBoxBasement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxBasement;
        private System.Windows.Forms.CheckBox checkBoxFireplace;
        private System.Windows.Forms.CheckBox checkBoxPatio;
        private System.Windows.Forms.ComboBox comboBoxBedroom;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxBathroom;
    }
}