using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Timetable> GetTimeTableDitals()
        {
            var Ttable = new List<Timetable>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
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
                        TimeTableId = reader["TimeTableId"] != DBNull.Value ? Convert.ToInt32(reader["TimeTableId"]) : 0,
                        Date = reader["Date"]?.ToString() ?? "N/A",
                        StartTime = reader["StartTime"]?.ToString() ?? "N/A",
                        EndTime = reader["EndTime"]?.ToString() ?? "N/A",
                        BatchName = reader["BatchName"]?.ToString() ?? "N/A",
                        CourseName = reader["CourseName"]?.ToString() ?? "N/A",
                        SubjectName = reader["SubjectName"]?.ToString() ?? "N/A",
                        RoomName = reader["RoomName"]?.ToString() ?? "N/A",
                        LecturerName = reader["FullName"]?.ToString() ?? "N/A"
                    });
                }
            }

            return Ttable;
        }

        public List<Timetable> GetAllTimeTableDitals(int id)
        {
            var Ttable = new List<Timetable>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    var cmd = new SQLiteCommand(@"
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
                        var timetable = new Timetable
                        {
                            TimeTableId = reader["TimeTableId"] != DBNull.Value ? Convert.ToInt32(reader["TimeTableId"]) : 0,
                            Date = reader["Date"] != DBNull.Value ? reader["Date"].ToString() : "N/A",
                            StartTime = reader["StartTime"] != DBNull.Value ? reader["StartTime"].ToString() : "N/A",
                            EndTime = reader["EndTime"] != DBNull.Value ? reader["EndTime"].ToString() : "N/A",
                            BatchName = reader["BatchName"] != DBNull.Value ? reader["BatchName"].ToString() : "N/A",
                            CourseName = reader["CourseName"] != DBNull.Value ? reader["CourseName"].ToString() : "N/A",
                            SubjectName = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : "N/A",
                            RoomName = reader["RoomName"] != DBNull.Value ? reader["RoomName"].ToString() : "N/A",
                            LecturerName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : "N/A"
                        };

                        Ttable.Add(timetable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }

            return Ttable;
        }


        public List<Timetable> GetAllTimeTableDitalsShowLecturer()
        {
            var Ttable = new List<Timetable>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
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
                        TimeTableId = reader["TimeTableId"] != DBNull.Value ? Convert.ToInt32(reader["TimeTableId"]) : 0,
                        Date = reader["Date"]?.ToString() ?? "N/A",
                        StartTime = reader["StartTime"]?.ToString() ?? "N/A",
                        EndTime = reader["EndTime"]?.ToString() ?? "N/A",
                        BatchName = reader["BatchName"]?.ToString() ?? "N/A",
                        CourseName = reader["CourseName"]?.ToString() ?? "N/A",
                        SubjectName = reader["SubjectName"]?.ToString() ?? "N/A",
                        RoomName = reader["RoomName"]?.ToString() ?? "N/A",
                        LecturerName = reader["FullName"]?.ToString() ?? "N/A"
                    });
                }
            }

            return Ttable;
        }

        public bool IsTimeOverlapping(string date, string startTime, string endTime, int batchId, int lecturerId, int roomId)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT COUNT(*) FROM Time_Table
            WHERE Date = @Date
              AND (
                  (BatchId = @BatchId) OR
                  (LecturerId = @LecturerId) OR
                  (RoomId = @RoomId)
              )
              AND (
                  (StartTime < @EndTime AND EndTime > @StartTime)
              )
        ", conn);

                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.Parameters.AddWithValue("@BatchId", batchId);
                cmd.Parameters.AddWithValue("@LecturerId", lecturerId);
                cmd.Parameters.AddWithValue("@RoomId", roomId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public string DeleteTimeTable( int TID)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                try
                {

                    var command = new SQLiteCommand("DELETE FROM Time_Table WHERE TimeTableId = @Id", conn);
                    command.Parameters.AddWithValue("@Id", TID);
                    int rows = command.ExecuteNonQuery();


                    return "Deleted Successfully!";

                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }
    }
}


