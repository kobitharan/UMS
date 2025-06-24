namespace C__UnicomManagementSystem.form
{
    partial class GetDataShow
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
            this.Change = new System.Windows.Forms.Button();
            this.Usernamess = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersDetals = new System.Windows.Forms.DataGridView();
            this.ActiveORDeactive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDetals)).BeginInit();
            this.SuspendLayout();
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(719, 435);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(123, 48);
            this.Change.TabIndex = 1;
            this.Change.Text = "CHANGE";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Usernamess
            // 
            this.Usernamess.Location = new System.Drawing.Point(59, 328);
            this.Usernamess.Name = "Usernamess";
            this.Usernamess.Size = new System.Drawing.Size(207, 20);
            this.Usernamess.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(346, 328);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(207, 20);
            this.Password.TabIndex = 5;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(56, 301);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 6;
            this.UserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Active/Deactive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Change UserName Password ";
            // 
            // UsersDetals
            // 
            this.UsersDetals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDetals.Location = new System.Drawing.Point(133, 77);
            this.UsersDetals.Name = "UsersDetals";
            this.UsersDetals.Size = new System.Drawing.Size(651, 150);
            this.UsersDetals.TabIndex = 10;
            this.UsersDetals.SelectionChanged += new System.EventHandler(this.UsersDetals_SelectionChanged);
            // 
            // ActiveORDeactive
            // 
            this.ActiveORDeactive.FormattingEnabled = true;
            this.ActiveORDeactive.Location = new System.Drawing.Point(614, 327);
            this.ActiveORDeactive.Name = "ActiveORDeactive";
            this.ActiveORDeactive.Size = new System.Drawing.Size(150, 21);
            this.ActiveORDeactive.TabIndex = 11;
            // 
            // GetDataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 584);
            this.Controls.Add(this.ActiveORDeactive);
            this.Controls.Add(this.UsersDetals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Usernamess);
            this.Controls.Add(this.Change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetDataShow";
            this.Text = "GetDataShow";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDetals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox Usernamess;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView UsersDetals;
        private System.Windows.Forms.ComboBox ActiveORDeactive;
    }
}