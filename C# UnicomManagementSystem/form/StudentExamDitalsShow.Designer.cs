namespace C__UnicomManagementSystem.form
{
    partial class StudentExamDitalsShow
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
            this.StudentExamDitals = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StudentExamDitals
            // 
            this.StudentExamDitals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentExamDitals.Location = new System.Drawing.Point(42, 103);
            this.StudentExamDitals.Name = "StudentExamDitals";
            this.StudentExamDitals.Size = new System.Drawing.Size(928, 343);
            this.StudentExamDitals.TabIndex = 0;
            this.StudentExamDitals.Text = "";
            // 
            // StudentExamDitalsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.StudentExamDitals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentExamDitalsShow";
            this.Text = "StudentExamDitalsShow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentExamDitals;
    }
}