namespace C__UnicomManagementSystem.form
{
    partial class AddStudentDitals
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
            this.components = new System.ComponentModel.Container();
            this.StudentDitalsShow = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.TextBox();
            this.ContactNO = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.batch = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDitalsShow)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDitalsShow
            // 
            this.StudentDitalsShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDitalsShow.Location = new System.Drawing.Point(89, 46);
            this.StudentDitalsShow.Name = "StudentDitalsShow";
            this.StudentDitalsShow.Size = new System.Drawing.Size(702, 179);
            this.StudentDitalsShow.TabIndex = 0;
            this.StudentDitalsShow.SelectionChanged += new System.EventHandler(this.StudentDitalsShow_SelectionChanged);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(89, 301);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(178, 20);
            this.FullName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(668, 472);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Select Student";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(517, 301);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(178, 20);
            this.Username.TabIndex = 8;
            // 
            // NIC
            // 
            this.NIC.Location = new System.Drawing.Point(71, 431);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(178, 20);
            this.NIC.TabIndex = 9;
            // 
            // ContactNO
            // 
            this.ContactNO.Location = new System.Drawing.Point(71, 385);
            this.ContactNO.Name = "ContactNO";
            this.ContactNO.Size = new System.Drawing.Size(178, 20);
            this.ContactNO.TabIndex = 10;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(71, 347);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(178, 20);
            this.Address.TabIndex = 11;
            this.Address.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ContactNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "BatchName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "CourseName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "UserName :";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(517, 344);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(178, 20);
            this.Password.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password : ";
            // 
            // batch
            // 
            this.batch.FormattingEnabled = true;
            this.batch.Location = new System.Drawing.Point(517, 385);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(178, 21);
            this.batch.TabIndex = 22;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(517, 423);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(178, 21);
            this.Course.TabIndex = 23;
            // 
            // AddStudentDitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 580);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ContactNO);
            this.Controls.Add(this.NIC);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.StudentDitalsShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentDitals";
            this.Text = "AddStudentDitals";
            this.Load += new System.EventHandler(this.AddStudentDitals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDitalsShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDitalsShow;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox NIC;
        private System.Windows.Forms.TextBox ContactNO;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox batch;
        private System.Windows.Forms.ComboBox Course;
    }
}