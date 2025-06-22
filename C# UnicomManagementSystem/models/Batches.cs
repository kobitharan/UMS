using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Batches
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CourseName { get; set; }
        public int CourseId { get; set; }
    }
}