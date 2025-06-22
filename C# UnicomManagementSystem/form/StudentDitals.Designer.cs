namespace C__UnicomManagementSystem.form
{
    partial class StudentDitals
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
            this.StudentDitalsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StudentDitalsBox
            // 
            this.StudentDitalsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDitalsBox.Location = new System.Drawing.Point(186, 115);
            this.StudentDitalsBox.Name = "StudentDitalsBox";
            this.StudentDitalsBox.Size = new System.Drawing.Size(598, 298);
            this.StudentDitalsBox.TabIndex = 10;
            this.StudentDitalsBox.Text = "";
            // 
            // StudentDitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 580);
            this.Controls.Add(this.StudentDitalsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDitals";
            this.Text = "StudentDitals";
            this.Load += new System.EventHandler(this.StudentDitals_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentDitalsBox;
    }
}