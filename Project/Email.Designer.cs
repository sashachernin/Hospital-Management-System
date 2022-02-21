namespace Project
{
    partial class Email
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
            this.SendingBox = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtBody = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtRecipent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendingBox
            // 
            this.SendingBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SendingBox.Controls.Add(this.btnSend);
            this.SendingBox.Controls.Add(this.rtxtBody);
            this.SendingBox.Controls.Add(this.txtSubject);
            this.SendingBox.Controls.Add(this.txtRecipent);
            this.SendingBox.Controls.Add(this.label5);
            this.SendingBox.Controls.Add(this.label4);
            this.SendingBox.Controls.Add(this.label3);
            this.SendingBox.ForeColor = System.Drawing.Color.Black;
            this.SendingBox.Location = new System.Drawing.Point(266, 62);
            this.SendingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendingBox.Name = "SendingBox";
            this.SendingBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendingBox.Size = new System.Drawing.Size(687, 463);
            this.SendingBox.TabIndex = 1;
            this.SendingBox.TabStop = false;
            this.SendingBox.Text = "Send";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(285, 397);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 27);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.send_Click);
            // 
            // rtxtBody
            // 
            this.rtxtBody.Location = new System.Drawing.Point(28, 191);
            this.rtxtBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtBody.Name = "rtxtBody";
            this.rtxtBody.Size = new System.Drawing.Size(628, 170);
            this.rtxtBody.TabIndex = 2;
            this.rtxtBody.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(28, 141);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(264, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // txtRecipent
            // 
            this.txtRecipent.Location = new System.Drawing.Point(28, 85);
            this.txtRecipent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipent.Name = "txtRecipent";
            this.txtRecipent.Size = new System.Drawing.Size(264, 22);
            this.txtRecipent.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipent:";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.SendingBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Email";
            this.Size = new System.Drawing.Size(1194, 586);
            this.SendingBox.ResumeLayout(false);
            this.SendingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SendingBox;
        private System.Windows.Forms.RichTextBox rtxtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtRecipent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}
