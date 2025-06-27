using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.Controllers.EmailSend;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class StudentAdd : Form

    {
        private readonly EmailController _emailController;
        private readonly StudentController _studentController;
        private readonly CourseController _CourseController;
        private readonly NICADDController _NICADDController; 
        private readonly LoginController _LoginController;
        public StudentAdd(string role)
        {
            InitializeComponent();
            _studentController = new StudentController();
            _CourseController = new CourseController();
            _NICADDController = new NICADDController();
            _LoginController = new LoginController();

            _emailController = new EmailController();

            CMBLoadCourse();
            CMBLoadbatch();
            CMBLoadStubject();
            CMBLoadbatch();
        }
        private void ClearForm()
        {
            Sname.Clear();
            StudentNIC.Clear();
            StudentAddress.Clear();
            StudentContactNO.Clear();
            StudentUserName.Clear();
            StudentPassword.Clear();
            OTPMAIL.Clear();
           
            
        }
      
        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            Course.DataSource = sections;
            Course.DisplayMember = "CourseName";
            Course.ValueMember = "CourseId";

        }
        private void CMBLoadbatch()
        {
            var sections = _CourseController.GetAllBatch();
            batch.DataSource = sections;
            batch.DisplayMember = "BatchName";
            batch.ValueMember = "BatchId";

        }
        private void CMBLoadStubject()
        {
            var sections = _CourseController.GetAllBatch();
            batch.DataSource = sections;
            batch.DisplayMember = "BatchName";
            batch.ValueMember = "BatchId";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentInputs())
            {
                return;
            }
        
    
            Student student = new Student
            {
                StudentFullName = Sname.Text,
                StudentNIC = StudentNIC.Text,
                Address = StudentAddress.Text,
                ContactNO = StudentContactNO.Text,
                UserName = StudentUserName.Text,
                Password = StudentPassword.Text,
                CourseId = Convert.ToInt32(Course.SelectedValue),
                BatchId = Convert.ToInt32(batch.SelectedValue),
            };

            // Check if NIC already exists in NIC_Table
           var nicList = _NICADDController.GetNICCheck(student.StudentNIC);

            // Check if username already exists in Students_Table or AddStudent_Table
            bool isUsernameExists = _LoginController.IsUserNameExists(student.UserName);

            if (isUsernameExists)
            {
                MessageBox.Show("This username is already taken. Please choose a different one.");
                return;
            }

            if (nicList == null)
            {
                // NIC not found → add to temporary table
                _studentController.TemrariAddStudent(student);  // Temp holding
                MessageBox.Show("Student added temporarily (NIC not registered). ");
                ClearForm();
                return;
            }
         //   If NIC is found → allow final registration
               var nic = nicList; 

            if (nic.Role != student.Role)
            {
                MessageBox.Show($"NIC role mismatch! NIC role: '{nic.Role}', Your role: '{student.Role}'.");
                return;
            }

            _studentController.AddStudent(student);
            _studentController.DeleteNICById(nic.NICId);
            MessageBox.Show("Student added successfully.");
            ClearForm();
        }


        private bool ValidateStudentInputs()
        {
            if (string.IsNullOrWhiteSpace(Sname.Text))
            {
                MessageBox.Show("Please enter Student Name.");
                Sname.Focus();
                return false;
            }

            //if (string.IsNullOrWhiteSpace(StudentNIC.Text))
            //{
            //    MessageBox.Show("Please enter Student NIC.");
            //    StudentNIC.Focus();
            //    return false;
            //}
            if (!System.Text.RegularExpressions.Regex.IsMatch(StudentNIC.Text, @"^(\d{9}[vVxX]|\d{12})$"))
            {
                MessageBox.Show("Invalid NIC format. Enter 9 digits with 'V' or 12-digit new format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(StudentAddress.Text))
            {
                MessageBox.Show("Please enter Address.");
                StudentAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(StudentContactNO.Text))
            {
                MessageBox.Show("Please enter Contact No.");
                StudentContactNO.Focus();
                return false;
            }

            //if (string.IsNullOrWhiteSpace(StudentUserName.Text))
            //{
            //    MessageBox.Show("Please enter Username.");
            //    StudentUserName.Focus();
            //    return false;
            //}
            int enteredOTP;
            if (!int.TryParse(OTPMAIL.Text, out enteredOTP))
            {
                MessageBox.Show("Please enter a valid numeric OTP.");
                return false;
            }

            int storedOTP = Convert.ToInt32(LoginDitals.Get("randomNumber"));


            if (enteredOTP != storedOTP)
            {
                MessageBox.Show($"Incorrect OTP. Please try again.{storedOTP}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(StudentPassword.Text))
            {
                MessageBox.Show("Please enter Password.");
                StudentPassword.Focus();
                return false;
            }

            if (Course.SelectedValue == null)
            {
                MessageBox.Show("Please select a Course.");
                Course.Focus();
                return false;
            }

            if (batch.SelectedValue == null)
            {
                MessageBox.Show("Please select a Batch.");
                batch.Focus();
                return false;
            }

            return true;
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SENTOTP_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDitals.Clear();
                Random random = new Random();
                int randomNumber = random.Next(100000, 999999); // 6-digit OTP
                LoginDitals.Set("randomNumber", randomNumber);
                // MessageBox.Show($"{ randomNumber}");

                string to = StudentUserName.Text;  //"kobitharankobitharan@gmail.com";
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
