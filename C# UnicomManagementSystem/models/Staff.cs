using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public int AddId { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }

        public string Address { get; set; }
        public string ContactNO { get; set; }
        public string UserName { get; set; }
        public string  Password{ get; set; }
        public string Specialization { get; set; }
        public string Role { get; set; }
        
       


        //public string BatchId { get; set; }
       // public string CourseId { get; set; }
    }
}
