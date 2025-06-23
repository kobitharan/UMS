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

            // Columns to hide (avoid duplicates)
            string[] hiddenColumns = {
        "MarkId", "ExamId", "StudentId", "LecturerId", "LecturerName",
        "RoomId", "CourseId", "EndTime", "StartTime", "SubjectId", "BatchId","ExamDeteils","date","RoomName"
    };

            foreach (var columnName in hiddenColumns)
            {
                if (ResultGrid.Columns.Contains(columnName))
                    ResultGrid.Columns[columnName].Visible = false;
            }

            // Columns to show
            string[] visibleColumns = { };

            foreach (var columnName in visibleColumns)
            {
                if (ResultGrid.Columns.Contains(columnName))
                    ResultGrid.Columns[columnName].Visible = true;
            }
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
                if (int.TryParse(CourseCB.SelectedValue.ToString(), out int courseId) &&
                    int.TryParse(BatchCB.SelectedValue.ToString(), out int batchId))
                {
                    var studentList = _studentController.GetStudentsByCourseAndBatch(courseId, batchId);

                    StudentCB.DataSource = studentList;
                    StudentCB.DisplayMember = "StudentFullName";
                    StudentCB.ValueMember = "StudentId";
                }
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
            
            int Batch = Convert.ToInt32(BatchCB.SelectedValue);


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
            if (int.TryParse(CourseCB.SelectedValue?.ToString(), out int courseId))
            {
                // SubjectCB க்கு SubjectName லோடு பண்ணுறது
                var subjectList = _courseController.GeSubjectName(courseId);
                SubjectCB.DataSource = subjectList;
                SubjectCB.DisplayMember = "SubjectName";
                SubjectCB.ValueMember = "SubjectId";

                // CourseId கும் BatchId கும் அடிப்படையில Students லோடு பண்ணுறது
                if (int.TryParse(BatchCB.SelectedValue?.ToString(), out int batchId))
                {
                    var studentList = _studentController.GetStudentsByCourseAndBatch(courseId, batchId);
                    StudentCB.DataSource = studentList;
                    StudentCB.DisplayMember = "StudentFullName";
                    StudentCB.ValueMember = "StudentId";
                }
            }


        }
    }
}
