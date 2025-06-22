using C__UnicomManagementSystem.Controllers;
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
    public partial class StudentDitals : Form
    {
        StaffAddContoller _taffAddContoller;
        StudentController _StudentController;
        public StudentDitals()
        {
            _taffAddContoller= new StaffAddContoller();
            _StudentController= new StudentController();
            InitializeComponent();
           StudentDit();
        }
        private void StudentDit()
        {
           // string LoginID = LoginDitals.Get("LoginID") as string;
            int LoginID = Convert.ToInt32(LoginDitals.Get("LoginID"));

            //  StudentDitalsBox
            var studentList = _StudentController.GetAllDitals(LoginID);
            if (studentList != null && studentList.Count > 0)
            {
                var student = studentList[0];

                StudentDitalsBox.Text =
                    $"Name: {student.StudentFullName}\r\n" +
                    $"NIC: {student.StudentNIC}\r\n" +
                    $"Address: {student.Address}\r\n" +
                    $"Contact: {student.ContactNO}\r\n" +
                    $"Batch: {student.BatchName}\r\n" +
                    $"Course: {student.CourseName}";
            }
            else
            {
                StudentDitalsBox.Text = "No student data found.";
            }
            //  StudentDitalsBox.Text = ($"{TimeTable[0]} { TimeTable[1]}");

            //ataGridViewTimeTable.DataSource = TimeTable;
            //ataGridViewTimeTable.ClearSelection();

        }
        private void StudentDitals_Load(object sender, EventArgs e)
        {

        }
    }
}
