﻿using C__UnicomManagementSystem.Data;
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
               
            }

            return NIC;
        }
        public string AddNIC(NICdata NICda)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                // Make sure to open the connection
                using (var command = new SQLiteCommand("INSERT INTO NIC_Table (NIC, Role) VALUES (@NIC, @Role)", conn))
                {
                    command.Parameters.AddWithValue("@NIC", NICda.NIC);
                    command.Parameters.AddWithValue("@Role", NICda.Role);
                    command.ExecuteNonQuery();
                }
            }

            //using (var conn = DataBasecon.GetConnection())
            //{
            //    var command = new SQLiteCommand("INSERT INTO NIC_Table (NIC,Role) VALUES (@NIC, @Role)" conn);

            //    command.Parameters.AddWithValue("@NIC", NICdata.NIC);
            //    command.Parameters.AddWithValue("@Role", NICdata.Role);
            //    command.ExecuteNonQuery();

                //string addStudentQuery = "INSERT INTO NIC_Table (NIC,Role) VALUES (@NIC, @Role)";
                //SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);

                //insertStudentCommand.Parameters.AddWithValue("@NIC", NICdata.NIC);
                //insertStudentCommand.Parameters.AddWithValue("@Role", NICdata.Role);

                //insertStudentCommand.ExecuteNonQuery();
            

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
             
                // Optionally log it to a file or UI
            }
        }
        public NICdata GetNICCheck(string nicNo)
        {
          

            using (var conn = DataBasecon.GetConnection())
            {
                const string query = "SELECT NICId, NIC, Role FROM NIC_Table WHERE NIC = @NIC";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIC", nicNo);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new NICdata
                        {
                            NICId = reader.GetInt32(reader.GetOrdinal("NICId")),
                            NIC = reader.GetString(reader.GetOrdinal("NIC")),
                            Role = reader.GetString(reader.GetOrdinal("Role"))
                        };
                    }
                }
            }

            return null;

        }

    }
}
