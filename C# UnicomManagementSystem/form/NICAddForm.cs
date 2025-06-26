using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
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
    public partial class NICAddForm : Form
    {
        NICADDController _NICADDController;
        public NICAddForm()
        {
            _NICADDController = new NICADDController();

            InitializeComponent();
            List<string> items = new List<string>() { "Student", "Staff", "Lecturer" };
            RoleComboBox.DataSource = items;

            NICdGV();

     
        }

        private void NICdGV()
        {
            NICdata NIC = new NICdata();
            List<NICdata> NICAdd = _NICADDController.GetAllNIC();
            NICdataGridView.DataSource = NICAdd;
            NICdataGridView.ClearSelection();

        }

        private void button2_Click(object sender, EventArgs e)
        {//RoleComboBox  NICtextbox

            try
            {
                string nic = NICtextbox.Text.Trim();

                // Check if NIC is empty or not 10 or 12 digits
                if (string.IsNullOrWhiteSpace(nic) || (nic.Length != 10 && nic.Length != 12))
                {
                    MessageBox.Show("Please enter a valid NIC number. Eg: 200507900830 or 200507900V");
                    return;
                }

               

                NICdata NICdat = new NICdata()
                {
                    NIC = nic,
                    Role = RoleComboBox.Text,
                };

                string getMessage = _NICADDController.AddNIC(NICdat);
                MessageBox.Show(getMessage);

                NICdGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //DeleteButton
            if (string.IsNullOrWhiteSpace(NICtextbox.Text))
            {
                MessageBox.Show("Please Select Delete NIC .");
                return;
            }
            if (NICdataGridView.SelectedRows.Count > 0)
            {
                int NICid = Convert.ToInt32(NICdataGridView.SelectedRows[0].Cells["NICId"].Value);
                _NICADDController.NICDelete(NICid);
                MessageBox.Show("NIC Delete Successfully!");

            }
            NICdGV();

        }

        private void NICdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void NICdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (NICdataGridView.SelectedRows.Count > 0)
            {
                NICtextbox.Text = NICdataGridView.SelectedRows[0].Cells["NIC"].Value.ToString();
                RoleComboBox.Text = NICdataGridView.SelectedRows[0].Cells["Role"].Value.ToString();
                
              
            }
        }

        private void NICAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}