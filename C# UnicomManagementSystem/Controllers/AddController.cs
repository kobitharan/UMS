using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__UnicomManagementSystem.Controllers
{
    internal class AddController
    {
        public void AddDitals(Staff staff)
        {
           
            using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand("INSERT INTO Add_Table (Name, NIC, Address, ContactNO,Role, UserName,Password) VALUES (@Name,@NIC,@Address,@ContactNO,@Role,@UserName,@Password", conn);
                command.Parameters.AddWithValue("@Name", staff.Name);
                command.Parameters.AddWithValue("@NIC", staff.NIC);
                command.Parameters.AddWithValue("@Address", staff.Address);
                command.Parameters.AddWithValue("@ContactNO", staff.ContactNO);
                command.Parameters.AddWithValue("@Role", staff.Role);
                command.Parameters.AddWithValue("@UserName", staff.UserName);
                command.Parameters.AddWithValue("@Password", staff.Password);
                command.Parameters.AddWithValue("@Specialization", staff.Specialization);
                command.ExecuteNonQuery();
                MessageBox.Show("Please enter both Name and Address.");
            }
        }
        public string AddCourse(Course course)
        {

            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Course_Table (CourseName) VALUES (@name)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                insertStudentCommand.Parameters.AddWithValue("@name", course.CourseName);
           
                insertStudentCommand.ExecuteNonQuery();
            }

            return "Course Added Successfully!";
        }
        public string AddSubject(Subject course)
        {

            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Subject_Table (SubjectName,CourseId) VALUES (@SubjectName,@CourseId)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                insertStudentCommand.Parameters.AddWithValue("@CourseId", course.CourseId);
                insertStudentCommand.Parameters.AddWithValue("@SubjectName", course.SubjectName);

                insertStudentCommand.ExecuteNonQuery();
            }

            return "Subject Added Successfully!";
        }
        public void TemrariAdd(Staff staff)

        {
          
            if (string.IsNullOrEmpty(staff.Role))
            {
                MessageBox.Show("Please select a Role.");
                return;
            }
                //MessageBox.Show("Please enter both Name and Address.");
                using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand("INSERT INTO Add_Table(Name, NIC, Address,ContactNO,Role,UserName,Password,Specialization) VALUES (@Name,@NIC,@Address,@ContactNO,@Role,@UserName,@Password,@Specialization);", conn);
                command.Parameters.AddWithValue("@Name", staff.Name);
                command.Parameters.AddWithValue("@NIC", staff.NIC);
                command.Parameters.AddWithValue("@Address", staff.Address);
                command.Parameters.AddWithValue("@ContactNO", staff.ContactNO);
                command.Parameters.AddWithValue("@Role", staff.Role);
                command.Parameters.AddWithValue("@UserName", staff.UserName);
                command.Parameters.AddWithValue("@Password", staff.Password);
                command.Parameters.AddWithValue("@Specialization", staff.Specialization);
                command.ExecuteNonQuery();
            }

        }
        public void AddDital( Staff staff)
        {
            //MessageBox.Show("Please enter both Name and Address.");
            using (var conn = DataBasecon.GetConnection())
            {
                //staffname 
                int lastId;
                
                var command = new SQLiteCommand($"INSERT INTO {staff.Role+"_Table"} (FullName,NIC,Address, ContactNO,Specialization) VALUES (@StaffFullName,@StaffNIC,@StaffAddress,@ContactNO,@Specialization);", conn);
                command.Parameters.AddWithValue("@StaffFullName", staff.Name);
                command.Parameters.AddWithValue("@StaffNIC", staff.NIC);
                command.Parameters.AddWithValue("@StaffAddress", staff.Address);
                command.Parameters.AddWithValue("@ContactNO", staff.ContactNO);
                command.Parameters.AddWithValue("@Specialization", staff.Specialization);

                command.ExecuteNonQuery();
                using (var idCmd = new SQLiteCommand("SELECT last_insert_rowid();", conn))
                {
                    lastId = Convert.ToInt32(idCmd.ExecuteScalar());
                }

               

                var command1 = new SQLiteCommand("INSERT INTO Users_Table (UserName, Password, Status, ALLID) VALUES (@UserName,@Password,@Status,@ALLID);", conn);
                command1.Parameters.AddWithValue("@UserName", staff.UserName);
                command1.Parameters.AddWithValue("@Password", staff.Password);
                command1.Parameters.AddWithValue("@Status", "Active");
                command1.Parameters.AddWithValue("@ALLID", $"{staff.Role} {lastId}");




                command1.ExecuteNonQuery();
            }

        }
        public void AdminDitals( Staff staff)
        {
            //MessageBox.Show("Please enter both Name and Address.");
            using (var conn = DataBasecon.GetConnection())
            {
                //staffname 
                int lastId = 1;
               
                var command11 = new SQLiteCommand("INSERT INTO Users_Table (UserName, Password, Status, ALLID) VALUES (@UserName,@Password,@Status,@ALLID);", conn);
                command11.Parameters.AddWithValue("@UserName", staff.UserName);
                command11.Parameters.AddWithValue("@Password", staff.Password);
                command11.Parameters.AddWithValue("@Status", "Active");
                command11.Parameters.AddWithValue("@ALLID", $"Admin 1 ");




                command11.ExecuteNonQuery();
            }

        }
      
    }


}
