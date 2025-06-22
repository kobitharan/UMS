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
    internal class TimetableController
    {
        public string AddTimeTabble( Timetable timetable )
        {

            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Time_Table (Date,StartTime,EndTime,BatchId,CourseId,SubjectId,RoomId,LecturerId) VALUES (@Date,@StartTime,@EndTime,@BatchId,@CourseId,@SubjectId,@RoomId,@LecturerId)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                insertStudentCommand.Parameters.AddWithValue("@Date", timetable.Date);
                insertStudentCommand.Parameters.AddWithValue("@StartTime", timetable.StartTime);
                insertStudentCommand.Parameters.AddWithValue("@EndTime", timetable.EndTime);
                insertStudentCommand.Parameters.AddWithValue("@BatchId", timetable.BatchId);
                insertStudentCommand.Parameters.AddWithValue("@CourseId", timetable.CourseId);
                insertStudentCommand.Parameters.AddWithValue("@SubjectId", timetable.SubjectId);
                insertStudentCommand.Parameters.AddWithValue("@RoomId", timetable.RoomId);
                insertStudentCommand.Parameters.AddWithValue("@LecturerId", timetable.LecturerId);

                insertStudentCommand.ExecuteNonQuery();
            }

            return "This time  Added Successfully!";
        }
       
        public List<Timetable > GetTimeTableDitals()
        {
            var Ttable = new List<Timetable >();

            using (var conn = DataBasecon.GetConnection())
            {var cmd = new SQLiteCommand(@"
                                        SELECT 
                                            T.TimeTableId,
                                            T.Date,
                                            T.StartTime,
                                            T.EndTime,
                                            B.BatchName AS BatchName,
                                            C.CourseName AS CourseName,
                                            S.SubjectName AS SubjectName,
                                            R.RoomName AS RoomName,
                                            L.FullName AS FullName
                                        FROM Time_Table T
                                        LEFT JOIN Batch_Table B ON T.BatchId = B.BatchId
                                        LEFT JOIN Course_Table C ON T.CourseId = C.CourseId
                                        LEFT JOIN Subject_Table S ON T.SubjectId = S.SubjectId
                                        LEFT JOIN Room_Table R ON T.RoomId = R.RoomId
                                        LEFT JOIN Lecturer_Table L ON T.LecturerId = L.LecturerId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ttable.Add(new Timetable
                    {
                        TimeTableId = reader.GetInt32(reader.GetOrdinal("TimeTableId")),
                        Date = reader.GetString(reader.GetOrdinal("Date")),
                        StartTime = reader.GetString(reader.GetOrdinal("StartTime")), // FIXED
                        EndTime = reader.GetString(reader.GetOrdinal("EndTime")),     // FIXED
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                        // SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")), // Uncomment if needed
                        RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                        LecturerName = reader.GetString(reader.GetOrdinal("FullName"))
                    });

                }
            }

            return Ttable;

        }
        public List<Timetable > GetAllTimeTableDitals(int id)
        {
            var Ttable = new List<Timetable >();

            using (var conn = DataBasecon.GetConnection())
            {var cmd = new SQLiteCommand(@"
                                        SELECT 
                                            T.TimeTableId,
                                            T.Date,
                                            T.StartTime,
                                            T.EndTime,
                                            B.BatchName AS BatchName,
                                            C.CourseName AS CourseName,
                                            S.SubjectName AS SubjectName,
                                            R.RoomName AS RoomName,
                                            L.FullName AS FullName
                                        FROM Time_Table T
                                        LEFT JOIN Batch_Table B ON T.BatchId = B.BatchId
                                        LEFT JOIN Course_Table C ON T.CourseId = C.CourseId
                                        LEFT JOIN Subject_Table S ON T.SubjectId = S.SubjectId
                                        LEFT JOIN Room_Table R ON T.RoomId = R.RoomId
                                        LEFT JOIN Lecturer_Table L ON T.LecturerId = L.LecturerId
                                         WHERE T.CourseId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ttable.Add(new Timetable
                    {
                        TimeTableId = reader.GetInt32(reader.GetOrdinal("TimeTableId")),
                        Date = reader.GetString(reader.GetOrdinal("Date")),
                        StartTime = reader["StartTime"] != DBNull.Value ? reader["StartTime"].ToString() : "",
                        EndTime = reader["EndTime"] != DBNull.Value ? reader["EndTime"].ToString() : "",
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                      //  SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                        LecturerName = reader.GetString(reader.GetOrdinal("FullName")),
                      //  EndTime = reader.GetString(reader.GetOrdinal("EndTime"))
                    });
                }
            }

            return Ttable;

        } public List<Timetable > GetAllTimeTableDitalsShowLecturer( )
        {
            var Ttable = new List<Timetable >();

            using (var conn = DataBasecon.GetConnection())
            {var cmd = new SQLiteCommand(@"
                                        SELECT 
                                            T.TimeTableId,
                                            T.Date,
                                            T.StartTime,
                                            T.EndTime,
                                            B.BatchName AS BatchName,
                                            C.CourseName AS CourseName,
                                            S.SubjectName AS SubjectName,
                                            R.RoomName AS RoomName,
                                            L.FullName AS FullName
                                        FROM Time_Table T
                                        LEFT JOIN Batch_Table B ON T.BatchId = B.BatchId
                                        LEFT JOIN Course_Table C ON T.CourseId = C.CourseId
                                        LEFT JOIN Subject_Table S ON T.SubjectId = S.SubjectId
                                        LEFT JOIN Room_Table R ON T.RoomId = R.RoomId
                                        LEFT JOIN Lecturer_Table L ON T.LecturerId = L.LecturerId", conn);
           
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ttable.Add(new Timetable
                    {
                        TimeTableId = reader.GetInt32(reader.GetOrdinal("TimeTableId")),
                        Date = reader.GetString(reader.GetOrdinal("Date")),
                        StartTime = reader["StartTime"] != DBNull.Value ? reader["StartTime"].ToString() : "",
                        EndTime = reader["EndTime"] != DBNull.Value ? reader["EndTime"].ToString() : "",
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                      //  SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                        LecturerName = reader.GetString(reader.GetOrdinal("FullName")),
                      //  EndTime = reader.GetString(reader.GetOrdinal("EndTime"))
                    });
                }
            }

            return Ttable;

        }
        public bool IsTimeOverlapping(string date, string startTime, string endTime, int batchId)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT COUNT(*) FROM Time_Table
            WHERE Date = @Date
              AND BatchId = @BatchId
              AND (
                    (StartTime < @EndTime AND EndTime > @StartTime)
                 )", conn);

                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@BatchId", batchId);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

    }

}
