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

       // ----------------  //  LoginInfo.Username = "";
    //  --------------    //  MessageBox.Show(LoginInfo.Username);
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
                if (string.IsNullOrWhiteSpace(NICtextbox.Text) || (NICtextbox.Text).Length >= 14 || (NICtextbox.Text).Length <= 9)
                {
                    MessageBox.Show("Please Enter NIC NO Eg - 200507900830 .");
                    return;
                }
                NICdata NICdata = new NICdata()
                {
                    NIC = (NICtextbox.Text),
                    Role = RoleComboBox.Text,
                };
               
               // MessageBox.Show("Please Enter NIC NO Eg ");
                string getMessage = _NICADDController.AddNIC(NICdata);
                MessageBox.Show(getMessage);
                NICdGV();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting course: " + ex.Message);
                // Or log it
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
                
                NICtextbox.Text = NICdataGridView.SelectedRows[0].Cells["NIC"].Value.ToString();
                RoleComboBox.Text = NICdataGridView.SelectedRows[0].Cells["Role"].Value.ToString();
                
                NICtextbox.Text = NICdataGridView.SelectedRows[0].Cells["NIC"].Value.ToString();
                NICtextbox.Text = NICdataGridView.SelectedRows[0].Cells["NIC"].Value.ToString();
                RoleComboBox.Text = NICdataGridView.SelectedRows[0].Cells["Specialization"].Value.ToString();
                
            }
        }

        private void NICAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}