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
    internal class UsersContoller
    {
        public void UpdateUserTable(User user)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var command = new SQLiteCommand(@"
            UPDATE Users_Table 
            SET UserName = @UserName,
                Password = @Password,
                Status = @Status 
            WHERE UserId = @UserId", conn); // ALWAYS use WHERE to target specific row

                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Status", user.Status);
                command.Parameters.AddWithValue("@ALLID", user.ALLID);
                command.Parameters.AddWithValue("@UserId", user.UserId); // Don't forget!

                command.ExecuteNonQuery();
            }
        }

    
    public User GetUserByUserName(string username)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                const string query = "SELECT UserId, UserName, Password, Status, ALLID FROM Users_Table WHERE UserName = @UserName";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                        return new User
                        {
                            UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            UserName = reader.GetString(reader.GetOrdinal("UserName")),
                            Password = reader.GetString(reader.GetOrdinal("Password")),
                            Status = reader.GetString(reader.GetOrdinal("Status")),
                            ALLID = reader.GetString(reader.GetOrdinal("ALLID"))
                        };
                    }
                }
            }

            return null; // No user found
        }
   

    }
}