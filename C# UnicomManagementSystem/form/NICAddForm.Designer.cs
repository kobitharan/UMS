namespace C__UnicomManagementSystem.form
{
    partial class NICAddForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NICtextbox = new System.Windows.Forms.TextBox();
            this.NICdataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NICdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(172, 281);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 55);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD NIC NO";
            // 
            // NICtextbox
            // 
            this.NICtextbox.Location = new System.Drawing.Point(185, 184);
            this.NICtextbox.Name = "NICtextbox";
            this.NICtextbox.Size = new System.Drawing.Size(233, 20);
            this.NICtextbox.TabIndex = 2;
            // 
            // NICdataGridView
            // 
            this.NICdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NICdataGridView.Location = new System.Drawing.Point(603, 61);
            this.NICdataGridView.Name = "NICdataGridView";
            this.NICdataGridView.Size = new System.Drawing.Size(285, 275);
            this.NICdataGridView.TabIndex = 3;
            this.NICdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NICdataGridView_CellContentClick);
            this.NICdataGridView.SelectionChanged += new System.EventHandler(this.NICdataGridView_SelectionChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(352, 281);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 55);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(195, 83);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(241, 21);
            this.RoleComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Role";
            // 
            // NICAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NICdataGridView);
            this.Controls.Add(this.NICtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NICAddForm";
            this.Text = "NICAddForm";
            this.Load += new System.EventHandler(this.NICAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NICdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NICtextbox;
        private System.Windows.Forms.DataGridView NICdataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label2;
    }
}