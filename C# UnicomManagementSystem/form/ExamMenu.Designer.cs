namespace C__UnicomManagementSystem.form
{
    partial class ExamMenu
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
            this.ECourse = new System.Windows.Forms.ComboBox();
            this.Examdata = new System.Windows.Forms.DataGridView();
            this.EADD = new System.Windows.Forms.Button();
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.STime = new System.Windows.Forms.DateTimePicker();
            this.ESubject = new System.Windows.Forms.ComboBox();
            this.ETime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EDelete = new System.Windows.Forms.Button();
            this.ERoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EBatch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ditals = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Examdata)).BeginInit();
            this.SuspendLayout();
            // 
            // ECourse
            // 
            this.ECourse.FormattingEnabled = true;
            this.ECourse.Location = new System.Drawing.Point(77, 91);
            this.ECourse.Name = "ECourse";
            this.ECourse.Size = new System.Drawing.Size(151, 21);
            this.ECourse.TabIndex = 0;
            // 
            // Examdata
            // 
            this.Examdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Examdata.Location = new System.Drawing.Point(245, 80);
            this.Examdata.Name = "Examdata";
            this.Examdata.Size = new System.Drawing.Size(751, 233);
            this.Examdata.TabIndex = 1;
            this.Examdata.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // EADD
            // 
            this.EADD.Location = new System.Drawing.Point(819, 523);
            this.EADD.Name = "EADD";
            this.EADD.Size = new System.Drawing.Size(109, 53);
            this.EADD.TabIndex = 2;
            this.EADD.Text = "Save";
            this.EADD.UseVisualStyleBackColor = true;
            this.EADD.Click += new System.EventHandler(this.EADD_Click);
            // 
            // EDate
            // 
            this.EDate.Location = new System.Drawing.Point(192, 440);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(174, 20);
            this.EDate.TabIndex = 3;
            // 
            // STime
            // 
            this.STime.Location = new System.Drawing.Point(403, 440);
            this.STime.Name = "STime";
            this.STime.Size = new System.Drawing.Size(167, 20);
            this.STime.TabIndex = 4;
            // 
            // ESubject
            // 
            this.ESubject.FormattingEnabled = true;
            this.ESubject.Location = new System.Drawing.Point(77, 146);
            this.ESubject.Name = "ESubject";
            this.ESubject.Size = new System.Drawing.Size(151, 21);
            this.ESubject.TabIndex = 5;
            // 
            // ETime
            // 
            this.ETime.Location = new System.Drawing.Point(635, 440);
            this.ETime.Name = "ETime";
            this.ETime.Size = new System.Drawing.Size(183, 20);
            this.ETime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject";
            // 
            // EDelete
            // 
            this.EDelete.Location = new System.Drawing.Point(635, 523);
            this.EDelete.Name = "EDelete";
            this.EDelete.Size = new System.Drawing.Size(114, 53);
            this.EDelete.TabIndex = 11;
            this.EDelete.Text = "Delete";
            this.EDelete.UseVisualStyleBackColor = true;
            this.EDelete.Click += new System.EventHandler(this.EDelete_Click);
            // 
            // ERoom
            // 
            this.ERoom.FormattingEnabled = true;
            this.ERoom.Location = new System.Drawing.Point(77, 194);
            this.ERoom.Name = "ERoom";
            this.ERoom.Size = new System.Drawing.Size(151, 21);
            this.ERoom.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Class Room";
            // 
            // EBatch
            // 
            this.EBatch.FormattingEnabled = true;
            this.EBatch.Location = new System.Drawing.Point(77, 241);
            this.EBatch.Name = "EBatch";
            this.EBatch.Size = new System.Drawing.Size(151, 21);
            this.EBatch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Batch";
            // 
            // Ditals
            // 
            this.Ditals.Location = new System.Drawing.Point(77, 299);
            this.Ditals.Name = "Ditals";
            this.Ditals.Size = new System.Drawing.Size(151, 80);
            this.Ditals.TabIndex = 16;
            this.Ditals.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Exam Ditals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Exam Add Menu";
            // 
            // ExamMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ditals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EBatch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ERoom);
            this.Controls.Add(this.EDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ETime);
            this.Controls.Add(this.ESubject);
            this.Controls.Add(this.STime);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.EADD);
            this.Controls.Add(this.Examdata);
            this.Controls.Add(this.ECourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamMenu";
            this.Text = "ExamMenu";
            this.Load += new System.EventHandler(this.ExamMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Examdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ECourse;
        private System.Windows.Forms.DataGridView Examdata;
        private System.Windows.Forms.Button EADD;
        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.DateTimePicker STime;
        private System.Windows.Forms.ComboBox ESubject;
        private System.Windows.Forms.DateTimePicker ETime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EDelete;
        private System.Windows.Forms.ComboBox ERoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Ditals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}