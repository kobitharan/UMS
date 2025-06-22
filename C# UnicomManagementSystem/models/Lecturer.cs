using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Lecturer
    {
        public int LecturerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Specialization { get; set; }
        public string ContactNO { get; set; }
        public string NIC { get; set; }

        //public string StaffAddress { get; set; }
        //public string BatchId { get; set; }
    }
}
