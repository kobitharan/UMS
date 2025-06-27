using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.Controllers.EmailSend
{
    internal class UserController
    {
       
            //public void AddUserAndSendEmail(User user)
            //{
            //    using (var conn = DataBasecon.GetConnection())
            //    {
            //        string query = "INSERT INTO Users (UserName, Email) VALUES (@UserName, @Email)";
            //        var cmd = new SQLiteCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@UserName", user.UserName);
            //        cmd.Parameters.AddWithValue("@Email", user.Email);
            //        cmd.ExecuteNonQuery();
            //    }

            //    EmailController emailController = new EmailController();
            //    emailController.SendEmail(
            //        user.Email,
            //        $"வணக்கம் {user.UserName}",
                   
            //    );
            //}
        
    }
}
