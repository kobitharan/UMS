namespace C__UnicomManagementSystem.form
{
    partial class CourseAdd
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
            this.Sname = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Cname = new System.Windows.Forms.TextBox();
            this.CourseName = new System.Windows.Forms.Label();
            this.Selectmodel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(552, 295);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(108, 35);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(529, 150);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(210, 20);
            this.Sname.TabIndex = 1;
            this.Sname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(206, 356);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(384, 150);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(161, 295);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 35);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(340, 295);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 35);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Change_Click);
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(529, 101);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(210, 20);
            this.Cname.TabIndex = 6;
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.Location = new System.Drawing.Point(354, 64);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(138, 24);
            this.CourseName.TabIndex = 7;
            this.CourseName.Text = "Course Name";
            // 
            // Selectmodel
            // 
            this.Selectmodel.FormattingEnabled = true;
            this.Selectmodel.Location = new System.Drawing.Point(80, 101);
            this.Selectmodel.Name = "Selectmodel";
            this.Selectmodel.Size = new System.Drawing.Size(180, 21);
            this.Selectmodel.TabIndex = 8;
            this.Selectmodel.SelectedIndexChanged += new System.EventHandler(this.Selectmodel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select ";
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSize = true;
            this.SubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName.Location = new System.Drawing.Point(351, 145);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(141, 24);
            this.SubjectName.TabIndex = 10;
            this.SubjectName.Text = "Subject Name";
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(529, 74);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(206, 21);
            this.Course.TabIndex = 12;
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 566);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selectmodel);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseAdd";
            this.Text = "CourseAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.ComboBox Selectmodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SubjectName;
        private System.Windows.Forms.ComboBox Course;
    }
}