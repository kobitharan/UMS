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
    public partial class LecturerClassTimeTable : Form
    {
        TimetableController _TimetableController;
        public LecturerClassTimeTable()
        {
            InitializeComponent();
            _TimetableController=new TimetableController();
            LecturerShowTimeTableDitals();
        }
        private void LecturerShowTimeTableDitals()
        {
           
            var TimeTableList = _TimetableController.GetAllTimeTableDitalsShowLecturer();

            if (TimeTableList != null && TimeTableList.Count > 0)
            {
                LecturerShowTimeTable.Text = "";

                foreach (var TimeTable in TimeTableList)
                {
                    LecturerShowTimeTable.Text +=
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
                LecturerShowTimeTable.Text = "No Class.";
            }
        }
    } 
}
