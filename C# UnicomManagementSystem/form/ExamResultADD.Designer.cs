namespace C__UnicomManagementSystem.form
{
    partial class ExamResultADD
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
            this.CourseCB = new System.Windows.Forms.ComboBox();
            this.StudentCB = new System.Windows.Forms.ComboBox();
            this.ExamCB = new System.Windows.Forms.ComboBox();
            this.BatchCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RankTB = new System.Windows.Forms.TextBox();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.AddResutltBtn = new System.Windows.Forms.Button();
            this.MarkTB = new System.Windows.Forms.TextBox();
            this.SubjectCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseCB
            // 
            this.CourseCB.FormattingEnabled = true;
            this.CourseCB.Location = new System.Drawing.Point(113, 143);
            this.CourseCB.Name = "CourseCB";
            this.CourseCB.Size = new System.Drawing.Size(196, 21);
            this.CourseCB.TabIndex = 0;
            this.CourseCB.SelectedIndexChanged += new System.EventHandler(this.CourseCB_SelectedIndexChanged);
            // 
            // StudentCB
            // 
            this.StudentCB.FormattingEnabled = true;
            this.StudentCB.Location = new System.Drawing.Point(113, 326);
            this.StudentCB.Name = "StudentCB";
            this.StudentCB.Size = new System.Drawing.Size(196, 21);
            this.StudentCB.TabIndex = 4;
            // 
            // ExamCB
            // 
            this.ExamCB.FormattingEnabled = true;
            this.ExamCB.Location = new System.Drawing.Point(113, 278);
            this.ExamCB.Name = "ExamCB";
            this.ExamCB.Size = new System.Drawing.Size(196, 21);
            this.ExamCB.TabIndex = 5;
            // 
            // BatchCB
            // 
            this.BatchCB.FormattingEnabled = true;
            this.BatchCB.Location = new System.Drawing.Point(113, 76);
            this.BatchCB.Name = "BatchCB";
            this.BatchCB.Size = new System.Drawing.Size(196, 21);
            this.BatchCB.TabIndex = 6;
            this.BatchCB.SelectedIndexChanged += new System.EventHandler(this.BatchCB_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exam  Mark ADD...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rank";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(33, 329);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(49, 13);
            this.Student.TabIndex = 12;
            this.Student.Text = "Students";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Exam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Batch";
            // 
            // RankTB
            // 
            this.RankTB.Location = new System.Drawing.Point(113, 364);
            this.RankTB.Name = "RankTB";
            this.RankTB.Size = new System.Drawing.Size(196, 20);
            this.RankTB.TabIndex = 15;
            // 
            // ResultGrid
            // 
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(397, 58);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.Size = new System.Drawing.Size(531, 312);
            this.ResultGrid.TabIndex = 19;
            // 
            // AddResutltBtn
            // 
            this.AddResutltBtn.Location = new System.Drawing.Point(764, 474);
            this.AddResutltBtn.Name = "AddResutltBtn";
            this.AddResutltBtn.Size = new System.Drawing.Size(124, 75);
            this.AddResutltBtn.TabIndex = 21;
            this.AddResutltBtn.Text = "ADD";
            this.AddResutltBtn.UseVisualStyleBackColor = true;
            this.AddResutltBtn.Click += new System.EventHandler(this.AddResutltBtn_Click);
            // 
            // MarkTB
            // 
            this.MarkTB.Location = new System.Drawing.Point(113, 408);
            this.MarkTB.Name = "MarkTB";
            this.MarkTB.Size = new System.Drawing.Size(196, 20);
            this.MarkTB.TabIndex = 23;
            // 
            // SubjectCB
            // 
            this.SubjectCB.FormattingEnabled = true;
            this.SubjectCB.Location = new System.Drawing.Point(113, 207);
            this.SubjectCB.Name = "SubjectCB";
            this.SubjectCB.Size = new System.Drawing.Size(196, 21);
            this.SubjectCB.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Subject";
            // 
            // ExamResultADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubjectCB);
            this.Controls.Add(this.MarkTB);
            this.Controls.Add(this.AddResutltBtn);
            this.Controls.Add(this.ResultGrid);
            this.Controls.Add(this.RankTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BatchCB);
            this.Controls.Add(this.ExamCB);
            this.Controls.Add(this.StudentCB);
            this.Controls.Add(this.CourseCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamResultADD";
            this.Text = "ExamResultADD";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseCB;
        private System.Windows.Forms.ComboBox StudentCB;
        private System.Windows.Forms.ComboBox ExamCB;
        private System.Windows.Forms.ComboBox BatchCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RankTB;
        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.Button AddResutltBtn;
        private System.Windows.Forms.TextBox MarkTB;
        private System.Windows.Forms.ComboBox SubjectCB;
        private System.Windows.Forms.Label label4;
    }
}