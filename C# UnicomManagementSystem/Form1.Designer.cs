﻿namespace C__UnicomManagementSystem
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CreatAccount = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.DateTimeditals = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(446, 140);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(296, 29);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(446, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(296, 29);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // CreatAccount
            // 
            this.CreatAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatAccount.Location = new System.Drawing.Point(446, 269);
            this.CreatAccount.Name = "CreatAccount";
            this.CreatAccount.Size = new System.Drawing.Size(155, 43);
            this.CreatAccount.TabIndex = 2;
            this.CreatAccount.Text = "Creat New Account";
            this.CreatAccount.UseVisualStyleBackColor = true;
            this.CreatAccount.Click += new System.EventHandler(this.CreatAccount_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(597, 269);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(145, 43);
            this.Login.TabIndex = 4;
            this.Login.Text = " Login ";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namelabel.Location = new System.Drawing.Point(443, 121);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(121, 16);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Enter UserName";
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordlabel.Location = new System.Drawing.Point(445, 194);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(119, 16);
            this.passwordlabel.TabIndex = 6;
            this.passwordlabel.Text = "Enter Password ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.DateTimeditals);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.CreatAccount);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.passwordlabel);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 682);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1093, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(79, 40);
            this.exit.TabIndex = 7;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exti_Click);
            // 
            // DateTimeditals
            // 
            this.DateTimeditals.AutoSize = true;
            this.DateTimeditals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeditals.Location = new System.Drawing.Point(129, 53);
            this.DateTimeditals.Name = "DateTimeditals";
            this.DateTimeditals.Size = new System.Drawing.Size(0, 20);
            this.DateTimeditals.TabIndex = 8;
            this.DateTimeditals.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button CreatAccount;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label DateTimeditals;
    }
}

