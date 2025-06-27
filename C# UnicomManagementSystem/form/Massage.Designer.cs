namespace C__UnicomManagementSystem.form
{
    partial class Massage
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
            this.datagritView = new System.Windows.Forms.RichTextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.StudentMail = new System.Windows.Forms.ComboBox();
            this.StudentName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMessagebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datagritView
            // 
            this.datagritView.Location = new System.Drawing.Point(364, 52);
            this.datagritView.Name = "datagritView";
            this.datagritView.Size = new System.Drawing.Size(617, 274);
            this.datagritView.TabIndex = 1;
            this.datagritView.Text = "";
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(185, 411);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(134, 52);
            this.Clearbutton.TabIndex = 2;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // StudentMail
            // 
            this.StudentMail.FormattingEnabled = true;
            this.StudentMail.Location = new System.Drawing.Point(112, 112);
            this.StudentMail.Name = "StudentMail";
            this.StudentMail.Size = new System.Drawing.Size(207, 21);
            this.StudentMail.TabIndex = 3;
            // 
            // StudentName
            // 
            this.StudentName.FormattingEnabled = true;
            this.StudentName.Location = new System.Drawing.Point(112, 52);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(207, 21);
            this.StudentName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Mail : ";
            // 
            // SendMessagebutton
            // 
            this.SendMessagebutton.Location = new System.Drawing.Point(387, 411);
            this.SendMessagebutton.Name = "SendMessagebutton";
            this.SendMessagebutton.Size = new System.Drawing.Size(134, 52);
            this.SendMessagebutton.TabIndex = 8;
            this.SendMessagebutton.Text = "Send Message";
            this.SendMessagebutton.UseVisualStyleBackColor = true;
            this.SendMessagebutton.Click += new System.EventHandler(this.SendMessagebutton_Click);
            // 
            // Massage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.SendMessagebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentMail);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.datagritView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Massage";
            this.Text = "Massage";
            this.Load += new System.EventHandler(this.Massage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox datagritView;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.ComboBox StudentMail;
        private System.Windows.Forms.ComboBox StudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendMessagebutton;
    }
}