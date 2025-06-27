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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        public void LoadForm(object formObj)
        {
            if (this.Managerpanel.Controls.Count > 0)
            {
                this.Managerpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Managerpanel.Controls.Add(form);
            this.Managerpanel.Tag = form;
            form.Show();
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            LoadForm(new AddStaff());
        }

        private void NICADDD_Click(object sender, EventArgs e)
        {
            LoadForm(new NICAddForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new GetDataShow());
        }

        private void LecturerAddd_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerDitals());
        }

        private void MailSend_Click(object sender, EventArgs e)
        {
            LoadForm(new Massage());
        }
    }

}
