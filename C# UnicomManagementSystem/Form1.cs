using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.form;
using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
                MessageBox.Show("HI Admin ... Your UserName : @Admin Password :Admin ");
                Staff staff = new Staff 
                {
                    UserName ="@Admin",
                    Password= "Admin"
                };

                 _AddController.AdminDitals(staff);
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CreatAccount_Click(object sender, EventArgs e)
        {
            //panel1
            LoadForm( new UsersAdd());
            //UsersAdd frm = new UsersAdd();
            //frm.Show();

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
            var username1 = UserName.Text;
            var password1 = Password.Text;
            
            var users = LoginController.Getusers(username1, password1);
            // LoadForm(new LoginMenu());

            //MessageBox.Show($"Welcome, {users}");
           
           

            if (users == null || users.Count == 0)
            {
                MessageBox.Show("Your correct userName And password Enter pless..  ");
                return;
                   
                }
            else
            {
                foreach (var user in users)
                {
                   // string ALLID = user.ALLID;
                    string[] name= user.ALLID.Split(' ');
                    LoginDitals.Set("LoginID", name[1]);
                    LoginDitals.Set("Role", name[0]);
                    LoginDitals.Set("username", user.UserName);
                    LoginDitals.Set("UserId", user.UserId);
                    LoginDitals.Set("Password", user.Password);

                }
                CreatAccount.Visible = false;
                namelabel.Visible = false;
                UserName.Visible = false;
                passwordlabel.Visible = false;
                Password.Visible = false;
                // Loginlabel.Visible = false;
                Login.Visible = false;
                exit.Visible = false;                   
                LoadForm(new LoginMenu());           
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
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
