using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
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
            List<NICdata> nicList = _NICADDController.GetNICCheck(student.StudentNIC);

            // Check if username already exists in Students_Table or AddStudent_Table
            bool isUsernameExists = _LoginController.IsUserNameExists(student.UserName);

            if (isUsernameExists)
            {
                MessageBox.Show("This username is already taken. Please choose a different one.");
                return;
            }

            if (nicList.Count == 0)
            {
                // NIC not found in NIC table: means new student
                _studentController.TemrariAddStudent(student);  // Temp table?
                MessageBox.Show("Student added temporarily.");
                ClearForm();
                return;
            }
            else
            {
                MessageBox.Show("You have already selected this course.");
                _studentController.AddStudent(student);  // Final add
                var nic = nicList[0];
                _studentController.DeleteNICById(nic.NICId);  // Final add

                ClearForm();
            }
        }


        private bool ValidateStudentInputs()
        {
            if (string.IsNullOrWhiteSpace(Sname.Text))
            {
                MessageBox.Show("Please enter Student Name.");
                Sname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(StudentNIC.Text))
            {
                MessageBox.Show("Please enter Student NIC.");
                StudentNIC.Focus();
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

            if (string.IsNullOrWhiteSpace(StudentUserName.Text))
            {
                MessageBox.Show("Please enter Username.");
                StudentUserName.Focus();
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
    }
}
