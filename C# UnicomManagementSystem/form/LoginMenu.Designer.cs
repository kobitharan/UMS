namespace C__UnicomManagementSystem.form
{
    partial class LoginMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.USName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Lecturer = new System.Windows.Forms.Button();
            this.managerAdd = new System.Windows.Forms.Button();
            this.CourseSubjectADD = new System.Windows.Forms.Button();
            this.BatchADD = new System.Windows.Forms.Button();
            this.ClassroomAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TimeTable = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            this.Exam = new System.Windows.Forms.Button();
            this.datapanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.USName);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.Lecturer);
            this.panel2.Controls.Add(this.managerAdd);
            this.panel2.Controls.Add(this.CourseSubjectADD);
            this.panel2.Controls.Add(this.BatchADD);
            this.panel2.Controls.Add(this.ClassroomAdd);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TimeTable);
            this.panel2.Controls.Add(this.Staff);
            this.panel2.Controls.Add(this.Manager);
            this.panel2.Controls.Add(this.Exam);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 675);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // USName
            // 
            this.USName.AutoSize = true;
            this.USName.Location = new System.Drawing.Point(54, 85);
            this.USName.Name = "USName";
            this.USName.Size = new System.Drawing.Size(0, 13);
            this.USName.TabIndex = 28;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 26;
            // 
            // Lecturer
            // 
            this.Lecturer.Location = new System.Drawing.Point(7, 230);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(127, 23);
            this.Lecturer.TabIndex = 25;
            this.Lecturer.Text = "Lecturer";
            this.Lecturer.UseVisualStyleBackColor = true;
            this.Lecturer.Click += new System.EventHandler(this.Lecturer_Click);
            // 
            // managerAdd
            // 
            this.managerAdd.Location = new System.Drawing.Point(7, 462);
            this.managerAdd.Name = "managerAdd";
            this.managerAdd.Size = new System.Drawing.Size(127, 23);
            this.managerAdd.TabIndex = 24;
            this.managerAdd.Text = "Manager ADD";
            this.managerAdd.UseVisualStyleBackColor = true;
            this.managerAdd.Click += new System.EventHandler(this.managerAdd_Click);
            // 
            // CourseSubjectADD
            // 
            this.CourseSubjectADD.Location = new System.Drawing.Point(7, 346);
            this.CourseSubjectADD.Name = "CourseSubjectADD";
            this.CourseSubjectADD.Size = new System.Drawing.Size(127, 23);
            this.CourseSubjectADD.TabIndex = 21;
            this.CourseSubjectADD.Text = "Course/Subject";
            this.CourseSubjectADD.UseVisualStyleBackColor = true;
            this.CourseSubjectADD.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // BatchADD
            // 
            this.BatchADD.Location = new System.Drawing.Point(9, 317);
            this.BatchADD.Name = "BatchADD";
            this.BatchADD.Size = new System.Drawing.Size(127, 23);
            this.BatchADD.TabIndex = 20;
            this.BatchADD.Text = "Batch Add";
            this.BatchADD.UseVisualStyleBackColor = true;
            this.BatchADD.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // ClassroomAdd
            // 
            this.ClassroomAdd.Location = new System.Drawing.Point(7, 375);
            this.ClassroomAdd.Name = "ClassroomAdd";
            this.ClassroomAdd.Size = new System.Drawing.Size(127, 23);
            this.ClassroomAdd.TabIndex = 19;
            this.ClassroomAdd.Text = "Class Room";
            this.ClassroomAdd.UseVisualStyleBackColor = true;
            this.ClassroomAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TimeTable
            // 
            this.TimeTable.Location = new System.Drawing.Point(9, 288);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Size = new System.Drawing.Size(127, 23);
            this.TimeTable.TabIndex = 15;
            this.TimeTable.Text = "Creat TimeTable";
            this.TimeTable.UseVisualStyleBackColor = true;
            this.TimeTable.Click += new System.EventHandler(this.button9_Click);
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(7, 404);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(127, 23);
            this.Staff.TabIndex = 12;
            this.Staff.Text = "Staff ";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.button13_Click);
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(7, 433);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(127, 23);
            this.Manager.TabIndex = 6;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Exam
            // 
            this.Exam.Location = new System.Drawing.Point(9, 259);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(127, 23);
            this.Exam.TabIndex = 4;
            this.Exam.Text = "Exam";
            this.Exam.UseVisualStyleBackColor = true;
            this.Exam.Click += new System.EventHandler(this.button5_Click);
            // 
            // datapanel
            // 
            this.datapanel.Location = new System.Drawing.Point(149, 4);
            this.datapanel.Name = "datapanel";
            this.datapanel.Size = new System.Drawing.Size(1036, 675);
            this.datapanel.TabIndex = 1;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.datapanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel datapanel;
        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button Exam;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button TimeTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CourseSubjectADD;
        private System.Windows.Forms.Button BatchADD;
        private System.Windows.Forms.Button ClassroomAdd;
        private System.Windows.Forms.Button managerAdd;
        private System.Windows.Forms.Button Lecturer;
        private System.Windows.Forms.Label USName;
        private System.Windows.Forms.Label DateShow;
    }
}