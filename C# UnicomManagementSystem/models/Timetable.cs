using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Timetable
    {
        public int TimeTableId { get; set; }
        public string Date { get; set; }
        public string RoomName { get; set; }
        public string LecturerName { get; set; }
        public string Ditals { get; set; }
        public string SubjectName { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        
        public string StartTime { get; set; }

        public string EndTime { get; set; }
        public int BatchId { get; set; }
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
        public int RoomId { get; set; }
        public int LecturerId { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
