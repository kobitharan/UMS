using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class AddStaff : Form
    {
        StaffAddContoller _StaffAddContoller;
        AddController _AddController;
        public AddStaff()
        {
            _AddController = new AddController();
            _StaffAddContoller = new StaffAddContoller();
            InitializeComponent();
            StaffSelectGV();
        }
        private void StaffSelectGV()
        {

            var Data = _StaffAddContoller.GetAllADDTable("Staff"); // make sure this returns List<Batch>
            StaffGV.DataSource = Data;
            StaffGV.ClearSelection();
            // ClearInputs();
            //  BatchdataGridView();

            StaffGV.Columns["StaffId"].Visible = false;
            StaffGV.Columns["AddId"].Visible = false;
            StaffGV.Columns["Role"].Visible = false;
            // selectedId = -1;
        }
        private void ClearForm()
        {

            SName.Clear();
            NIC.Clear();
            Address.Clear();
            CountactNo.Clear();
            UserName.Clear();
            password.Clear();
            Specialization.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StaffGV_SelectionChanged(object sender, EventArgs e)
        {
            //StaffGV
            if (StaffGV.SelectedRows.Count > 0)
            {
                // value = StaffGV.SelectedRows[0].Cells["AddId"].Value;
                int AddId = Convert.ToInt32(StaffGV.SelectedRows[0].Cells["AddId"].Value);
                SName.Text = StaffGV.SelectedRows[0].Cells["Name"].Value.ToString();
                NIC.Text = StaffGV.SelectedRows[0].Cells["NIC"].Value.ToString();
                Address.Text = StaffGV.SelectedRows[0].Cells["Address"].Value.ToString();
                CountactNo.Text = StaffGV.SelectedRows[0].Cells["ContactNO"].Value.ToString();
                UserName.Text = StaffGV.SelectedRows[0].Cells["UserName"].Value.ToString();
                password.Text = StaffGV.SelectedRows[0].Cells["Password"].Value.ToString();
                Specialization.Text = StaffGV.SelectedRows[0].Cells["Specialization"].Value.ToString();

                // object subjectValue = StaffGV.SelectedRows[0].Cells["SubjectId"].Value;

                // int AdddId = Convert.ToInt32(subjectValue);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaffGV.SelectedRows.Count > 0)
            {
                Staff staff = new Staff()
                {
                    AddId = Convert.ToInt32(StaffGV.SelectedRows[0].Cells["AddId"].Value),
                    Name = SName.Text,
                    NIC = NIC.Text,
                    Address = Address.Text,
                    ContactNO = CountactNo.Text,
                    UserName = UserName.Text,
                    Password = password.Text,
                    Specialization = Specialization.Text,
                    Role = "Staff"
                };

                _AddController.AddDital(staff);                        // Add staff details
                _StaffAddContoller.DeleteAddtable(staff.AddId);
                ClearForm();// Delete old temporary record
            }
            else
            {
                //Staff staff = new Staff()
                //{
                //    Name = SName.Text,
                //    NIC = NIC.Text,
                //    Address = Address.Text,
                //    ContactNO = CountactNo.Text,
                //    UserName = UserName.Text,
                //    Password = password.Text,
                //    Specialization = Specialization.Text,
                //    Role = "Staff"
                //};
                // 1. Check for empty fields
                if (string.IsNullOrWhiteSpace(SName.Text) ||
                    string.IsNullOrWhiteSpace(NIC.Text) ||
                    string.IsNullOrWhiteSpace(Address.Text) ||
                    string.IsNullOrWhiteSpace(CountactNo.Text) ||
                    string.IsNullOrWhiteSpace(UserName.Text) ||
                    string.IsNullOrWhiteSpace(password.Text) ||
                    string.IsNullOrWhiteSpace(Specialization.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. NIC Format Validation (example for Sri Lanka: 9 digits + V)
                if (!System.Text.RegularExpressions.Regex.IsMatch(NIC.Text, @"^(\d{9}[vVxX]|\d{12})$"))
                {
                    MessageBox.Show("Invalid NIC format. Enter 9 digits with 'V' or 12-digit new format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Contact Number Validation (must be 10 digits)
                if (!System.Text.RegularExpressions.Regex.IsMatch(CountactNo.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Invalid contact number. It must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Password minimum length check
                if (password.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ All validations passed – create staff object
                Staff staff = new Staff()
                {
                    Name = SName.Text.Trim(),
                    NIC = NIC.Text.Trim(),
                    Address = Address.Text.Trim(),
                    ContactNO = CountactNo.Text.Trim(),
                    UserName = UserName.Text.Trim(),
                    Password = password.Text.Trim(),
                    Specialization = Specialization.Text.Trim(),
                    Role = "Staff"
                };

                // ➕ Call your save method or controller here
                // Example: _StaffController.SaveStaff(staff);

                MessageBox.Show("Staff details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _AddController.AddDital(staff); // Just add, no delete here!
            }

            ClearForm();
            StaffSelectGV();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                AddId = Convert.ToInt32(StaffGV.SelectedRows[0].Cells["AddId"].Value),

            };
            _StaffAddContoller.DeleteAddtable(staff.AddId);
            ClearForm();
            StaffSelectGV();

        }
    }
}
