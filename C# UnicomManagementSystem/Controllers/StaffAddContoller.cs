using C__UnicomManagementSystem.Data;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.Controllers
{
    internal class StaffAddContoller
    {
        public List<Staff> GetAllADDTable(String name)
        {
           
            var staff = new List<Staff>();
            using (var conn = DataBasecon.GetConnection())
            {
                var cmd = new SQLiteCommand(@" 
                    SELECT  AddId,Name,NIC,Address,ContactNO,Role,UserName,Password ,Specialization 
                    FROM Add_Table 
                    WHERE Role = @Role", conn);
                cmd.Parameters.AddWithValue("@Role", name);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Staff staffs = new Staff
                    {
                        AddId = reader.GetInt32(reader.GetOrdinal("AddId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        NIC = reader.GetString(reader.GetOrdinal("NIC")),
                        ContactNO = reader.GetString(reader.GetOrdinal("ContactNO")),
                        Address = reader.GetString(reader.GetOrdinal("Address")),
                        Role = reader.GetString(reader.GetOrdinal("Role")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                        Password = reader.GetString(reader.GetOrdinal("Password")),
                        Specialization = reader.GetString(reader.GetOrdinal("Specialization"))
                    };

                    staff.Add(staffs);
                }
            }

            return staff;
        }
        public void DeleteAddtable(int Id)//Delete courss -----
        {
            
                using (var conn = DataBasecon.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Add_Table WHERE AddId = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id",Id);
                    cmd.ExecuteNonQuery();

                }
            }
           

    }
}
