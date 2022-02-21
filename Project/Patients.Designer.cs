namespace Project
{
    partial class Patients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.new_patient = new System.Windows.Forms.Panel();
            this.checkInDateBox = new System.Windows.Forms.DateTimePicker();
            this.diagnosis_box = new System.Windows.Forms.ComboBox();
            this.emptyfields_label = new System.Windows.Forms.Label();
            this.cmbBedNumber = new System.Windows.Forms.ComboBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.Cmb_Gender = new System.Windows.Forms.ComboBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.editBtn_patient = new System.Windows.Forms.Button();
            this.removeBtn_patient = new System.Windows.Forms.Button();
            this.newBtn_patient = new System.Windows.Forms.Button();
            this.patientGrid = new System.Windows.Forms.DataGridView();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.reCheckBtn = new System.Windows.Forms.Button();
            this.new_patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // new_patient
            // 
            this.new_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.new_patient.Controls.Add(this.checkInDateBox);
            this.new_patient.Controls.Add(this.diagnosis_box);
            this.new_patient.Controls.Add(this.emptyfields_label);
            this.new_patient.Controls.Add(this.cmbBedNumber);
            this.new_patient.Controls.Add(this.cmbRoomNumber);
            this.new_patient.Controls.Add(this.Cmb_Gender);
            this.new_patient.Controls.Add(this.Cancel_button);
            this.new_patient.Controls.Add(this.ok_button);
            this.new_patient.Controls.Add(this.label2);
            this.new_patient.Controls.Add(this.label4);
            this.new_patient.Controls.Add(this.label7);
            this.new_patient.Controls.Add(this.label3);
            this.new_patient.Controls.Add(this.label10);
            this.new_patient.Controls.Add(this.label9);
            this.new_patient.Controls.Add(this.label6);
            this.new_patient.Controls.Add(this.lblLastName);
            this.new_patient.Controls.Add(this.label5);
            this.new_patient.Controls.Add(this.label1);
            this.new_patient.Controls.Add(this.email_box);
            this.new_patient.Controls.Add(this.id_box);
            this.new_patient.Controls.Add(this.lastname_box);
            this.new_patient.Controls.Add(this.phone_box);
            this.new_patient.Controls.Add(this.name_box);
            this.new_patient.Location = new System.Drawing.Point(131, 115);
            this.new_patient.Margin = new System.Windows.Forms.Padding(2);
            this.new_patient.Name = "new_patient";
            this.new_patient.Size = new System.Drawing.Size(1000, 320);
            this.new_patient.TabIndex = 21;
            // 
            // checkInDateBox
            // 
            this.checkInDateBox.CalendarTitleBackColor = System.Drawing.SystemColors.WindowFrame;
            this.checkInDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkInDateBox.Location = new System.Drawing.Point(749, 91);
            this.checkInDateBox.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.checkInDateBox.Name = "checkInDateBox";
            this.checkInDateBox.Size = new System.Drawing.Size(104, 22);
            this.checkInDateBox.TabIndex = 9;
            // 
            // diagnosis_box
            // 
            this.diagnosis_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagnosis_box.FormattingEnabled = true;
            this.diagnosis_box.Items.AddRange(new object[] {
            "Bipolar",
            "Mania",
            "Depression",
            "Phobia",
            "Panic",
            "PTSD",
            "Anorexia",
            "Narcolepsy"});
            this.diagnosis_box.Location = new System.Drawing.Point(749, 48);
            this.diagnosis_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagnosis_box.Name = "diagnosis_box";
            this.diagnosis_box.Size = new System.Drawing.Size(108, 24);
            this.diagnosis_box.TabIndex = 8;
            // 
            // emptyfields_label
            // 
            this.emptyfields_label.AutoSize = true;
            this.emptyfields_label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.emptyfields_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyfields_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyfields_label.ForeColor = System.Drawing.Color.Red;
            this.emptyfields_label.Location = new System.Drawing.Point(14, 13);
            this.emptyfields_label.Name = "emptyfields_label";
            this.emptyfields_label.Size = new System.Drawing.Size(176, 18);
            this.emptyfields_label.TabIndex = 28;
            this.emptyfields_label.Text = "Some fields are empty";
            // 
            // cmbBedNumber
            // 
            this.cmbBedNumber.FormattingEnabled = true;
            this.cmbBedNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbBedNumber.Location = new System.Drawing.Point(522, 193);
            this.cmbBedNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBedNumber.Name = "cmbBedNumber";
            this.cmbBedNumber.Size = new System.Drawing.Size(104, 24);
            this.cmbBedNumber.TabIndex = 7;
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbRoomNumber.Location = new System.Drawing.Point(522, 146);
            this.cmbRoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(104, 24);
            this.cmbRoomNumber.TabIndex = 6;
            // 
            // Cmb_Gender
            // 
            this.Cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Gender.FormattingEnabled = true;
            this.Cmb_Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Cmb_Gender.Location = new System.Drawing.Point(258, 146);
            this.Cmb_Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Gender.Name = "Cmb_Gender";
            this.Cmb_Gender.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Gender.TabIndex = 2;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(519, 263);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(71, 31);
            this.Cancel_button.TabIndex = 11;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(411, 263);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(72, 31);
            this.ok_button.TabIndex = 10;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(406, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bed number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(406, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(406, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Room number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(650, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Diagnosis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(652, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Check In Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(152, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(152, 102);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(406, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(522, 52);
            this.email_box.Margin = new System.Windows.Forms.Padding(2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(104, 22);
            this.email_box.TabIndex = 4;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(258, 195);
            this.id_box.Margin = new System.Windows.Forms.Padding(2);
            this.id_box.MaxLength = 9;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 3;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // lastname_box
            // 
            this.lastname_box.Location = new System.Drawing.Point(258, 99);
            this.lastname_box.Margin = new System.Windows.Forms.Padding(2);
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(100, 22);
            this.lastname_box.TabIndex = 1;
            this.lastname_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_box_KeyPress);
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(522, 97);
            this.phone_box.Margin = new System.Windows.Forms.Padding(2);
            this.phone_box.MaxLength = 10;
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(104, 22);
            this.phone_box.TabIndex = 5;
            this.phone_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_box_KeyPress);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(258, 52);
            this.name_box.Margin = new System.Windows.Forms.Padding(2);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 22);
            this.name_box.TabIndex = 0;
            this.name_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_box_KeyPress);
            // 
            // editBtn_patient
            // 
            this.editBtn_patient.AutoSize = true;
            this.editBtn_patient.Location = new System.Drawing.Point(551, 503);
            this.editBtn_patient.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn_patient.Name = "editBtn_patient";
            this.editBtn_patient.Size = new System.Drawing.Size(75, 29);
            this.editBtn_patient.TabIndex = 24;
            this.editBtn_patient.Text = "Edit";
            this.editBtn_patient.UseVisualStyleBackColor = true;
            this.editBtn_patient.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn_patient
            // 
            this.removeBtn_patient.AutoSize = true;
            this.removeBtn_patient.Location = new System.Drawing.Point(433, 503);
            this.removeBtn_patient.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn_patient.Name = "removeBtn_patient";
            this.removeBtn_patient.Size = new System.Drawing.Size(75, 29);
            this.removeBtn_patient.TabIndex = 23;
            this.removeBtn_patient.Text = "Remove";
            this.removeBtn_patient.UseVisualStyleBackColor = true;
            this.removeBtn_patient.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // newBtn_patient
            // 
            this.newBtn_patient.AutoSize = true;
            this.newBtn_patient.Location = new System.Drawing.Point(315, 503);
            this.newBtn_patient.Margin = new System.Windows.Forms.Padding(2);
            this.newBtn_patient.Name = "newBtn_patient";
            this.newBtn_patient.Size = new System.Drawing.Size(75, 29);
            this.newBtn_patient.TabIndex = 0;
            this.newBtn_patient.Text = "New";
            this.newBtn_patient.UseVisualStyleBackColor = true;
            this.newBtn_patient.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // patientGrid
            // 
            this.patientGrid.AllowUserToAddRows = false;
            this.patientGrid.AllowUserToDeleteRows = false;
            this.patientGrid.AllowUserToResizeRows = false;
            this.patientGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGrid.Location = new System.Drawing.Point(3, 85);
            this.patientGrid.MultiSelect = false;
            this.patientGrid.Name = "patientGrid";
            this.patientGrid.ReadOnly = true;
            this.patientGrid.RowHeadersVisible = false;
            this.patientGrid.RowHeadersWidth = 51;
            this.patientGrid.RowTemplate.Height = 24;
            this.patientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientGrid.ShowCellErrors = false;
            this.patientGrid.ShowCellToolTips = false;
            this.patientGrid.ShowEditingIcon = false;
            this.patientGrid.ShowRowErrors = false;
            this.patientGrid.Size = new System.Drawing.Size(1204, 378);
            this.patientGrid.TabIndex = 27;
            this.patientGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.patientGrid_RowStateChanged);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.AutoSize = true;
            this.checkOutBtn.Location = new System.Drawing.Point(669, 503);
            this.checkOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(84, 29);
            this.checkOutBtn.TabIndex = 24;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // reCheckBtn
            // 
            this.reCheckBtn.AutoSize = true;
            this.reCheckBtn.Location = new System.Drawing.Point(796, 503);
            this.reCheckBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reCheckBtn.Name = "reCheckBtn";
            this.reCheckBtn.Size = new System.Drawing.Size(84, 29);
            this.reCheckBtn.TabIndex = 24;
            this.reCheckBtn.Text = "Re-Check";
            this.reCheckBtn.UseVisualStyleBackColor = true;
            this.reCheckBtn.Click += new System.EventHandler(this.reCheckBtn_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.new_patient);
            this.Controls.Add(this.patientGrid);
            this.Controls.Add(this.reCheckBtn);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.editBtn_patient);
            this.Controls.Add(this.removeBtn_patient);
            this.Controls.Add(this.newBtn_patient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patients";
            this.Size = new System.Drawing.Size(1194, 586);
            this.Load += new System.EventHandler(this.Patients_Load);
            this.new_patient.ResumeLayout(false);
            this.new_patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel new_patient;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.ComboBox Cmb_Gender;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button editBtn_patient;
        private System.Windows.Forms.Button removeBtn_patient;
        private System.Windows.Forms.Button newBtn_patient;
        private System.Windows.Forms.DataGridView patientGrid;
        private System.Windows.Forms.Label emptyfields_label;
        private System.Windows.Forms.ComboBox cmbBedNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button reCheckBtn;
        private System.Windows.Forms.ComboBox diagnosis_box;
        private System.Windows.Forms.DateTimePicker checkInDateBox;
    }
}
