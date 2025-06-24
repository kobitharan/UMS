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

    }

}
