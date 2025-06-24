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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class StaffDetails : Form
    {
        private readonly NICADDController _NICADDController;
        private readonly AddController _AddController;
        private string Role; 
       // private string text;
        public StaffDetails(string userRole)
        {
            InitializeComponent();/////////////// this form ADD all staff, admin, lecsurer..........................
            Role = userRole;

            _NICADDController = new NICADDController();
            _AddController =new AddController();
           
        }
        private void ClearForm()
        {
            Fullname.Clear();
             NIC.Clear();
           Address.Clear();
            contactno.Clear();
            Specialization.Clear();
            username.Clear();
          password.Clear();
        }
        
       
        private void StaffDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fullname.Text))
            {
                MessageBox.Show("Please Enter FullName.");
                return;
            }
            string nic = NIC.Text.Trim();
            if (string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter NIC.");
                return;
            }
            if (nic.Length != 10 && nic.Length != 12)
            {
                MessageBox.Show("NIC must be 10 or 12 characters long.");
                return;
            }
            if (!long.TryParse(nic, out _))
            {
                MessageBox.Show("NIC must contain only numbers.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Address.Text))
            {
                MessageBox.Show("Please Enter Address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(contactno.Text))
            {
                MessageBox.Show("Please Enter Contact No.");
                return;
            }

            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Please Enter Username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please Enter Password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Specialization.Text))
            {
                MessageBox.Show("Please Enter Specialization.");
                return;
            }

            // If all fields are valid, create Staff object
            Staff staff = new Staff()
            {
                Name = Fullname.Text,
                NIC = NIC.Text,
                Address = Address.Text,
                ContactNO = contactno.Text,
                UserName = username.Text,
                Password = password.Text,
                Specialization = Specialization.Text,
                Role = Convert.ToString(Role)
                // CourseId = Convert.ToInt32(Course.SelectedValue),
                // BatchId = Convert.ToInt32(batch.SelectedValue),
            };

            List<NICdata> NICno = _NICADDController.GetNICCheck(staff.NIC);
            if (NICno.Count == 0)
            {
                MessageBox.Show($"You Role90909809809808. Is not Correct.");

                _AddController.TemrariAdd(staff);
               
            }

            else
            {
                bool roleMatched = NICno.Any(n => n.Role == staff.Role);


                MessageBox.Show(" Your Select THis Course.");

                //_AddController.AddDital(staff);
               
                if (roleMatched)
                {
                    MessageBox.Show("You  selected this course.");
                    _AddController.AddDital(staff);
                    ClearForm();
                }
                else
                {
                    // if needed
                    MessageBox.Show($"You Role{staff.Role}. Is not Correct.");

                }
            }
            ClearForm();

        }
    }
}
