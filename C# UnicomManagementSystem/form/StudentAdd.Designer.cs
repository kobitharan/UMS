namespace C__UnicomManagementSystem.form
{
    partial class StudentAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.StudentPassword = new System.Windows.Forms.TextBox();
            this.StudentUserName = new System.Windows.Forms.TextBox();
            this.StudentContactNO = new System.Windows.Forms.TextBox();
            this.StudentNIC = new System.Windows.Forms.TextBox();
            this.StudentAddress = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.batch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SENTOTP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.OTPMAIL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 48);
            this.button1.TabIndex = 48;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Password";
            // 
            // StudentPassword
            // 
            this.StudentPassword.Location = new System.Drawing.Point(524, 106);
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.Size = new System.Drawing.Size(189, 20);
            this.StudentPassword.TabIndex = 46;
            // 
            // StudentUserName
            // 
            this.StudentUserName.Location = new System.Drawing.Point(524, 50);
            this.StudentUserName.Name = "StudentUserName";
            this.StudentUserName.Size = new System.Drawing.Size(189, 20);
            this.StudentUserName.TabIndex = 45;
            // 
            // StudentContactNO
            // 
            this.StudentContactNO.Location = new System.Drawing.Point(135, 264);
            this.StudentContactNO.Name = "StudentContactNO";
            this.StudentContactNO.Size = new System.Drawing.Size(189, 20);
            this.StudentContactNO.TabIndex = 44;
            // 
            // StudentNIC
            // 
            this.StudentNIC.Location = new System.Drawing.Point(135, 184);
            this.StudentNIC.Name = "StudentNIC";
            this.StudentNIC.Size = new System.Drawing.Size(189, 20);
            this.StudentNIC.TabIndex = 43;
            // 
            // StudentAddress
            // 
            this.StudentAddress.Location = new System.Drawing.Point(135, 117);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(189, 20);
            this.StudentAddress.TabIndex = 42;
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(135, 54);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(189, 20);
            this.Sname.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Enter your Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "ContactNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "FullName";
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(524, 146);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(163, 21);
            this.Course.TabIndex = 49;
            this.Course.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Select Course";
            // 
            // batch
            // 
            this.batch.FormattingEnabled = true;
            this.batch.Location = new System.Drawing.Point(524, 183);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(163, 21);
            this.batch.TabIndex = 51;
            this.batch.SelectedIndexChanged += new System.EventHandler(this.batch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Select Batch";
            // 
            // SENTOTP
            // 
            this.SENTOTP.Location = new System.Drawing.Point(642, 76);
            this.SENTOTP.Name = "SENTOTP";
            this.SENTOTP.Size = new System.Drawing.Size(71, 24);
            this.SENTOTP.TabIndex = 53;
            this.SENTOTP.Text = "SENT OTP";
            this.SENTOTP.UseVisualStyleBackColor = true;
            this.SENTOTP.Click += new System.EventHandler(this.SENTOTP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Enter YourMail OTP";
            // 
            // OTPMAIL
            // 
            this.OTPMAIL.Location = new System.Drawing.Point(543, 229);
            this.OTPMAIL.Name = "OTPMAIL";
            this.OTPMAIL.Size = new System.Drawing.Size(113, 20);
            this.OTPMAIL.TabIndex = 55;
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 338);
            this.Controls.Add(this.OTPMAIL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SENTOTP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StudentPassword);
            this.Controls.Add(this.StudentUserName);
            this.Controls.Add(this.StudentContactNO);
            this.Controls.Add(this.StudentNIC);
            this.Controls.Add(this.StudentAddress);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StudentPassword;
        private System.Windows.Forms.TextBox StudentUserName;
        private System.Windows.Forms.TextBox StudentContactNO;
        private System.Windows.Forms.TextBox StudentNIC;
        private System.Windows.Forms.TextBox StudentAddress;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox batch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SENTOTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OTPMAIL;
    }
}