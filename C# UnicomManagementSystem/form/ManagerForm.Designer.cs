namespace C__UnicomManagementSystem.form
{
    partial class ManagerForm
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
            this.Managerpanel = new System.Windows.Forms.Panel();
            this.Stafff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NICADDD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Managerpanel
            // 
            this.Managerpanel.Location = new System.Drawing.Point(12, 79);
            this.Managerpanel.Name = "Managerpanel";
            this.Managerpanel.Size = new System.Drawing.Size(1006, 584);
            this.Managerpanel.TabIndex = 0;
            // 
            // Stafff
            // 
            this.Stafff.Location = new System.Drawing.Point(39, 12);
            this.Stafff.Name = "Stafff";
            this.Stafff.Size = new System.Drawing.Size(99, 39);
            this.Stafff.TabIndex = 1;
            this.Stafff.Text = "Staff ADD";
            this.Stafff.UseVisualStyleBackColor = true;
            this.Stafff.Click += new System.EventHandler(this.Stafff_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Staff Detals";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Massage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NICADDD
            // 
            this.NICADDD.Location = new System.Drawing.Point(144, 12);
            this.NICADDD.Name = "NICADDD";
            this.NICADDD.Size = new System.Drawing.Size(99, 39);
            this.NICADDD.TabIndex = 4;
            this.NICADDD.Text = "NIC ADD";
            this.NICADDD.UseVisualStyleBackColor = true;
            this.NICADDD.Click += new System.EventHandler(this.NICADDD_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 675);
            this.Controls.Add(this.NICADDD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Stafff);
            this.Controls.Add(this.Managerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Managerpanel;
        private System.Windows.Forms.Button Stafff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NICADDD;
    }
}