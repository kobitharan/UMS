namespace C__UnicomManagementSystem.form
{
    partial class TimeTableViewStudent
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
            this.StuTimeTableShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StuTimeTableShow
            // 
            this.StuTimeTableShow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StuTimeTableShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuTimeTableShow.Location = new System.Drawing.Point(12, 120);
            this.StuTimeTableShow.Name = "StuTimeTableShow";
            this.StuTimeTableShow.Size = new System.Drawing.Size(988, 292);
            this.StuTimeTableShow.TabIndex = 0;
            this.StuTimeTableShow.Text = "";
            // 
            // TimeTableViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.StuTimeTableShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTableViewStudent";
            this.Text = "TimeTableViewStudent";
            this.Load += new System.EventHandler(this.TimeTableViewStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox StuTimeTableShow;
    }
}