namespace C__UnicomManagementSystem.form
{
    partial class Batch
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
            this.button1 = new System.Windows.Forms.Button();
            this.BatchdataGRV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchYear = new System.Windows.Forms.TextBox();
            this.Enddate = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Courses = new System.Windows.Forms.ComboBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BatchdataGRV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD Ditals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BatchdataGRV
            // 
            this.BatchdataGRV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BatchdataGRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BatchdataGRV.Location = new System.Drawing.Point(480, 87);
            this.BatchdataGRV.Name = "BatchdataGRV";
            this.BatchdataGRV.Size = new System.Drawing.Size(470, 176);
            this.BatchdataGRV.TabIndex = 1;
            this.BatchdataGRV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BatchdataGRV_CellContentClick);
            this.BatchdataGRV.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.BatchdataGridView_CellStateChanged);
            this.BatchdataGRV.SelectionChanged += new System.EventHandler(this.BatchdataGRV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Grup Name";
            // 
            // BatchYear
            // 
            this.BatchYear.Location = new System.Drawing.Point(117, 87);
            this.BatchYear.Name = "BatchYear";
            this.BatchYear.Size = new System.Drawing.Size(192, 20);
            this.BatchYear.TabIndex = 3;
            // 
            // Enddate
            // 
            this.Enddate.Location = new System.Drawing.Point(117, 231);
            this.Enddate.Name = "Enddate";
            this.Enddate.Size = new System.Drawing.Size(192, 20);
            this.Enddate.TabIndex = 4;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(117, 163);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(192, 20);
            this.StartDate.TabIndex = 5;
            // 
            // ADD
            // 
            this.ADD.AutoSize = true;
            this.ADD.Location = new System.Drawing.Point(31, 163);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(52, 13);
            this.ADD.TabIndex = 6;
            this.ADD.Text = "StartDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "EndDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Course";
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(117, 287);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(192, 21);
            this.Courses.TabIndex = 10;
            this.Courses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(117, 383);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(117, 48);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 566);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Enddate);
            this.Controls.Add(this.BatchYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BatchdataGRV);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Batch";
            this.Text = "Batch";
            this.Load += new System.EventHandler(this.Batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BatchdataGRV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView BatchdataGRV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BatchYear;
        private System.Windows.Forms.TextBox Enddate;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.Label ADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Courses;
        private System.Windows.Forms.Button Deletebutton;
    }
}