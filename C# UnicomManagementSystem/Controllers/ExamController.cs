using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.Controllers
{
    internal class ExamController
    {
        public string AddExam(Exam  exam )
        {

            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Exam_Table (Ditals,Date,StartTime,EndTime,SubjectId,BatchId,CourseId,RoomId) VALUES (@Ditals,@Date,@StartTime,@EndTime,@SubjectId,@BatchId,@CourseId,@RoomId)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                insertStudentCommand.Parameters.AddWithValue("@Ditals", exam.Ditals);
                insertStudentCommand.Parameters.AddWithValue("@Date", exam.Date  );
                insertStudentCommand.Parameters.AddWithValue("@StartTime", exam.StartTime);
                insertStudentCommand.Parameters.AddWithValue("@EndTime", exam.EndTime);
                insertStudentCommand.Parameters.AddWithValue("@BatchId", exam.BatchId);
                insertStudentCommand.Parameters.AddWithValue("@CourseId", exam.CourseId);
                insertStudentCommand.Parameters.AddWithValue("@SubjectId", exam.SubjectId);
                insertStudentCommand.Parameters.AddWithValue("@RoomId", exam.RoomId);
               

                insertStudentCommand.ExecuteNonQuery();
            }

            return "This time  Added Successfully!";
        }
        public List<Exam> GetAllExam()
        {
            var Etable = new List<Exam>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                                        SELECT 
                                            T.ExamId,
                                            T.Ditals,
                                            T.Date,
                                            T.StartTime,
                                            T.EndTime,
                                            B.BatchName AS BatchName,
                                            C.CourseName AS CourseName,
                                            S.SubjectName AS SubjectName,
                                            R.RoomName AS RoomName
                                            FROM Exam_Table T
                                        LEFT JOIN Batch_Table B ON T.BatchId = B.BatchId
                                        LEFT JOIN Course_Table C ON T.CourseId = C.CourseId
                                        LEFT JOIN Subject_Table S ON T.SubjectId = S.SubjectId
                                        LEFT JOIN Room_Table R ON T.RoomId = R.RoomId ", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Etable.Add(new Exam
                    {
                        ExamId = reader.GetInt32(reader.GetOrdinal("ExamId")),
                        Date = reader.GetString(reader.GetOrdinal("Date")),
                        Ditals = reader.GetString(reader.GetOrdinal("Ditals")),
                        // StartDate = reader.GetString(reader.GetOrdinal("StartDate")),
                        //  EndDate = reader.GetString(reader.GetOrdinal("EndDate")),
                        StartTime = reader.GetString(reader.GetOrdinal("StartTime")),
                        EndTime = reader.GetString(reader.GetOrdinal("EndTime")),
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                        SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                       // LecturerName = reader.GetString(reader.GetOrdinal("FullName")),
                        //  EndTime = reader.GetString(reader.GetOrdinal("EndTime"))
                    });
                }
            }
            return Etable;

        }
        public void ExamDelete(int ExamID) // Delete NIC
        {
            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    //  Always open the connection explicitly

                    using (var cmd = new SQLiteCommand("DELETE FROM Exam_Table WHERE ExamId = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", ExamID);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting NIC: " + ex.Message);
                // Optionally log it to a file or UI
            }
        }
        public List<Exam> GetAllStudentExamDitals(int id)
        {
            var examList = new List<Exam>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT 
                E.ExamId,
                E.Ditals,
                E.Date,
                E.StartTime,
                E.EndTime,
                S.SubjectName AS SubjectName,
                B.BatchName AS BatchName,
                C.CourseName AS CourseName,
                R.RoomName AS RoomName
            FROM Exam_Table E
            LEFT JOIN Subject_Table S ON E.SubjectId = S.SubjectId
            LEFT JOIN Batch_Table B ON E.BatchId = B.BatchId
            LEFT JOIN Course_Table C ON E.CourseId = C.CourseId
            LEFT JOIN Room_Table R ON E.RoomId = R.RoomId
            WHERE E.CourseId = @Id", conn);

                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    examList.Add(new Exam
                    {
                        ExamId = reader.GetInt32(reader.GetOrdinal("ExamId")),
                        Ditals = reader.GetString(reader.GetOrdinal("Ditals")),
                        Date = reader.GetString(reader.GetOrdinal("Date")),
                        StartTime = reader["StartTime"] != DBNull.Value ? reader["StartTime"].ToString() : "",
                        EndTime = reader["EndTime"] != DBNull.Value ? reader["EndTime"].ToString() : "",
                        SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                        RoomName = reader.GetString(reader.GetOrdinal("RoomName"))
                    });
                }
            }

            return examList;
        }
        public List<Exam> GetAllExams()
        {
            var examList = new List<Exam>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT 
                ExamId,
                Ditals,
                Date,
                StartTime,
                EndTime,
                SubjectId,
                BatchId,
                CourseId,
                RoomId
            FROM Exam_Table", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    examList.Add(new Exam
                    {
                        ExamId = Convert.ToInt32(reader["ExamId"]),
                        Ditals = reader["Ditals"].ToString(),
                        Date = reader["Date"].ToString(),
                        StartTime = reader["StartTime"].ToString(),
                        EndTime = reader["EndTime"].ToString(),
                        SubjectId = Convert.ToInt32(reader["SubjectId"]),
                        BatchId = Convert.ToInt32(reader["BatchId"]),
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        RoomId = Convert.ToInt32(reader["RoomId"])
                    });
                }
            }

            return examList;
        }

    }
}
