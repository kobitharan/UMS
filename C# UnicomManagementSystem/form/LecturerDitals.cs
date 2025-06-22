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
    public partial class LecturerDitals : Form
    {
        StaffAddContoller _StaffAddContoller;
        AddController _AddController;

        public LecturerDitals()
        {
            _AddController = new AddController();
            _StaffAddContoller = new StaffAddContoller();
            InitializeComponent();
            LecturerSelectGV();
            ClearForm();
        }
        private void LecturerSelectGV()
        {

            var Data = _StaffAddContoller.GetAllADDTable("Lecturer"); // make sure this returns List<Batch>
            Lecturer.DataSource = Data;
            Lecturer.ClearSelection();
           

            Lecturer.Columns["StaffId"].Visible = false;
            Lecturer.Columns["AddId"].Visible = false;
            Lecturer.Columns["Role"].Visible = false;
            
        }
        private void ClearForm()
        {

            
            LName.Clear();
            NIC.Clear();
            Address.Clear();
            CountactNo.Clear();
            UserName.Clear();
            Password.Clear();
            Specialization.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ClearForm();
            if (Lecturer.SelectedRows.Count > 0)
            {
                Staff staff = new Staff()
                {
                    AddId = Convert.ToInt32(Lecturer.SelectedRows[0].Cells["AddId"].Value),
                    Name = LName.Text,
                    NIC = NIC.Text,
                    Address = Address.Text,
                    ContactNO = CountactNo.Text,
                    UserName = UserName.Text,
                    Password = Password.Text,
                    Specialization = Specialization.Text,
                    Role = "Lecturer"
                };

                _AddController.AddDital(staff);                        // Add staff details
                _StaffAddContoller.DeleteAddtable(staff.AddId);        // Delete old temporary record
            }
            else
            {
                //Staff staff = new Staff()
                //{
                //    Name = LName.Text,
                //    NIC = NIC.Text,
                //    Address = Address.Text,
                //    ContactNO = CountactNo.Text,
                //    UserName = UserName.Text,
                //    Password = Password.Text,
                //    Specialization = Specialization.Text,
                //    Role = "Lecturer"
                //};
                if (string.IsNullOrWhiteSpace(LName.Text) ||
                    string.IsNullOrWhiteSpace(NIC.Text) ||
                    string.IsNullOrWhiteSpace(Address.Text) ||
                    string.IsNullOrWhiteSpace(CountactNo.Text) ||
                    string.IsNullOrWhiteSpace(UserName.Text) ||
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
                    Name = LName.Text.Trim(),
                    NIC = NIC.Text.Trim(),
                    Address = Address.Text.Trim(),
                    ContactNO = CountactNo.Text.Trim(),
                    UserName = UserName.Text.Trim(),
                    Password = Password.Text.Trim(),
                    Specialization = Specialization.Text.Trim(),
                    Role = "Lecturer"
                };


                _AddController.AddDital(staff); // Just add, no delete here!
            }

            ClearForm();
            LecturerSelectGV();


        }
    

        private void LecturerDitals_Load(object sender, EventArgs e)
        {

        }

        private void Lecturer_SelectionChanged(object sender, EventArgs e)
        {
            //StaffGV
            if (Lecturer.SelectedRows.Count > 0)
            {
                // value = StaffGV.SelectedRows[0].Cells["AddId"].Value;
                int AddId = Convert.ToInt32(Lecturer.SelectedRows[0].Cells["AddId"].Value);
                LName.Text = Lecturer.SelectedRows[0].Cells["Name"].Value.ToString();
                NIC.Text = Lecturer.SelectedRows[0].Cells["NIC"].Value.ToString();
                Address.Text = Lecturer.SelectedRows[0].Cells["Address"].Value.ToString();
                CountactNo.Text = Lecturer.SelectedRows[0].Cells["ContactNO"].Value.ToString();
                UserName.Text = Lecturer.SelectedRows[0].Cells["UserName"].Value.ToString();
                Password.Text = Lecturer.SelectedRows[0].Cells["Password"].Value.ToString();
                Specialization.Text = Lecturer.SelectedRows[0].Cells["Specialization"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                AddId = Convert.ToInt32(Lecturer.SelectedRows[0].Cells["AddId"].Value),

            };
            _StaffAddContoller.DeleteAddtable(staff.AddId);
            ClearForm();
            LecturerSelectGV();
        }
    }
}
