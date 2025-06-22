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
    public partial class ExamResultADD : Form
    {
        public ExamResultADD()
        {
            InitializeComponent();
            LoadExamResults();
            ExamResultForm_Load();
        }
        private void LoadExamResults()
        {
            var results = _examController.GetAllExamResults();
            ResultGrid.DataSource = results;
            ResultGrid.ClearSelection();
            ResultGrid.Columns["MarkId"].Visible = false;
            ResultGrid.Columns["ExamId"].Visible = false;
            ResultGrid.Columns["StudentId"].Visible = false;
            ResultGrid.Columns["LecturerId"].Visible = false;
            ResultGrid.Columns["RoomId"].Visible = false;
            ResultGrid.Columns["CourseId"].Visible = false;
            ResultGrid.Columns["EndTime"].Visible = false;
            ResultGrid.Columns["StartTime"].Visible = false;
            ResultGrid.Columns["Ditals"].Visible = false;
            ResultGrid.Columns["RoomName"].Visible = false;
            ResultGrid.Columns["BatchId"].Visible = false;
            ResultGrid.Columns["Date"].Visible = false;
            ResultGrid.Columns["SubjectId"].Visible = false;
            ResultGrid.Columns["RoomName"].Visible = false;
            ResultGrid.Columns["BatchId"].Visible = false;


        }

        private readonly ExamController _examController = new ExamController();
        private readonly StudentController _studentController = new StudentController();
        private readonly CourseController _courseController = new CourseController();

        private void ExamResultForm_Load()
        {  // Load Batches
            var batchList = _courseController.GetAllBatch();
            BatchCB.DataSource = batchList;
            BatchCB.DisplayMember = "BatchName";
            BatchCB.ValueMember = "BatchId";

            // Load Courses
            var courseList = _courseController.GetAllCourse();
            CourseCB.DataSource = courseList;
            CourseCB.DisplayMember = "CourseName";
            CourseCB.ValueMember = "CourseId";
            // Load subjects for selected course

           


          
            // Load Exams
            var examList = _examController.GetAllExams();
            ExamCB.DataSource = examList;
            ExamCB.DisplayMember = "Ditals";
            ExamCB.ValueMember = "ExamId";
           
        }
       

        private void BatchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseCB.SelectedValue != null && BatchCB.SelectedValue != null)
            {
                int courseId = Convert.ToInt32(CourseCB.SelectedValue);
                int batchId = Convert.ToInt32(BatchCB.SelectedValue);
                var studentList = _studentController.GetStudentsByCourseAndBatch(courseId, batchId);

                StudentCB.DataSource = studentList;
                StudentCB.DisplayMember = "StudentFullName";
                StudentCB.ValueMember = "StudentId";
            }
        }

        private void AddResutltBtn_Click(object sender, EventArgs e)
        {
            if (StudentCB.SelectedValue == null || ExamCB.SelectedValue == null || CourseCB.SelectedValue == null)
            {
                MessageBox.Show("Please select all fields.");
                return;
            }

            if (!int.TryParse(MarkTB.Text, out int mark))
            {
                MessageBox.Show("Enter a valid mark.");
                return;
            }

            string rank = RankTB.Text;
            int studentId = Convert.ToInt32(StudentCB.SelectedValue);
            int examId = Convert.ToInt32(ExamCB.SelectedValue);
            int courseId = Convert.ToInt32(CourseCB.SelectedValue);
            int subjectId = Convert.ToInt32(SubjectCB.SelectedValue);
            int Batch = Convert.ToInt32(BatchCB.ValueMember);

            Exam result = new Exam
            {
                Mark = mark,
                Rank = rank,
                ExamId = examId,
                StudentId = studentId,
                CourseId = courseId,
                 SubjectId = subjectId,
                 BatchId  = Batch,
            };

            string message = _examController.AddExamResult(result);
            MessageBox.Show(message);
            LoadExamResults();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BatchCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ExamResultForm_Load();
            if (CourseCB.SelectedValue != null && BatchCB.SelectedValue != null)
            {
                int courseId = Convert.ToInt32(CourseCB.SelectedValue);
                int batchId = Convert.ToInt32(BatchCB.SelectedValue);
                var studentList = _studentController.GetStudentsByCourseAndBatch(courseId, batchId);

                StudentCB.DataSource = studentList;
                StudentCB.DisplayMember = "StudentFullName";
                StudentCB.ValueMember = "StudentId";
            }

        }

        private void CourseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseCB.SelectedValue is int courseId)
            {
                var subjectList = _courseController.GeSubjectName(courseId);

             //   subjectList.Insert(0, new Subject { SubjectId = 0, SubjectName = "-- Select Subject --" });

                SubjectCB.DataSource = subjectList;
                SubjectCB.DisplayMember = "SubjectName";
                SubjectCB.ValueMember = "SubjectId";
            }
           

        }
    }
}
