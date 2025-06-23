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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;

namespace C__UnicomManagementSystem.form
{
    public partial class UsersAdd : Form
    {
        public UsersAdd()
        {
            InitializeComponent();
            List<string> items = new List<string>() { "Student", "Lecturer", "Staff", "Manager", "Admin" };
           // RoleComboBox.Items.AddRange(items.ToArray());
            RoleComboBox.DataSource = items;
            LoadForm(new StudentAdd(RoleComboBox.Text));

        }
        public void LoadForm(object formObj)
        {
            if (this.Mainpanel.Controls.Count > 0)
            {
                this.Mainpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(form);
            this.Mainpanel.Tag = form;
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleComboBox.Text == "Student")
            {
                LoadForm(new StudentAdd(RoleComboBox.Text));
                
                return;
            }
            else
            {

                LoadForm(new StaffDetails(RoleComboBox.Text));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {}

        private void Back_Click(object sender, EventArgs e)
        {
           // Form1 loginform = new Form1();
           // loginform.Show();
           this.Close();
           
            
        }
    }
}
