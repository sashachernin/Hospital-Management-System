namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctors = new Project.Doctors();
            this.Patients = new Project.Patients();
            this.Email = new Project.Email();
            this.Rooms = new Project.Rooms();
            this.Medicine = new Project.Medicine();
            this.Planner = new Project.Stats();
            this.main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.btnMedicine);
            this.panel1.Controls.Add(this.btnStats);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 572);
            this.panel1.TabIndex = 0;
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(8, 40);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(141, 68);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "  Patients";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAbout.Image = global::Project.Properties.Resources.icons8_about_30;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(8, 452);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(141, 68);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = " About us";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SidePanel.Location = new System.Drawing.Point(0, 40);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 68);
            this.SidePanel.TabIndex = 1;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.Location = new System.Drawing.Point(8, 380);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(141, 68);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "  Email";
            this.btnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.Location = new System.Drawing.Point(8, 312);
            this.btnMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(141, 68);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "   Medicine";
            this.btnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_click);
            // 
            // btnStats
            // 
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStats.Image = ((System.Drawing.Image)(resources.GetObject("btnStats.Image")));
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(8, 244);
            this.btnStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(141, 68);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Stats";
            this.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_click);
            // 
            // btnRooms
            // 
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(8, 176);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(141, 68);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "  Rooms";
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.Location = new System.Drawing.Point(8, 108);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(141, 68);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "  Doctors";
            this.btnDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_click);
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelAbout.Controls.Add(this.label8);
            this.panelAbout.Controls.Add(this.label6);
            this.panelAbout.Controls.Add(this.label5);
            this.panelAbout.Controls.Add(this.label4);
            this.panelAbout.Controls.Add(this.label3);
            this.panelAbout.Controls.Add(this.label2);
            this.panelAbout.Controls.Add(this.label1);
            this.panelAbout.Location = new System.Drawing.Point(377, 89);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(2);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(761, 445);
            this.panelAbout.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(724, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.closeAbout_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(291, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Led by Dan Aharoni.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(296, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = ">>Shelly Revivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(294, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = ">>Tomer Revivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(81, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "as part of the \"Introduction to Systems Programming\" course.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(252, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "This project is made by : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(291, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ">>Sasha Chrenin";
            // 
            // Doctors
            // 
            this.Doctors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Doctors.Location = new System.Drawing.Point(152, 51);
            this.Doctors.Margin = new System.Windows.Forms.Padding(4);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(1211, 586);
            this.Doctors.TabIndex = 7;
            // 
            // Patients
            // 
            this.Patients.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Patients.Location = new System.Drawing.Point(152, 51);
            this.Patients.Margin = new System.Windows.Forms.Padding(2);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(1211, 586);
            this.Patients.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Email.Location = new System.Drawing.Point(152, 51);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(1211, 586);
            this.Email.TabIndex = 1;
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rooms.Location = new System.Drawing.Point(152, 51);
            this.Rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(1211, 586);
            this.Rooms.TabIndex = 1;
            // 
            // Medicine
            // 
            this.Medicine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Medicine.Location = new System.Drawing.Point(152, 51);
            this.Medicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(1211, 586);
            this.Medicine.TabIndex = 1;
            // 
            // Planner
            // 
            this.Planner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Planner.Location = new System.Drawing.Point(152, 51);
            this.Planner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Planner.Name = "Planner";
            this.Planner.Size = new System.Drawing.Size(1211, 586);
            this.Planner.TabIndex = 1;
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.SystemColors.Control;
            this.main_label.Location = new System.Drawing.Point(4, 25);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(165, 24);
            this.main_label.TabIndex = 9;
            this.main_label.Text = "Psychiatric Ward";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1362, 623);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.Planner);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1362, 623);
            this.MinimumSize = new System.Drawing.Size(1362, 623);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnDoctor;
        private Doctors Doctors;
        private Rooms Rooms;
        private Email Email;
        private Stats Planner;
        private Medicine Medicine;
        private Patients Patients;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label main_label;
    }
}

