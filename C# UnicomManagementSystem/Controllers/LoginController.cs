using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.Controllers
{
    internal class LoginController
    {
        public static User GetUsers(string username, string password)
        {
            User user = null;

            using (var conn = DataBasecon.GetConnection())
            {
               
                using (var cmd = new SQLiteCommand(@"
            SELECT UserId, UserName, Password, Status, ALLID 
            FROM Users_Table 
            WHERE UserName = @UserName AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Password = reader.GetString(2),
                                Status = reader.GetString(3),
                                ALLID = reader.GetString(4)
                            };
                        }
                    }
                }
            }

            return user;
        }

        public static int GetUserCount()
        {
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users_Table", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
        public bool IsUserNameExists(string username)
        {
            using (var conn = DataBasecon.GetConnection())
            {
                string query = @"
            SELECT COUNT(*) FROM (
                SELECT UserName FROM Users_Table
                UNION
                SELECT UserName FROM AddStudent_Table
                UNION
                SELECT UserName FROM Add_Table
            )
            WHERE UserName = @UserName";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


    }
}
