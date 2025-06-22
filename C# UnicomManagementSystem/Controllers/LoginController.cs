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
        public static List<User> Getusers(string username,string password )
        {
            var users = new List <User>();
            using(var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                SELECT *
                FROM Users_Table
                WHERE UserName =@UserName AND Password=@Password
                ",conn);
                cmd.Parameters.AddWithValue("@UserName",username);
                cmd.Parameters.AddWithValue("@Password", password);
                var reader = cmd.ExecuteReader();
               int Count = 0;
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Status = reader.GetString(3),
                        ALLID = reader.GetString(4),
                       

                    };
                    users.Add(user);
                   
                }
               // if (user.UserId == null )
                 return users;
            }
          
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

    }
}
