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
    internal class NICADDController
    {




        public List<NICdata> GetAllNIC()
        {
            var NIC = new List<NICdata>();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    // Always explicitly open connection

                    const string query = "SELECT NICId,NIC,Role  FROM NIC_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var NICdata = new NICdata
                            {
                                NICId = reader.GetInt32(reader.GetOrdinal("NICId")),
                                NIC = reader.GetString(reader.GetOrdinal("NIC")),
                                Role = reader.GetString(reader.GetOrdinal("Role"))

                            };

                            NIC.Add(NICdata);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return NIC;
        }
        public string AddNIC(NICdata NICdata)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO NIC_Table (NIC,Role) VALUES (@NIC, @Role)";
                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);

                insertStudentCommand.Parameters.AddWithValue("@NIC", NICdata.NIC);
                insertStudentCommand.Parameters.AddWithValue("@Role", NICdata.Role);

                insertStudentCommand.ExecuteNonQuery();
            }

            return "NIC Added Successfully!";
        }

        public void NICDelete(int NICId) // Delete NIC
        {
            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    //  Always open the connection explicitly

                    using (var cmd = new SQLiteCommand("DELETE FROM NIC_Table WHERE NICId = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", NICId);
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
        public List<NICdata> GetNICCheck(string nicNo)
        {
            var nicList = new List<NICdata>();

            using (var conn = DataBasecon.GetConnection())
            {
                const string query = "SELECT NICId, NIC, Role FROM NIC_Table WHERE NIC = @NIC";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIC", nicNo);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nicList.Add(new NICdata
                        {
                            NICId = reader.GetInt32(reader.GetOrdinal("NICId")),
                            NIC = reader.GetString(reader.GetOrdinal("NIC")),
                            Role = reader.GetString(reader.GetOrdinal("Role"))
                        });
                    }
                }
            }

            return nicList;

        }

    }
}
