using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Exam
    {
        public int MarkId { get; set; }
        public int ExamId { get; set; }
        public int Mark { get; set; }
        public int StudentId { get; set; }
        public string ExamName { get; set; }
        public string Rank { get; set; }
        public int SubjectId { get; set; }
        public string Date { get; set; }
        public string RoomName { get; set; }
        public string LecturerName { get; set; }
        public string Ditals { get; set; }
        public string SubjectName { get; set; }
        public string StudentName { get; set; }
        public string ExamDetails { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
        public int BatchId { get; set; }
        public int CourseId { get; set; }
       // public int SubjectId { get; set; }
        public int RoomId { get; set; }
        public int LecturerId { get; set; }

        //public string StaffAddress { get; set; }
        //public string BatchId { get; set; }
        // public 
    }
}
