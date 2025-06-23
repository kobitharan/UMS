using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.form;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.Controllers
{
    internal class StudentController
    {

        public void AddStudent(Student student)
        {
            //MessageBox.Show("Please enter both Name and Address.");
            using (var conn = DataBasecon.GetConnection())
            {
                int lastId;
                var command = new SQLiteCommand("INSERT INTO Students_Table (StudentFullName, StudentNIC, StudentAddress, ContactNO,CourseId,BatchId) VALUES (@Name,@NIC,@Address,@ContactNO,@CourseID,@BatchId);", conn);
                command.Parameters.AddWithValue("@Name", student.StudentFullName);
                command.Parameters.AddWithValue("@NIC", student.StudentNIC);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@ContactNO", student.ContactNO);
                command.Parameters.AddWithValue("@CourseID", student.CourseId);
                command.Parameters.AddWithValue("@BatchId", student.BatchId);

                command.ExecuteNonQuery();
                using (var idCmd = new SQLiteCommand("SELECT last_insert_rowid();", conn))
                {
                    lastId = Convert.ToInt32(idCmd.ExecuteScalar());
                }

                //var cmd = new SQLiteCommand(@"
                //SELECT StudentId
                //FROM Students_Table
                //WHERE StudentNIC =@UserNIC 
                //", conn);
                //cmd.Parameters.AddWithValue("@UserNIC", student.StudentNIC);
                //var reader = cmd.ExecuteReader();

                var command1 = new SQLiteCommand("INSERT INTO Users_Table (UserName, Password, Status, ALLID) VALUES (@UserName,@Password,@Status,@ALLID);", conn);
                command1.Parameters.AddWithValue("@UserName", student.UserName);
                command1.Parameters.AddWithValue("@Password", student.Password);
                command1.Parameters.AddWithValue("@Status", "Active");
                command1.Parameters.AddWithValue("@ALLID", $"Student {lastId}");




                command1.ExecuteNonQuery();
            }

        }
        public void TemrariAddStudent(Student student)
        {
            //MessageBox.Show("Please enter both Name and Address.");
            using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand("INSERT INTO AddStudent_Table (Name, NIC, Address, ContactNO,CourseID, UserName,Password,BatchId) VALUES (@Name,@NIC,@Address,@ContactNO,@CourseID,@UserName,@Password,@BatchId);", conn);
                command.Parameters.AddWithValue("@Name", student.StudentFullName);
                command.Parameters.AddWithValue("@NIC", student.StudentNIC);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@ContactNO", student.ContactNO);
                command.Parameters.AddWithValue("@CourseID", student.CourseId);
                command.Parameters.AddWithValue("@UserName", student.UserName);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@BatchId", student.BatchId);
                command.ExecuteNonQuery();
            }

        }
        //GetAllDitals
        public List<Student> GetAllDitals(int Id)
        {

            var students = new List<Student>();
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@" 
                            SELECT * 
                            FROM Students_Table S
                            LEFT JOIN Course_Table C ON S.CourseId = C.CourseId
                            LEFT JOIN Batch_Table B ON S.BatchId = B.BatchId
                            WHERE StudentId = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        //    StudentName = reader.GetString(reader.GetOrdinal("StudentFullName")),
                        //    StudentAddress = reader.GetString(reader.GetOrdinal("StudentAddress")),
                        //   // StudentNIC = reader.GetString(reader.GetOrdinal("NIC")),
                        //    ContactNO = reader.GetString(reader.GetOrdinal("ContactNO")),
                        //    StudentNIC = reader.GetString(reader.GetOrdinal("StudentNIC")),
                        //    BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        //    CourseName = reader.GetString(reader.GetOrdinal("CourseName"))
                        StudentFullName = reader["StudentFullName"].ToString(),
                        Address = reader["StudentAddress"].ToString(),
                        ContactNO = reader["ContactNO"].ToString(),
                        StudentNIC = reader["StudentNIC"].ToString(),
                        BatchName = reader["BatchName"].ToString(),
                        CourseName = reader["CourseName"].ToString(),
                        CourseId = Convert.ToInt32(reader["CourseId"])


                    };
                    LoginDitals.Set("CourseId", student.CourseId);
                    students.Add(student);
                }
            }

            return students;
        }
        public List<Student> GetAllADDTable()
        {

            var Student = new List<Student>();
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@" 
                    SELECT *
                    FROM AddStudent_Table S
                    LEFT JOIN Course_Table C ON S.CourseId = C.CourseId
                    LEFT JOIN Batch_Table B ON S.BatchId = B.BatchId", conn);
                // cmd.Parameters.AddWithValue("@Role", name);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student ST = new Student
                    {// AddId,Name,NIC,Address,ContactNO,CourseID,UserName,Password ,BatchId 
                        AddId = reader.GetInt32(reader.GetOrdinal("AddId")),
                        StudentFullName = reader.GetString(reader.GetOrdinal("Name")),
                        StudentNIC = reader.GetString(reader.GetOrdinal("NIC")),
                        ContactNO = reader.GetString(reader.GetOrdinal("ContactNO")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                        // SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                        Password = reader.GetString(reader.GetOrdinal("Password")),
                        Address = reader.GetString(reader.GetOrdinal("Address")),
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName"))
                    };

                    Student.Add(ST);
                }
            }

            return Student;
        }
        public void DeleteAddStudenttable(int Id)//Delete courss -----
        {
            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM AddStudent_Table WHERE AddId = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting course: " + ex.Message);
                // Or log it
            }
        }
        public List<Student> GetStudentsByCourseAndBatch(int courseId, int batchId)
        {
            var students = new List<Student>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT 
                StudentId,
                StudentFullName,
                StudentNIC,
                StudentAddress,
                ContactNO,
                CourseId,
                BatchId
            FROM Students_Table
            WHERE CourseId = @CourseId AND BatchId = @BatchId", conn);

                cmd.Parameters.AddWithValue("@CourseId", courseId);
                cmd.Parameters.AddWithValue("@BatchId", batchId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentId = reader["StudentId"] != DBNull.Value ? Convert.ToInt32(reader["StudentId"]) : 0,
                        StudentFullName = reader["StudentFullName"]?.ToString() ?? "N/A"
                    });
                }


                return students;

            }
        }
        public void DeleteNICById(int nicId)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM NIC_Table WHERE NICId = @nicId", conn);
                cmd.Parameters.AddWithValue("@nicId", nicId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
