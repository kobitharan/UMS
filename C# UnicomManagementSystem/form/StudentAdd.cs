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
        public StudentAdd(string role)
        {
            InitializeComponent();
            _studentController = new StudentController();
            _CourseController = new CourseController();
            _NICADDController = new NICADDController();

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
            Student Student = new Student
            {
                StudentFullName = Sname.Text,
                StudentNIC = (StudentNIC.Text),
                Address = StudentAddress.Text,
                ContactNO= StudentContactNO.Text,
                UserName= StudentUserName.Text,
                Password= StudentPassword.Text,
                CourseId = Convert.ToInt32(Course.SelectedValue),
                BatchId = Convert.ToInt32(batch.SelectedValue),


            };
           List <NICdata >NICn= _NICADDController.GetNICCheck(Student.StudentNIC );

           
            if (NICn.Count == 0)
            {
                _studentController.TemrariAddStudent(Student);
                ClearForm();
                return ;
            }
           
            else
            {

                MessageBox.Show(" Your Select THis Course.");

                _studentController.AddStudent(Student);
                ClearForm();
            }

           
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
