using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__UnicomManagementSystem.form
{
    public partial class GetDataShow : Form
    {
        AddController _AddController;
        UsersContoller _UsersContoller;
        public GetDataShow()
        {
            _UsersContoller = new UsersContoller(); 
            _AddController = new AddController();   
         
            InitializeComponent();
            StaffSelectGV();
            ActiveORDeactive.Items.AddRange(new string[] { "Active", "Deactive" });
        }
        //UsersDetalspanel
        private void StaffSelectGV()
        {

            var Data = _AddController.GetAllUsersDetals(); // make sure this returns List<Batch>
            UsersDetals.DataSource = Data;
            UsersDetals.ClearSelection();
            
        }
        private void ClearInputs()
        {

            Usernamess.Clear ();    
            Password.Clear();   


        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Usernamess.Text)&& string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please File tha ditals.");
                return;
            }

            var User  = new User 
            {

                UserId = Convert.ToInt32(UsersDetals.SelectedRows[0].Cells["UserId"].Value),
                UserName = Usernamess.Text,
                Password = Password.Text,
                Status = ActiveORDeactive.Text,

            };
            _UsersContoller.UpdateUserTable(User);


            ClearInputs();
            StaffSelectGV();
            MessageBox.Show(" Updated Successfully");
        }
    }
}
