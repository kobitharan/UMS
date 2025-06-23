namespace C__UnicomManagementSystem.form
{
    partial class LecturerDitalsShowLecturer
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
            this.LecturerDitalsShow = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // LecturerDitalsShow
            // 
            this.LecturerDitalsShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LecturerDitalsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerDitalsShow.Location = new System.Drawing.Point(40, 80);
            this.LecturerDitalsShow.Name = "LecturerDitalsShow";
            this.LecturerDitalsShow.Size = new System.Drawing.Size(883, 352);
            this.LecturerDitalsShow.TabIndex = 0;
            this.LecturerDitalsShow.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LecturerDitalsShowLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.LecturerDitalsShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerDitalsShowLecturer";
            this.Text = "LecturerDitalsShowLecturer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LecturerDitalsShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}