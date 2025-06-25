using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.form;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.Controllers
{
    internal class BatchController
    {


        public List<Batches> GetAllBatch()
        {
            var Batch = new List<Batches>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT  
                B.BatchId,
                B.BatchName,
                B.StartDate,
                B.EndDate,
                B.CourseId,
                C.CourseName AS CourseName
            FROM Batch_Table B
            LEFT JOIN Course_Table C ON B.CourseId = C.CourseId", conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var batch = new Batches
                    {
                        BatchId = reader["BatchId"] != DBNull.Value ? Convert.ToInt32(reader["BatchId"]) : 0,
                        BatchName = reader["BatchName"]?.ToString() ?? "N/A",
                        StartDate = reader["StartDate"]?.ToString() ?? "N/A",
                        EndDate = reader["EndDate"]?.ToString() ?? "N/A",
                        CourseId = reader["CourseId"] != DBNull.Value ? Convert.ToInt32(reader["CourseId"]) : 0,
                        CourseName = reader["CourseName"]?.ToString() ?? "N/A"
                    };

                    Batch.Add(batch);
                }
            }

            return Batch;
        }

        public string AddBatch(Batches batches)
            {

                using (var conn = DataBasecon.GetConnection())
                {
                    string addStudentQuery = "INSERT INTO Batch_Table (BatchName,StartDate,EndDate,CourseId) VALUES (@BatchName,@StartDate,@EndDate,@CourseId)";

                    SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                    insertStudentCommand.Parameters.AddWithValue("@BatchName", batches.BatchName);
                    insertStudentCommand.Parameters.AddWithValue("@StartDate", batches.StartDate);
                    insertStudentCommand.Parameters.AddWithValue("@EndDate", batches.EndDate);
                    insertStudentCommand.Parameters.AddWithValue("@CourseId", batches.CourseId);

                    insertStudentCommand.ExecuteNonQuery();
                }

                return "Course Added Successfully!";
            }
        public string DeleteBatch(Batches batches)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                try
                {

                    var command = new SQLiteCommand("DELETE FROM Batch_Table WHERE BatchId = @Id", conn);
                    command.Parameters.AddWithValue("@Id", batches.BatchId);
                    int rows = command.ExecuteNonQuery();


                    return "Deleted Successfully!";

                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
    }   }
}
