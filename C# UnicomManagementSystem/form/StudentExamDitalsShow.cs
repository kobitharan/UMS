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
    public partial class StudentExamDitalsShow : Form
    {
        ExamController _ExamController;
        public StudentExamDitalsShow()
        {
            _ExamController = new ExamController();
            InitializeComponent();
            //StudentExamDitals
            StudentDit();
        }
        private void StudentDit()
        {
           

            int CourseId = Convert.ToInt32(LoginDitals.Get("CourseId"));
           // var ExamTableList = _ExamController.GetStudentExamMarkDitals(CourseId);

          //  if (ExamTableList != null && ExamTableList.Count > 0)
            //{
            //    StudentExamDitals.Text = "";

            //    foreach (var exam in ExamTableList)
            //    {
            //        StudentExamDitals.Text +=
            //            $"Date: {exam.Date}   " +
            //            $"Batch: {exam.BatchName}   " +
            //            $"Course: {exam.CourseName}   " +
            //            $"Subject: {exam.SubjectName }   " +
            //            $"Rank: {exam.Rank}   " +
            //            $"ExamDetails: {exam.ExamDetails}   " +
            //            $"StudentName: {exam.StudentName}   " +
            //            $"Start Time: {exam.StartTime}  " +
            //            $"End Time: {exam.EndTime} \r\n" +
            //            $"\r\n";
            //    }
            //}
            //else
            //{
            //    StudentExamDitals.Text = "No Exams.";
            //}

        }


    }
}
