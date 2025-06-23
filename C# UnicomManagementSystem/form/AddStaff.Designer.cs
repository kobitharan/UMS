namespace C__UnicomManagementSystem.form
{
    partial class AddStaff
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
            this.StaffGV = new System.Windows.Forms.DataGridView();
            this.NIC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.CountactNo = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Specialization = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffGV
            // 
            this.StaffGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGV.Location = new System.Drawing.Point(77, 23);
            this.StaffGV.Name = "StaffGV";
            this.StaffGV.Size = new System.Drawing.Size(769, 177);
            this.StaffGV.TabIndex = 0;
            this.StaffGV.SelectionChanged += new System.EventHandler(this.StaffGV_SelectionChanged);
            // 
            // NIC
            // 
            this.NIC.Location = new System.Drawing.Point(122, 318);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(229, 20);
            this.NIC.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(471, 320);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 20);
            this.password.TabIndex = 4;
            // 
            // CountactNo
            // 
            this.CountactNo.Location = new System.Drawing.Point(122, 411);
            this.CountactNo.Name = "CountactNo";
            this.CountactNo.Size = new System.Drawing.Size(229, 20);
            this.CountactNo.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(122, 366);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(229, 20);
            this.Address.TabIndex = 7;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(471, 266);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(223, 20);
            this.UserName.TabIndex = 8;
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(122, 270);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(229, 20);
            this.SName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ContactNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Specialization";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "UserName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Specialization
            // 
            this.Specialization.Location = new System.Drawing.Point(469, 363);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(319, 96);
            this.Specialization.TabIndex = 17;
            this.Specialization.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Staff Menual add and Request add";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Request add ... Select dataViewBox And Edite ";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 675);
            this.Controls.Add(this.StaffGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CountactNo);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NIC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            ((System.ComponentModel.ISupportInitialize)(this.StaffGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffGV;
        private System.Windows.Forms.TextBox NIC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox CountactNo;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Specialization;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}