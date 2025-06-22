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
    public partial class Massage : Form
    {
        public Massage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Name = data.Text;
            MessageBox.Show(Name);
        }

        private void Massage_Load(object sender, EventArgs e)
        {

        }
    }
}
