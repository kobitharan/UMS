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
    internal class BatchController
    {

        
    public List<Batches> GetAllBatch()
       {
            var Batch = new List<Batches>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"SELECT  B.BatchId,B.BatchName,B.StartDate,B.EndDate,B.CourseId,C.CourseName AS CourseName
                                        FROM Batch_Table B
                                        LEFT JOIN Course_Table C ON B.CourseId = C.CourseId", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Batch.Add(new Batches
                    {
                        BatchId = reader.GetInt32(reader.GetOrdinal("BatchId")),
                        BatchName = reader.GetString(reader.GetOrdinal("BatchName")),
                        StartDate = reader.GetString(reader.GetOrdinal("StartDate")),
                        EndDate = reader.GetString(reader.GetOrdinal("EndDate")),
                        CourseId = reader.GetInt32(reader.GetOrdinal("CourseId")),
                        CourseName = reader.GetString(reader.GetOrdinal("CourseName"))
                    });
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
        
    }
}
