using C__UnicomManagementSystem.Controllers;
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

namespace C__UnicomManagementSystem.form
{
    public partial class managersAddForm : Form
    {
        AddController _AddController;
        StaffAddContoller _StaffAddContoller;
        public managersAddForm()
        {
            InitializeComponent();
            _AddController = new AddController();
            _StaffAddContoller = new StaffAddContoller();
            menagerSelectGV();
        }

        private void SaveDitalsLecturer_Click(object sender, EventArgs e)
        {
            if (ManagerdataGridView.SelectedRows.Count > 0)
            {
                Staff staff = new Staff()
                {
                    AddId = Convert.ToInt32(ManagerdataGridView.SelectedRows[0].Cells["AddId"].Value),
                    Name = Name.Text,
                    NIC = NIC.Text,
                    Address = Address.Text,
                    ContactNO = CountactNo.Text,
                    UserName = userName.Text,
                    Password = Password.Text,
                    Specialization = Specialization.Text,
                    Role = "Manager"
                };

                _AddController.AddDital(staff);                        // Add staff details
                _StaffAddContoller.DeleteAddtable(staff.AddId);        // Delete old temporary record
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Name.Text) ||
                    string.IsNullOrWhiteSpace(NIC.Text) ||
                    string.IsNullOrWhiteSpace(Address.Text) ||
                    string.IsNullOrWhiteSpace(CountactNo.Text) ||
                    string.IsNullOrWhiteSpace(userName.Text) ||
                    string.IsNullOrWhiteSpace(Password.Text) ||
                    string.IsNullOrWhiteSpace(Specialization.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optional: NIC format check (example for Sri Lankan NIC: 9 digits + V)
                if (!System.Text.RegularExpressions.Regex.IsMatch(NIC.Text, @"^(\d{9}[vVxX]|\d{12})$"))
                {
                    MessageBox.Show("Invalid NIC format. Enter 9 digits with 'V' or 12-digit new format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optional: Contact Number format (must be digits and 10 characters)
                if (!System.Text.RegularExpressions.Regex.IsMatch(CountactNo.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Invalid contact number. Must be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optional: Password length check
                if (Password.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If everything is valid, create Staff object
                Staff staff = new Staff()
                {
                    Name = Name.Text.Trim(),
                    NIC = NIC.Text.Trim(),
                    Address = Address.Text.Trim(),
                    ContactNO = CountactNo.Text.Trim(),
                    UserName = userName.Text.Trim(),
                    Password = Password.Text.Trim(),
                    Specialization = Specialization.Text.Trim(),
                    Role = "Manager"
                };


                _AddController.AddDital(staff); // Just add, no delete here!
            }

            ClearForm();
            menagerSelectGV();
        }
        private void ClearForm()
        {

            Name.Clear();
            NIC.Clear();
            Address.Clear();
            CountactNo.Clear();
            userName.Clear();
            Password.Clear();
            Specialization.Clear();
        }
        private void menagerSelectGV()
        {

            var Data = _StaffAddContoller.GetAllADDTable("Manager"); // make sure this returns List<Batch>
            ManagerdataGridView.DataSource = Data;
            ManagerdataGridView.ClearSelection();
            // ClearInputs();
            //  BatchdataGridView();

            ManagerdataGridView.Columns["StaffId"].Visible = false;
            ManagerdataGridView.Columns["AddId"].Visible = false;
            ManagerdataGridView.Columns["Role"].Visible = false;
            // selectedId = -1;
        }

        private void ManagerdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ManagerdataGridView.SelectedRows.Count > 0)
            {
                // value = StaffGV.SelectedRows[0].Cells["AddId"].Value;
                int AddId = Convert.ToInt32(ManagerdataGridView.SelectedRows[0].Cells["AddId"].Value);
                Name.Text = ManagerdataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                NIC.Text = ManagerdataGridView.SelectedRows[0].Cells["NIC"].Value.ToString();
                Address.Text = ManagerdataGridView.SelectedRows[0].Cells["Address"].Value.ToString();
                CountactNo.Text = ManagerdataGridView.SelectedRows[0].Cells["ContactNO"].Value.ToString();
                userName.Text = ManagerdataGridView.SelectedRows[0].Cells["UserName"].Value.ToString();
                Password.Text = ManagerdataGridView.SelectedRows[0].Cells["Password"].Value.ToString();
                Specialization.Text = ManagerdataGridView.SelectedRows[0].Cells["Specialization"].Value.ToString();
            }
        }

        private void DeletelecturerDitals_Click(object sender, EventArgs e)
        {
           
            if (ManagerdataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(ManagerdataGridView.SelectedRows[0].Cells["AddId"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _StaffAddContoller.DeleteAddtable(id); // 💡 Call your method here
                    menagerSelectGV(); // Refresh grid
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
