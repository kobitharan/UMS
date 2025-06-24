using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class AddStudentDitals : Form
    {
        StudentController _StudentController;
        CourseController _CourseController;
        StaffAddContoller _StaffAddContoller;
        public AddStudentDitals()
        {
            _StaffAddContoller  = new StaffAddContoller();
            _CourseController = new CourseController();
             _StudentController = new StudentController();
            InitializeComponent();
            StudentADDTibleDitalsGV();
            CMBLoadCourse();
            CMBLoadbatch();
            ClearForm();
        }
        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            Course.DataSource = sections;
            Course.DisplayMember = "CourseName";
            Course.ValueMember = "CourseId";

        } 
        private void ClearForm()
        {
            FullName.Clear();
                NIC.Clear();
            Address.Clear();
            ContactNO.Clear();
            Username.Clear();
            Password.Clear();
           

        }
        private void CMBLoadbatch()
        {
            var sections = _CourseController.GetAllBatch();
            batch.DataSource = sections;
            batch.DisplayMember = "BatchName";
            batch.ValueMember = "BatchId";

        }
        private void StudentADDTibleDitalsGV()
        {

            var Data = _StudentController.GetAllADDTable(); // make sure this returns List<Batch>
            StudentDitalsShow.DataSource = Data;
            StudentDitalsShow.ClearSelection();
            // ClearInputs();
            //  BatchdataGridView();

            // StudentDitalsShow.Columns["AddId"].Visible = false;
            if (StudentDitalsShow.Columns.Contains("BatchId"))
                StudentDitalsShow.Columns["BatchId"].Visible = false;
            
            if (StudentDitalsShow.Columns.Contains("Role"))
                StudentDitalsShow.Columns["Role"].Visible = false;
            
            if (StudentDitalsShow.Columns.Contains("SubjectName"))
                StudentDitalsShow.Columns["SubjectName"].Visible = false;
            
            if (StudentDitalsShow.Columns.Contains("StudentId"))
                StudentDitalsShow.Columns["StudentId"].Visible = false;
            
            if (StudentDitalsShow.Columns.Contains("SubjectName"))
                StudentDitalsShow.Columns["SubjectName"].Visible = false;

            if (StudentDitalsShow.Columns.Contains("CourseId"))
                StudentDitalsShow.Columns["CourseId"].Visible = false;

            if (StudentDitalsShow.Columns.Contains("AddId"))
                StudentDitalsShow.Columns["AddId"].Visible = false;
            // selectedId = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            //ADD buttun
            if (StudentDitalsShow.SelectedRows.Count > 0)
            {
                // Existing record from temp table - move to permanent
                int addId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["AddId"].Value);
                int batchId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["BatchId"].Value);
                int courseId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["CourseId"].Value);

                Student student = new Student()
                {
                    //AddId = addId,
                    StudentFullName = FullName.Text,
                    StudentNIC = NIC.Text,
                    Address = Address.Text,
                    ContactNO = ContactNO.Text,
                    UserName = Username.Text,
                    Password = Password.Text,
                    BatchId = batchId,
                    CourseId = courseId,
                   // Role = "Student"
                };
                _StudentController.AddStudent(student);// Add to permanent student table
                ClearForm();

                _StudentController.DeleteAddStudenttable(addId);     
                // Delete from temp table
            }
            else
            {
                // Basic Validation
                if (string.IsNullOrWhiteSpace(FullName.Text) ||
                    string.IsNullOrWhiteSpace(NIC.Text) ||
                    string.IsNullOrWhiteSpace(Address.Text) ||
                    string.IsNullOrWhiteSpace(ContactNO.Text) ||
                    string.IsNullOrWhiteSpace(Username.Text) ||
                    string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                // Validate numeric fields
                if (!int.TryParse(batch.SelectedValue?.ToString(), out int batchId))
                {
                    MessageBox.Show("Please select a valid Batch.");
                    return;
                }
                if (!int.TryParse(Course.SelectedValue?.ToString(), out int courseId))
                {
                    MessageBox.Show("Please Enter a valid Course.");
                    return;
                }

                // Optionally validate contact no format or NIC etc.

                // All validations passed – Create Student object
                Student student1 = new Student()
                {
                    StudentFullName = FullName.Text.Trim(),
                    StudentNIC = NIC.Text.Trim(),
                    Address = Address.Text.Trim(),
                    ContactNO = ContactNO.Text.Trim(),
                    UserName = Username.Text.Trim(),
                    Password = Password.Text.Trim(),
                    BatchId = batchId,
                    CourseId = courseId
                };

                _StudentController.AddStudent(student1);
                ClearForm();
            }

            MessageBox.Show("Student saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StudentADDTibleDitalsGV();
            ClearForm();

        }

        private void AddStudentDitals_Load(object sender, EventArgs e)
        {

        }

        private void StudentDitalsShow_SelectionChanged(object sender, EventArgs e)
        {
            if (StudentDitalsShow.SelectedRows.Count > 0)
            {
                int AddId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["AddId"].Value);
                int BatchId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["BatchId"].Value);
                int CourseId = Convert.ToInt32(StudentDitalsShow.SelectedRows[0].Cells["CourseId"].Value);

              //  FullName.Text = StudentDitalsShow.SelectedRows[0].Cells["StudentName"].Value.ToString();

         FullName.Text = StudentDitalsShow.SelectedRows[0].Cells["StudentFullName"].Value.ToString();
                NIC.Text = StudentDitalsShow.SelectedRows[0].Cells["StudentNIC"].Value.ToString();
                Address.Text = StudentDitalsShow.SelectedRows[0].Cells["Address"].Value.ToString();
                ContactNO.Text = StudentDitalsShow.SelectedRows[0].Cells["ContactNO"].Value.ToString();
                Username.Text = StudentDitalsShow.SelectedRows[0].Cells["UserName"].Value.ToString();
                Password.Text = StudentDitalsShow.SelectedRows[0].Cells["Password"].Value.ToString();
            }

        }
    
    }
}
