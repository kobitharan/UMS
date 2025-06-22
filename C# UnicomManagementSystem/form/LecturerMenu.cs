using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__UnicomManagementSystem.form
{
    public partial class LecturerMenu : Form
    {
        public LecturerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void LLoadForm(object formObj)
        {
            if (this.LecturerPanal.Controls.Count > 0)
            {
                this.LecturerPanal.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.LecturerPanal.Controls.Add(form);
            this.LecturerPanal.Tag = form;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LLoadForm(new LecturerClassTimeTable());
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // LLoadForm(new ());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
