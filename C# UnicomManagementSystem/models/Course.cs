using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
        public string CourseName { get; set; }
        public string SubjectName { get; set; }

        //public string StaffAddress { get; set; }
        //public string BatchId { get; set; }
        // public string CourseId { get; set; }
    }
}
