﻿namespace C__UnicomManagementSystem.form
{
    partial class LecturerMenu
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LecturerPanal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EXAMRESULTADD = new System.Windows.Forms.Button();
            this.LecturerPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Lecturer Ditals";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(123, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = " TimeTable";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LecturerPanal
            // 
            this.LecturerPanal.Controls.Add(this.flowLayoutPanel1);
            this.LecturerPanal.Location = new System.Drawing.Point(1, 45);
            this.LecturerPanal.Name = "LecturerPanal";
            this.LecturerPanal.Size = new System.Drawing.Size(1006, 580);
            this.LecturerPanal.TabIndex = 6;
            this.LecturerPanal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Message";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // EXAMRESULTADD
            // 
            this.EXAMRESULTADD.Location = new System.Drawing.Point(229, 8);
            this.EXAMRESULTADD.Name = "EXAMRESULTADD";
            this.EXAMRESULTADD.Size = new System.Drawing.Size(100, 30);
            this.EXAMRESULTADD.TabIndex = 9;
            this.EXAMRESULTADD.Text = "Exam Result ADD";
            this.EXAMRESULTADD.UseVisualStyleBackColor = true;
            this.EXAMRESULTADD.Click += new System.EventHandler(this.EXAMRESULTADD_Click);
            // 
            // LecturerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.EXAMRESULTADD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LecturerPanal);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerMenu";
            this.Text = "LecturerMenu";
            this.LecturerPanal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel LecturerPanal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button EXAMRESULTADD;
    }
}