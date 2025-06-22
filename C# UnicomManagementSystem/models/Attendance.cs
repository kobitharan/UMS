using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public string Month { get; set; }
        public string Percentage { get; set; }
        public int StaffId { get; set; }
       

    }
}
