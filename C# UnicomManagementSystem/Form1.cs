using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.form;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem
{
    public partial class Form1 : Form
    {
       
        private readonly AddController _AddController;
        public Form1()
        {
            _AddController = new AddController();
            InitializeComponent();
          
            CreatAccount.Visible = true ;
            namelabel.Visible = true;
            UserName.Visible = true;
            passwordlabel.Visible = true;
            Password.Visible = true;
            // Loginlabel.Visible = false;
            Login.Visible = true;
            exit.Visible = true;
            LoadAdmin();
            // DateTime

           // DateTimeditals.Text = DateTimeditals.Now.ToString("dd/MM/yyyy\n hh:mm tt");
            DateTimeditals.ForeColor = Color.Blue;
            DateTimeditals.Text = DateTime.Now.ToString("dd/MM/yyyy\n hh:mm:ss");

        }
        public void LoadForm(object formObj)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }
        public void LoadAdmin()
        {
            var Count = LoginController.GetUserCount();
            if (Count == 0)
            {
                MessageBox.Show("HI Admin ... Enter  Your UserName AND  Password  ");

                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CreatAccount_Click(object sender, EventArgs e)
        {
            
            LoadForm( new UsersAdd());
          
            

            CreatAccount.Visible = false;
            namelabel.Visible = false;
            UserName.Visible = false;
            passwordlabel.Visible = false;
            Password.Visible = false;
           // Loginlabel.Visible = false;
            Login.Visible = false;
            exit.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {

           
            
                var Count = LoginController.GetUserCount();
                if (Count == 0 && UserName.Text=="" && Password.Text =="")
                {
                    Staff staff = new Staff
                    {
                        UserName = UserName.Text,
                        Password = Password.Text
                    };

                    _AddController.AdminDitals(staff);

                }
            
            var username = UserName.Text;
            var password = Password.Text;

            var users = LoginController.GetUsers(username, password);

           
            // If no user is found
            if (users == null )
            {
                MessageBox.Show("Please enter correct username and password.");
                return;
            }
            else if (users.Status == "Active")// Active user found Checking status
            {

                string[] name = users.ALLID.Split(' ');
                LoginDitals.Set("LoginID", name[1]);
                LoginDitals.Set("Role", name[0]);
                LoginDitals.Set("username", users.UserName);
                LoginDitals.Set("UserId", users.UserId);
                LoginDitals.Set("Password", users.Password);

                //MessageBox.Show("Your 6565");

               LoadForm(new LoginMenu());

                CreatAccount.Visible = false;
                namelabel.Visible = false;
                UserName.Visible = false;
                passwordlabel.Visible = false;
                Password.Visible = false;
                // Loginlabel.Visible = false;
                Login.Visible = false;
                exit.Visible = false;

            }
            else if (users.Status == "Inactive")
            {
                MessageBox.Show("Your account is inactive. Please contact the administrator.");
            }
            else
            {
                MessageBox.Show("An unexpected error occurred. Please try again later.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void exti_Click(object sender, EventArgs e)
        {
            // Environment.Exit(0);
            // Close the application gracefully
            Application.Exit();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.Controls.Count == 0)
            {
                // Panel is empty
                LoadForm(new Form1());

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
