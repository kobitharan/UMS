using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.Controllers.EmailSend;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class StaffDetails : Form
    {
        private readonly NICADDController _NICADDController;
        private readonly AddController _AddController;
        private readonly StudentController _studentController;
        private string Role;
       // private int randomNumber;
        private readonly EmailController _emailController;
        // private string text;
        public StaffDetails(string userRole)
        {
            InitializeComponent();/////////////// this form ADD all staff, admin, lecsurer..........................
            Role = userRole;
            _studentController = new StudentController();
            _NICADDController = new NICADDController();
            _AddController =new AddController();
            _emailController = new EmailController();

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
            OTPMAIL.Clear();
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

            if (!System.Text.RegularExpressions.Regex.IsMatch(nic, @"^(\d{9}[vVxX]|\d{12})$"))
            {
                MessageBox.Show("Invalid NIC format. Enter 9 digits with 'V' or 12-digit new format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            

            if (password.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Specialization.Text))
            {
                MessageBox.Show("Please Enter Specialization.");
                return;
            }
            //if (randomNumber != Convert.ToInt32(OTPMAIL.Text))
            //{
            //    MessageBox.Show("Invalid OTP. Please try again.");
            //    return;
            //}



            /// CHECK OTP MAILLL
            int enteredOTP;
            if (!int.TryParse(OTPMAIL.Text, out enteredOTP))
            {
                MessageBox.Show("Please enter a valid numeric OTP.");
                return;
            }

            int storedOTP = Convert.ToInt32(LoginDitals.Get("randomNumber"));
            

            if (enteredOTP != storedOTP)
            { 
                MessageBox.Show($"Incorrect OTP. Please try again.{storedOTP}");
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

            var nicResult = _NICADDController.GetNICCheck(staff.NIC);
            if (nicResult == null)
            {
                //ADD to temporary table if NIC not found User is new

                _AddController.TemrariAdd(staff);
              
            }

            else
            {
                if (nicResult.Role == staff.Role)
                {
                   // MessageBox.Show("ADD Success.");
                    _AddController.AddDital(staff);
                    _studentController.DeleteNICById(nicResult.NICId); 
                   
                }
                else
                {
                    MessageBox.Show($"Your role '{staff.Role}' does not match NIC role '{nicResult.Role}'.");
                }

            }
            string to = username.Text;  //"kobitharankobitharan@gmail.com";
            string subject = "Welcome to Our System!";
            string message = $"Dear Friend,\n\nThank you for using the Unicom TIC Management System.\nYour account has been successfully created and is now active.\n\nYou can now log in and start accessing the services.\n\nIf you need any assistance, feel free to contact our support team.\n\nRegards,\nUnicom TIC Team";


            string result = _emailController.SendEmail(to, subject, message);
            MessageBox.Show(result);
            ClearForm();
        }

        private void OTPMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDitals.Clear();
                Random random = new Random();
                int randomNumber = random.Next(100000, 999999); // 6-digit OTP
                LoginDitals.Set("randomNumber", randomNumber);
                // MessageBox.Show($"{ randomNumber}");

                string to = username.Text;  //"kobitharankobitharan@gmail.com";
                string subject = "Welcome to Our System!";
                string message = $"Dear Friend,\n\nThank you for registering with us.\nYour One-Time Password (OTP) for verification is: {randomNumber}.\n\nPlease do not share this code with anyone.\n\nRegards,\nSupport Team";

                string result = _emailController.SendEmail(to, subject, message);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid email address before sending.");

            }

        }
    }
}
