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
    public partial class menuStaff : Form
    {
        public menuStaff()
        {
            InitializeComponent();
        }
        public void LoadForm3(object formObj)
        {
            if (this.Staffpanel.Controls.Count > 0)
            {
                this.Staffpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Staffpanel.Controls.Add(form);
            this.Staffpanel.Tag = form;
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm3(new AddStudentDitals()); 
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            // LecturerDitals
            LoadForm3(new LecturerDitals());
        }

        private void NICADDD_Click(object sender, EventArgs e)
        {
            LoadForm3(new NICAddForm());
        }

        private void ClassroomAdd_Click(object sender, EventArgs e)
        {
            LoadForm3(new RoomADD());
        }

        private void ExamResultADD_Click(object sender, EventArgs e)
        {
            LoadForm3(new ExamResultADD());
        }

        private void menuStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
