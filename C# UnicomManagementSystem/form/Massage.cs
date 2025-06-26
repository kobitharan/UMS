using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.Controllers.EmailSend;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace C__UnicomManagementSystem.form
{
    public partial class Massage : Form
    {
       
        private readonly EmailController _emailController;
        public Massage()
        {
            InitializeComponent();
            _emailController = new EmailController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        
                MailUser newUser = new MailUser
                {
                    UserName = n,
                    Email = email
                };

           
            userController.AddUserAndSendEmail(user);


        }

        private void Massage_Load(object sender, EventArgs e)
        {

        }
    }
}
