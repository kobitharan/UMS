using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.Controllers.EmailSend;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    
    public partial class Massage : Form
    {
        private readonly UsersContoller _UsersContoller;
        private readonly EmailController _emailController;
        public Massage()
        {
            _UsersContoller = new UsersContoller(); 
            InitializeComponent();
            _emailController = new EmailController();
            CMBLodeStudenMail();
            datagritView.Text = "Dear Friend,\n\nThank you for using the Unicom TIC System.\n\n\n\nEdit\n \n\nRegards,\nUnicom TIC Team";
           
            List<string> items = new List<string>() { "Student", "Lecturer", "Staff", "Manager", "Admin" };
            // RoleComboBox.Items.AddRange(items.ToArray());
            StudentName.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        
            //    MailUser newUser = new MailUser
            //    {
            //        UserName = n,
            //        Email = email
            //    };

           
            //userController.AddUserAndSendEmail(user);


        }
        private void CMBLodeStudenMail()
        {
            var sections = _UsersContoller.GetAllEmailname();
            StudentMail.DataSource = sections;
            StudentMail.DisplayMember = "UserName";
            StudentMail.ValueMember = "UserId";

        }
        private void CMBLodeStudenName()
        {
            var sections = _UsersContoller.GetAllEmailname();
            StudentMail.DataSource = sections;
            StudentMail.DisplayMember = "UserName";
            StudentMail.ValueMember = "UserId";

        }
        private void Massage_Load(object sender, EventArgs e)
        {

        }

        private void SendMessagebutton_Click(object sender, EventArgs e)// 
        {
            
            try
            {
                var selectedUser = StudentMail.SelectedItem as User;
                if (selectedUser == null)
                {
                    MessageBox.Show("Please select a user.");
                    return;
                }

                string to = selectedUser.UserName;
                string subject = "Welcome to Our System!";
                string message = datagritView.Text; 

                string result = _emailController.SendEmail(to, subject, message);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid email address before sending.");

            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            datagritView.Clear();
            datagritView.Text = "Dear Friend,\n\nThank you for using the Unicom TIC System.\n\n\n\nEdit\n \n\nRegards,\nUnicom TIC Team";


        }
    }
}
