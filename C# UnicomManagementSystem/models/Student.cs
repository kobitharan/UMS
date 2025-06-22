using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.models
{
    internal class Student
    {

        public string StudentFullName { get; set; }
        //public string StudentAddress { get; set; }
        public string StudentNIC { get; set; }
        public string ContactNO { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int StudentId  { get; set; }
        public int BatchId { get; set; }
        public int CourseId { get; set; }
        public int AddId { get; set; }
        public int SubjectId { get; set; }
        public string BatchName { get; set; }
        public string CourseName { get; set; }
        public string SubjectName { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
      //  public string CourseName { get; set; }
        // public int Id { get; set; }

        public Student()
        {

        }
        public Student(string name, string address, string FirsName)
        {
           

        }

    }
}
