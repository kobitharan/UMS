namespace C__UnicomManagementSystem.form
{
    partial class TimetableMenu
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.BatchCB = new System.Windows.Forms.ComboBox();
            this.Room = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.dataGridViewTimeTable = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ETime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lecturer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(43, 404);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 0;
            // 
            // BatchCB
            // 
            this.BatchCB.FormattingEnabled = true;
            this.BatchCB.Location = new System.Drawing.Point(271, 403);
            this.BatchCB.Name = "BatchCB";
            this.BatchCB.Size = new System.Drawing.Size(173, 21);
            this.BatchCB.TabIndex = 1;
            // 
            // Room
            // 
            this.Room.FormattingEnabled = true;
            this.Room.Location = new System.Drawing.Point(708, 407);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(174, 21);
            this.Room.TabIndex = 2;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(482, 403);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(187, 21);
            this.Course.TabIndex = 3;
            this.Course.SelectedIndexChanged += new System.EventHandler(this.Course_SelectedIndexChanged);
            // 
            // dataGridViewTimeTable
            // 
            this.dataGridViewTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeTable.Location = new System.Drawing.Point(174, 60);
            this.dataGridViewTimeTable.Name = "dataGridViewTimeTable";
            this.dataGridViewTimeTable.Size = new System.Drawing.Size(666, 193);
            this.dataGridViewTimeTable.TabIndex = 4;
            this.dataGridViewTimeTable.SelectionChanged += new System.EventHandler(this.dataGridViewTimeTable_SelectionChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(823, 565);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(130, 48);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subject
            // 
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(482, 489);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(187, 21);
            this.Subject.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Student  group ";
            // 
            // STime
            // 
            this.STime.Location = new System.Drawing.Point(43, 466);
            this.STime.Name = "STime";
            this.STime.Size = new System.Drawing.Size(200, 20);
            this.STime.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Room";
            // 
            // ETime
            // 
            this.ETime.Location = new System.Drawing.Point(43, 527);
            this.ETime.Name = "ETime";
            this.ETime.Size = new System.Drawing.Size(200, 20);
            this.ETime.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Select Date";
            // 
            // Lecturer
            // 
            this.Lecturer.FormattingEnabled = true;
            this.Lecturer.Location = new System.Drawing.Point(271, 491);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(173, 21);
            this.Lecturer.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lecturer Name";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(643, 565);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 48);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TimetableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 675);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lecturer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ETime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.STime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridViewTimeTable);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.BatchCB);
            this.Controls.Add(this.Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimetableMenu";
            this.Text = "TimetableMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox BatchCB;
        private System.Windows.Forms.ComboBox Room;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.DataGridView dataGridViewTimeTable;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker STime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ETime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Lecturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}