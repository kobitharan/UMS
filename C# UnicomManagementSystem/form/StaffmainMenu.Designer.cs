namespace C__UnicomManagementSystem.form
{
    partial class StaffmainMenu
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
            this.Staffpanal = new System.Windows.Forms.Panel();
            this.STUDENTADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LECTURERADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Staffpanal
            // 
            this.Staffpanal.Location = new System.Drawing.Point(12, 46);
            this.Staffpanal.Name = "Staffpanal";
            this.Staffpanal.Size = new System.Drawing.Size(1012, 582);
            this.Staffpanal.TabIndex = 0;
            // 
            // STUDENTADD
            // 
            this.STUDENTADD.Location = new System.Drawing.Point(57, 13);
            this.STUDENTADD.Name = "STUDENTADD";
            this.STUDENTADD.Size = new System.Drawing.Size(101, 23);
            this.STUDENTADD.TabIndex = 1;
            this.STUDENTADD.Text = "Student ADD";
            this.STUDENTADD.UseVisualStyleBackColor = true;
            this.STUDENTADD.Click += new System.EventHandler(this.STUDENTADD_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LECTURERADD
            // 
            this.LECTURERADD.Location = new System.Drawing.Point(180, 13);
            this.LECTURERADD.Name = "LECTURERADD";
            this.LECTURERADD.Size = new System.Drawing.Size(91, 23);
            this.LECTURERADD.TabIndex = 3;
            this.LECTURERADD.Text = "Lecturer ADD";
            this.LECTURERADD.UseVisualStyleBackColor = true;
            // 
            // StaffmainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.LECTURERADD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.STUDENTADD);
            this.Controls.Add(this.Staffpanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffmainMenu";
            this.Text = "StaffmainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Staffpanal;
        private System.Windows.Forms.Button STUDENTADD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LECTURERADD;
    }
}