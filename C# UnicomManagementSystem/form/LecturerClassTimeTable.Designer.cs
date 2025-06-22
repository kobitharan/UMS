namespace C__UnicomManagementSystem.form
{
    partial class LecturerClassTimeTable
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
            this.LecturerShowTimeTable = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LecturerShowTimeTable
            // 
            this.LecturerShowTimeTable.Location = new System.Drawing.Point(12, 68);
            this.LecturerShowTimeTable.Name = "LecturerShowTimeTable";
            this.LecturerShowTimeTable.Size = new System.Drawing.Size(968, 458);
            this.LecturerShowTimeTable.TabIndex = 0;
            this.LecturerShowTimeTable.Text = "";
            // 
            // LecturerClassTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.LecturerShowTimeTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerClassTimeTable";
            this.Text = "LecturerClassTimeTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LecturerShowTimeTable;
    }
}