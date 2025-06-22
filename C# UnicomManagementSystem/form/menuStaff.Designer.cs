namespace C__UnicomManagementSystem.form
{
    partial class menuStaff
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
            this.Staffpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LECturer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Staffpanel
            // 
            this.Staffpanel.Location = new System.Drawing.Point(-5, 46);
            this.Staffpanel.Name = "Staffpanel";
            this.Staffpanel.Size = new System.Drawing.Size(1012, 582);
            this.Staffpanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LECturer
            // 
            this.LECturer.Location = new System.Drawing.Point(187, 17);
            this.LECturer.Name = "LECturer";
            this.LECturer.Size = new System.Drawing.Size(91, 23);
            this.LECturer.TabIndex = 2;
            this.LECturer.Text = "Lecturer ADD";
            this.LECturer.UseVisualStyleBackColor = true;
            this.LECturer.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LECturer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Staffpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuStaff";
            this.Text = "menuStaff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Staffpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LECturer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}