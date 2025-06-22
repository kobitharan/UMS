using C__UnicomManagementSystem.Controllers;
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
using System.Xml;
using System.Xml.Linq;

namespace C__UnicomManagementSystem.form
{
    public partial class TimeTableViewStudent : Form
    {
        TimetableController _TimetableController;
        public TimeTableViewStudent()
        {
            InitializeComponent();
            _TimetableController = new TimetableController();
            //StuTimeTableShow
            TimeTableDitals();
        }
        private void TimeTableDitals()
        {
            int CourseId = Convert.ToInt32(LoginDitals.Get("CourseId"));
            var TimeTableList = _TimetableController.GetAllTimeTableDitals(CourseId);

            if (TimeTableList != null && TimeTableList.Count > 0)
            {
                StuTimeTableShow.Text = "";

                foreach (var TimeTable in TimeTableList)
                {
                    StuTimeTableShow.Text +=
                        $"Date: {TimeTable.Date}   " +
                        $"Batch: {TimeTable.BatchName}   " +
                        $"Course: {TimeTable.CourseName}   " +
                        $"Start Time: {TimeTable.StartTime}  " +
                        $"End Time: {TimeTable.EndTime}   " +
                        $"Lecturer: {TimeTable.LecturerName} \r\n" +
                        $" \r\n";
                }
            }
            else
            {
                StuTimeTableShow.Text = "No Class.";
            }

            //  StudentDitalsBox
            //var TimeTableList = _TimetableController.GetAllTimeTableDitals(CourseId);
            //if (TimeTableList != null && TimeTableList.Count > 0)
            //{
            //    while  var TimeTable = TimeTableList[0];)
            //    {
            //        var TimeTable = TimeTableList[0];


            //        StuTimeTableShow.Text =
            //     $"Date: {TimeTable.Date}\r\n" +
            //     $"Batch: {TimeTable.BatchName}\r\n" +
            //     $"Course: {TimeTable.CourseName}\r\n" +
            //     $"Start Time: {TimeTable.StartTime}\r\n" +
            //     $"End Time: {TimeTable.EndTime}\r\n" +
            //     $"Lecturer: {TimeTable.LecturerName}";
            //    }
            //}
            //else
            //{
            //    StuTimeTableShow.Text = "No  Class  .";
            //}

        }

        private void TimeTableViewStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
