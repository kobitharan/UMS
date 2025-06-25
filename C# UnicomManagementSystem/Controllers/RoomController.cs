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
    internal class RoomController
    {
        public List<Room > GetAllRooms()
        {
            var room = new List<Room >();

            try
            {
                using (var conn = DataBasecon.GetConnection())
                {
                    // Always explicitly open connection

                    const string query = "SELECT RoomId,RoomName FROM Room_Table";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Room = new Room 
                            {
                                RoomId = reader.GetInt32(reader.GetOrdinal("RoomId")),
                                RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                              
                            };

                            room.Add(Room );

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: Log the error, or rethrow with custom message
                Console.WriteLine("Error loading courses: " + ex.Message);
            }

            return room ;
        }
        public string AddRoom(Room room)
        {

            using (var conn = DataBasecon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Room_Table (RoomName) VALUES (@name)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, conn);
                insertStudentCommand.Parameters.AddWithValue("@name", room.RoomName);

                insertStudentCommand.ExecuteNonQuery();
            }

            return "Course Added Successfully!";
        }
        public string  DeleteRoom(Room room)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                try
                {
                   
                    var command = new SQLiteCommand("DELETE FROM Room_Table WHERE RoomId = @Id", conn);
                    command.Parameters.AddWithValue("@Id", room.RoomId);
                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                        return "Deleted Successfully!";
                    else
                        return "Room not found!";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }
    }
}
