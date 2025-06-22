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
        public List<Lecturer> GetAllLecturerDitals(int lecturerId)
        {
            var lecturerList = new List<Lecturer>();

            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT LecturerId, FullName, Address, NIC, ContactNO, Specialization 
            FROM Lecturer_Table 
            WHERE LecturerId = @LecturerId", conn);

                cmd.Parameters.AddWithValue("@LecturerId", lecturerId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lecturerList.Add(new Lecturer
                    {
                        LecturerId = reader.GetInt32(reader.GetOrdinal("LecturerId")),
                        FullName = reader.GetString(reader.GetOrdinal("FullName")),
                        Address = reader.GetString(reader.GetOrdinal("Address")),
                        NIC = reader.GetString(reader.GetOrdinal("NIC")),
                        ContactNO = reader.GetString(reader.GetOrdinal("ContactNO")),
                        Specialization = reader.GetString(reader.GetOrdinal("Specialization"))
                    });
                }
            }

            return lecturerList;
        }

    }
}
