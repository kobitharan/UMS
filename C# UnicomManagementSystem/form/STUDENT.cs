using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace C__UnicomManagementSystem.form
{
    public partial class STUDENT : Form
    {
        public STUDENT()
        {
            InitializeComponent();
            LoadForm2(new StudentDitals());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void LoadForm2(object formObj)
        {
            if (this.STpanel.Controls.Count > 0)
            {
                this.STpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.STpanel.Controls.Add(form);
            this.STpanel.Tag = form;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void button3_Click(object sender, EventArgs e)
        { }

        private void button6_Click(object sender, EventArgs e)
        { }

        private void button8_Click(object sender, EventArgs e)
        {    }
 
        private void button5_Click(object sender, EventArgs e)
        {
             LoadForm2(new StudentDitals());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadForm2(new Massage()); 
        }

        private void Massage_Click(object sender, EventArgs e)
        {
            LoadForm2(new Massage());
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Time table 
            LoadForm2(new TimeTableViewStudent());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm2(new StudentExamResult());
        }

        private void Exams_Click(object sender, EventArgs e)
        {
            LoadForm2(new StudentExamResult());

        }
    }
}
