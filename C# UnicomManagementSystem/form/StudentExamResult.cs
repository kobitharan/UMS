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
    public partial class StudentExamResult : Form
    {
        ExamController _ExamController;
        public StudentExamResult()
        {
            _ExamController = new ExamController();
            InitializeComponent();
            TimeTableDitals();
        }




        private void TimeTableDitals()
        {
            int CourseId = Convert.ToInt32(LoginDitals.Get("CourseId"));
            var ExamTableList = _ExamController.GetAllStudentExamDitals(CourseId);

            if (ExamTableList != null && ExamTableList.Count > 0)
            {
                ExamShow.Text = "";

                foreach (var exam in ExamTableList)
                {
                    ExamShow.Text +=
                        $"Date: {exam.Date}   " +
                        $"Batch: {exam.BatchName}   " +
                        $"Course: {exam.CourseName}   " +
                        $"Start Time: {exam.StartTime}  " +
                        $"End Time: {exam.EndTime} \r\n" +
                        $"\r\n";
                }
            }
            else
            {
                ExamShow.Text = "No Exams.";
            }

        }

        private void ExamSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
