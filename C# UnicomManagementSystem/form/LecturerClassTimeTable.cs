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
                var sb = new StringBuilder(); // faster than +=

                foreach (var timeTable in TimeTableList)
                {
                    sb.AppendLine("📅 Date       : " + timeTable.Date);
                    sb.AppendLine("📘 Course     : " + timeTable.CourseName);
                    sb.AppendLine("👨‍🏫 Lecturer   : " + timeTable.LecturerName);
                    sb.AppendLine("👥 Batch      : " + timeTable.BatchName);
                    sb.AppendLine("🕒 Start Time : " + timeTable.StartTime);
                    sb.AppendLine("🕔 End Time   : " + timeTable.EndTime);
                    sb.AppendLine("──────────────────────────────");
                }

                LecturerShowTimeTable.Text = sb.ToString();
            }
            else
            {
                LecturerShowTimeTable.Text = "❌ No Class Available.";
            }
           
          
        }
    } 
}
