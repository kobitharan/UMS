namespace C__UnicomManagementSystem.form
{
    partial class RoomADD
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
            this.ADD = new System.Windows.Forms.Button();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.dataShow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(405, 293);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(109, 83);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(124, 217);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(227, 20);
            this.RoomName.TabIndex = 1;
            // 
            // dataShow
            // 
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(601, 82);
            this.dataShow.Name = "dataShow";
            this.dataShow.Size = new System.Drawing.Size(240, 184);
            this.dataShow.TabIndex = 2;
            this.dataShow.SelectionChanged += new System.EventHandler(this.dataShow_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Class Room Name";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(253, 293);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(127, 83);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Update_Click);
            // 
            // RoomADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomADD";
            this.Text = "RoomADD";
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.DataGridView dataShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
    }
}