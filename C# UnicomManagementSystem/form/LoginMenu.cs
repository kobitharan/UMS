using C__UnicomManagementSystem.models;
using C__UnicomManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__UnicomManagementSystem.form
{
    public partial class LoginMenu : Form
    {
        LoginDitals _LoginDitals;
        public LoginMenu()
        {
            _LoginDitals =new LoginDitals();
            InitializeComponent();

            Selectuser();

        }
        public void Selectuser()
        {
            string Role = LoginDitals.Get("Role") as string;

            //  MessageBox.Show($"Welcome, {Role}");
            if (Role == "Student")
            {
             //  EXamResulADD.Visible = false ;
                Exam.Visible = false;
                TimeTable.Visible = false;
                BatchADD.Visible = false;
                CourseSubjectADD.Visible = false;
                ClassroomAdd.Visible = false;
                Staff.Visible = false;
              //  NICADD.Visible = false;
             //  ADDSTAFF.Visible = false;
                Manager.Visible = false;
                managerAdd.Visible = false;
                Lecturer.Visible = false;
                
                LoadForm(new STUDENT());
            }

            if (Role == "Staff")
            {
              //  EXamResulADD.Visible = true;
                Exam.Visible = true;
                TimeTable.Visible = true;
                BatchADD.Visible = true;
                CourseSubjectADD.Visible = true;
                ClassroomAdd.Visible = true;
                Staff.Visible = true;
              //  NICADD.Visible = false;
              //  ADDSTAFF.Visible = false;
                Manager.Visible = false;
                managerAdd.Visible = false;
                Lecturer.Visible = false;

                LoadForm(new menuStaff());
            }

            if (Role == "Lecturer")
            {
              //  EXamResulADD.Visible = true;
                Lecturer.Visible = true;
                Exam.Visible = true;
                TimeTable.Visible = true;
                BatchADD.Visible = false;
                CourseSubjectADD.Visible = false;
                ClassroomAdd.Visible = false;
                Staff.Visible = false;
              //  NICADD.Visible = false;
             //   ADDSTAFF.Visible = false;
                Manager.Visible = false;
                managerAdd.Visible = false;
               
                LoadForm(new LecturerMenu());//LecturerMenu
            } if (Role == "Manager")
            {
             //   EXamResulADD.Visible = true;
                Exam.Visible = true;
                TimeTable.Visible = true;
                BatchADD.Visible = true;
                CourseSubjectADD.Visible = true;
                ClassroomAdd.Visible = true;
                Staff.Visible = true;
              //  NICADD.Visible = true;
              //  ADDSTAFF.Visible = true;
                Manager.Visible = true;
                Lecturer.Visible = true;
                managerAdd.Visible = false;
               
                LoadForm(new LecturerMenu());//LecturerMenu
            }

            if (Role == "Admin")
            {
               // EXamResulADD.Visible = true;
                Exam.Visible = true;
                TimeTable.Visible = true;
                BatchADD.Visible = true;
                CourseSubjectADD.Visible = true;
                ClassroomAdd.Visible = true;
                Staff.Visible = true;
               // NICADD.Visible = true;
              //  ADDSTAFF.Visible = true;
                Manager.Visible = true;
                managerAdd.Visible = true;
                Lecturer.Visible = true;
            }
                

        }
       
        public void LoadForm(object formObj)
        {
            if (this.datapanel.Controls.Count > 0)
            {
                this.datapanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.datapanel.Controls.Add(form);
            this.datapanel.Tag = form;
            form.Show();
        } 
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Staff
            LoadForm(new menuStaff());

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
           
        }

        private void NIC_ADD_Click(object sender, EventArgs e)
        {
            LoadForm(new NICAddForm());
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            LoadForm(new STUDENT());
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerMenu()); //lectu
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadForm(new STUDENT());
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
         
           
                    Close();
               
           


        }

        private void button9_Click(object sender, EventArgs e)
        {
            // TimetableMenu
            LoadForm(new TimetableMenu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamMenu());//Exam
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Batch());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            LoadForm(new CourseAdd());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomADD());
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadForm(new AddStaff());
        }

        private void managerAdd_Click(object sender, EventArgs e)
        {
            LoadForm(new AddStaff());
           
        }

        private void Lecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerMenu());
           

        }

        private void EXamResulADD_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamResultADD());

        }

        private void Manager_Click(object sender, EventArgs e)
        {
            LoadForm(new ManagerForm());

        }
    }
}
