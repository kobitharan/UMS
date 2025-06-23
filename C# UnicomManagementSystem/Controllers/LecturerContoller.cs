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
    internal class LecturerContoller
    {
        public List<Lecturer> GetAllLecturer()// Select All rooms----
        {
            var lecturers = new List<Lecturer>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {


                    const string query = "SELECT LecturerId,FullName FROM Lecturer_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var lectur = new Lecturer
                            {
                                LecturerId = reader.GetInt32(reader.GetOrdinal("LecturerId")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName"))
                            };

                            lecturers.Add(lectur);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return lecturers;
        }
      
        public Lecturer GetLecturerById(int lecturerId)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT LecturerId, FullName, Address, NIC, ContactNO, Specialization 
            FROM Lecturer_Table 
            WHERE LecturerId = @LecturerId", conn);

                cmd.Parameters.AddWithValue("@LecturerId", lecturerId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Lecturer
                        {
                            LecturerId = Convert.ToInt32(reader["LecturerId"]),
                            FullName = reader["FullName"].ToString(),
                            Address = reader["Address"].ToString(),
                            NIC = reader["NIC"].ToString(),
                            ContactNO = reader["ContactNO"].ToString(),
                            Specialization = reader["Specialization"].ToString()
                        };
                    }
                }
            }

            return null;
        }
        



    }
}
