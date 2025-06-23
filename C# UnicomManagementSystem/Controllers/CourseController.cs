using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.form;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace C__UnicomManagementSystem.Controllers
{
    internal class CourseController
    {
        public List<Course> GetAllCourse()
        {
            var courses = new List<Course>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                  

                    const string query = "SELECT CourseId, CourseName FROM Course_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var course = new Course
                            {
                                CourseId = reader.GetInt32(reader.GetOrdinal("CourseId")),
                                CourseName = reader.GetString(reader.GetOrdinal("CourseName"))
                            };

                            courses.Add(course);
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return courses;
        }
        public List<Batches> GetAllBatch()
        {
            var Batches = new List<Batches>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                  

                    const string query = "SELECT BatchId, BatchName FROM Batch_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Batch = new Batches
                            {
                                BatchId = reader.GetInt32(reader.GetOrdinal("BatchId")),
                                BatchName = reader.GetString(reader.GetOrdinal("BatchName"))
                            };

                            Batches.Add(Batch);
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return Batches;
        } 
        public List<Room> GetAllRoom()// Select All rooms----
        {
            var rooms = new List<Room>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                  

                    const string query = "SELECT RoomId, RoomName FROM Room_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var room  = new Room
                            {
                                RoomId = reader.GetInt32(reader.GetOrdinal("RoomId")),
                                RoomName = reader.GetString(reader.GetOrdinal("RoomName"))
                            };

                            rooms .Add(room);
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return rooms;
        }



        // course ditals ahh tharum
        //public List<Course> GetAllSubject()
        //{
        //    var courseList = new List<Course>();
        //    using (var conn = DataBasecon.GetConnection())
        //    {
        //        var cmd = new SQLiteCommand(@"
        //    SELECT S.SubjectId, S.SubjectName, S.CourseId, C.CourseName AS CourseName
        //    FROM Subject_Table S
        //    LEFT JOIN Course_Table C ON S.CourseId = C.CourseId", conn);

        //        var reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Course course = new Course
        //            {
        //                SubjectId = reader.GetInt32(reader.GetOrdinal("SubjectId")),
        //                SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
        //                CourseId = reader.GetInt32(2),
        //                CourseName=reader.GetString(reader.GetOrdinal("CourseName"))
        //            };
        //        }
        //        }
        //    return courseList;
        // }

        public List<Course> GetAllSubject()
        {
            var CourseList = new List<Course>(); // Better name to avoid confusion with class name

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT S.SubjectId, S.SubjectName, S.CourseId, C.CourseName AS CourseName
            FROM Subject_Table S
            LEFT JOIN Course_Table C ON S.CourseId = C.CourseId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course
                    {
                        SubjectName = reader["SubjectName"]?.ToString() ?? "N/A",
                        CourseName = reader["CourseName"]?.ToString() ?? "N/A",
                    };

                    CourseList.Add(course);
                }
            }

            return CourseList;
        }

        public List<Course> GeSubjectName(int id)
        {
            
            var Course = new List<Course>();
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@" 
                    SELECT  SubjectId,SubjectName 
                    FROM Subject_Table 
                    WHERE CourseId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course
                    // Course.Add(new Course
                    {
                        SubjectId = reader.GetInt32(reader.GetOrdinal("SubjectId")),
                        SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                       // CourseId = reader.GetInt32(reader.GetOrdinal("CourseId")),
                       // CourseName = reader.GetString(reader.GetOrdinal("CourseName"))

                    };
                    Course.Add(course);
                }
            }

            return Course;
        }

        public void DeleteCourse(int Id)//Delete courss -----
        {
            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Course_Table WHERE CourseId  = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    
                    var cmd1 = new SQLiteCommand("DELETE FROM Subject_Table WHERE CourseId = @CId ", conn);
                    cmd.Parameters.AddWithValue("@CId", Id);

                    cmd1.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting course: " + ex.Message);
                // Or log it
            }
        }
        public void DeleteSubject(int CourseId,int SubjectId)
        {
            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Subject_Table WHERE CourseId = @CId AND SubjectId= @SId", conn);
                    cmd.Parameters.AddWithValue("@CId", CourseId);
                    cmd.Parameters.AddWithValue("@SId", SubjectId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting course: " + ex.Message);
                // Or log it
            }
        }
        //public Course GetCourseById(int id)
        //{
        //    using (var conn = DataBasecon.GetConnection())
        //    {
        //        var cmd = new SQLiteCommand("SELECT CourseName FROM Course_Table WHERE Id = @Id", conn);
        //        cmd.Parameters.AddWithValue("@Id", id);

        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                return new Course
        //                {
        //                    // CourseId = reader.GetInt32(0),
        //                    CourseName = reader.GetString(1),

        //                };
        //            }
        //        }
        //    }

        //    return null;
        //}
        public void UpdateCourse(Course course)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Course_Table SET CourseName = @Name WHERE CourseId = @Id", conn);
                command.Parameters.AddWithValue("@Name", course.CourseName);
                command.Parameters.AddWithValue("@Id", course.CourseId);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateSubject(Subject Subject)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Subject_Table SET SubjectName = @Name WHERE SubjectId = @Id", conn);
                command.Parameters.AddWithValue("@Name", Subject.SubjectName);
                command.Parameters.AddWithValue("@Id",Subject.SubjectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
