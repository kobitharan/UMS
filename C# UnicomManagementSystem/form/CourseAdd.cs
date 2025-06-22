using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__UnicomManagementSystem.form
{
    public partial class CourseAdd : Form
    {
        CourseController _CourseController;
        AddController _AddController;
        private int selectedId = -1;
        public CourseAdd()
        {
            InitializeComponent();

            _CourseController = new CourseController();
            _AddController = new AddController();

            List<string> items = new List<string>() { "Course", "Subject" };
            Selectmodel.DataSource = items;
            
            

            if (Selectmodel.Text == "Course")
            {
                GVLoadCourse();
                Cname.Visible = true;
                Course.Visible = false;
                SubjectName.Visible = false;
                Sname.Visible = false;
            }

            CMBLoadCourse();

        }
        private void ClearInputs()
        {
            Cname.Text = "";
            Sname.Text = "";

        }

        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            Course.DataSource = sections;
            Course.DisplayMember = "CourseName";
            Course.ValueMember = "CourseId";

        }

        private void GVLoadCourse()
        {
            Course course = new Course();
            List<Course> Course = _CourseController.GetAllCourse();//COurse
            dataGridView.DataSource = Course;
            dataGridView.ClearSelection();
            ClearInputs();
            dataGridView.Columns["SubjectId"].Visible = false;
            dataGridView.Columns["SubjectName"].Visible = false;
            selectedId = -1;
        }
        private void GVLoadSubject()
        {
            Course course = new Course();
            List<Course> Course = _CourseController.GetAllSubject();
            dataGridView.DataSource = Course;
            dataGridView.ClearSelection();
            ClearInputs();
            dataGridView.Columns["SubjectId"].Visible = false;
            dataGridView.Columns["CourseId"].Visible = false;
            dataGridView.Columns["SubjectName"].Visible = true;
            selectedId = -1;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CourseandSubject()
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /////// Delete  pannurathu ethu 
            if (Selectmodel.Text == "Course")
            {
                if (string.IsNullOrWhiteSpace(Course.Text))
                {
                    MessageBox.Show("Please Select Delete Course .");
                    return;
                }
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["CourseId"].Value);
                    _CourseController.DeleteCourse(id);
                    GVLoadCourse();
                    CMBLoadCourse();
                }
            }
            else if (Selectmodel.Text == "Subject")
            {
                if (string.IsNullOrWhiteSpace(Sname.Text))
                {
                    MessageBox.Show("Please Select Delete Subject Name .");
                    return;
                }
                if (dataGridView.SelectedRows.Count > 0)
                {
                    object courseValue = dataGridView.SelectedRows[0].Cells["CourseId"].Value;
                    object subjectValue = dataGridView.SelectedRows[0].Cells["SubjectId"].Value;

                    int CourseId = Convert.ToInt32(courseValue);
                    int SubjectId = Convert.ToInt32(subjectValue);

                    //int CourseId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["CourseId"]);
                   // int SubjectId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["SubjectId"]);
                    _CourseController.DeleteSubject(CourseId, SubjectId);
                    GVLoadCourse();
                }
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
          
        }

        private void ADD_Click(object sender, EventArgs e)
        {///// Course and subject add ok........................

         //if (string.IsNullOrWhiteSpace(Sname.Text) || string.IsNullOrWhiteSpace(Cname.Text))
         //{
         //    MessageBox.Show("Entar Ditals");
         //};

            if (Selectmodel.Text == "Course")
            {
                if (!string.IsNullOrWhiteSpace(Cname.Text))
                {
                    Course course = new Course()
                    {
                        CourseName = Cname.Text,
                    };

                    string getMessage = _AddController.AddCourse(course);
                    // geatMessage = _AddController.GetCourse();
                    ClearInputs(); 
                    MessageBox.Show(getMessage);
                    GVLoadCourse();
                }
                else
                {

                    MessageBox.Show("Entar Course  Name");

                }
            };


            if (Selectmodel.Text == "Subject")
            {
                if (!string.IsNullOrWhiteSpace(Sname.Text))
                {
                    Subject subject = new Subject()
                    {
                        SubjectName = Sname.Text,
                        CourseId = Convert.ToInt32(Course.SelectedValue)

                    };

                    string getMessage = _AddController.AddSubject(subject);
                    GVLoadSubject();
                    ClearInputs();
                    MessageBox.Show(getMessage);
                }
                else
                { MessageBox.Show("Entar Subject  Ditals"); }
            };

        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)

            {
                if (Selectmodel.Text == "Course")
                {
                    Cname.Text = dataGridView.SelectedRows[0].Cells["CourseName"].Value.ToString();
                    int CourseId1 = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["CourseId"].Value);
                }
                if (Selectmodel.Text == "Subject")
                {
                    Course.Text = dataGridView.SelectedRows[0].Cells["CourseName"].Value.ToString();
                    Sname.Text = dataGridView.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                  //  int subjectId1 = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["SubjectId"].Value);
                   // int CourseId1 = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["CourseId"].Value);

                }
            }

        }

        private void Change_Click(object sender, EventArgs e)
        {
            //if (selectedId == -1)
            //{
            //    MessageBox.Show("Please select a Course to update.");
            //    return;
            //}
            if (Selectmodel.Text == "Subject")
            {
                if (string.IsNullOrWhiteSpace(Sname.Text))
                {
                    MessageBox.Show("Please Select Course Name and Subject name.");
                    return;
                }

                var Subject = new Subject
                {

                   SubjectId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["SubjectId"].Value),
                    SubjectName = Sname.Text,
                   
                   //CourseId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["CourseId"])
                };

                _CourseController.UpdateSubject(Subject);
                GVLoadSubject();
                ClearInputs();

                MessageBox.Show("Subject Updated Successfully");
            };
        }

        private void Selectmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Selectmodel.Text == "Subject")
            {
                // Sname.Visible = true;
                Cname.Visible = false;
                Delete.Visible = true;
                Course.Visible = true;
                SubjectName.Visible = true;
                Sname.Visible = true;
                CMBLoadCourse();
                GVLoadSubject();
            }

            else if (Selectmodel.Text == "Course")
            {
                GVLoadCourse();

                Cname.Visible = true;
                Course.Visible = false;
                SubjectName.Visible = false;
                Sname.Visible = false;
            }
        }
    }
}
