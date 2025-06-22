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
    public partial class StaffmainMenu : Form
    {
        public StaffmainMenu()
        {
            InitializeComponent();
        }
        public void LoadForm3(object formObj)
        {
            if (this.Staffpanal.Controls.Count > 0)
            {
                this.Staffpanal.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Staffpanal.Controls.Add(form);
            this.Staffpanal.Tag = form;
            form.Show();
        }
        private void STUDENTADD_Click(object sender, EventArgs e)
        {
            LoadForm3(new AddStudentDitals());
        }
    }
}
