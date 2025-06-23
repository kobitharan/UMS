using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__UnicomManagementSystem.form
{
    public partial class ExamMenu : Form
    {
        CourseController _CourseController;
        AddController _AddController;
        ExamController _ExamController;
        public ExamMenu()
        {
            InitializeComponent();
            _ExamController = new ExamController();
            _CourseController = new CourseController();
            _AddController = new AddController();
            CMBLoadbatch();
            CMBLoadCourse();
            CMBLoadRoom();
            CMBLoadCourse();
            EDate.Format = DateTimePickerFormat.Custom;
            EDate.CustomFormat = "yyyy-MM-dd ";


            ETime.Format = DateTimePickerFormat.Custom;
            ETime.CustomFormat = "HH:mm";
            ETime.ShowUpDown = true;

            STime.Format = DateTimePickerFormat.Custom;
            STime.CustomFormat = "HH:mm";
            STime.ShowUpDown = true;
            EXAMGV();
        }
        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            ECourse.DataSource = sections;
            ECourse.DisplayMember = "CourseName";
            ECourse.ValueMember = "CourseId";
            CMBLoadSubject();
        }


        private void CMBLoadRoom()
        {
            var sections = _CourseController.GetAllRoom();
            ERoom.DataSource = sections;
            ERoom.DisplayMember = "RoomName";
            ERoom.ValueMember = "RoomId";

        }
        private void CMBLoadbatch()
        {
            var sections = _CourseController.GetAllBatch();
            EBatch.DataSource = sections;
            EBatch.DisplayMember = "BatchName";
            EBatch.ValueMember = "BatchId";

        }//Subject
        private void CMBLoadSubject()
        {

            var sections = _CourseController.GeSubjectName(Convert.ToInt32(ECourse.SelectedValue));
            ESubject.DataSource = sections;
            ESubject.DisplayMember = "SubjectName";
            ESubject.ValueMember = "SubjectId";

        }
        private void EXAMGV()
        {
            var exams = _ExamController.GetAllExam(); // List<Exam> expected
            Examdata.DataSource = exams;
            Examdata.ClearSelection();

            // Hide unwanted columns safely
            string[] hiddenColumns = {
    "CourseId", "BatchId", "SubjectId", "StudenId", "StudentName",
    "ExamDetails", "RoomId", "Rank", "LecturerId", "LecturerName",
    "ExamId", "MarkId", "Mark", "ExamName"
};

            foreach (string col in hiddenColumns)
            {
                if (Examdata.Columns.Contains(col))
                {
                    Examdata.Columns[col].Visible = false;
                }
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExamMenu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EADD_Click(object sender, EventArgs e)
        {

           
                if (ESubject.SelectedValue == null || EBatch.ValueMember == null || ERoom.ValueMember == null || ECourse.ValueMember == null)
                {
                    // MessageBox.Show(STime.Text);   // Text as string


                    //  int qstartTime = Convert.ToInt32(STime.Text);
                    MessageBox.Show("Select  Time Table Ditals");

                    return;
                }


            string startTime = $"{STime.Value.Hour:D2}:{STime.Value.Minute:D2}";
            string EndTime = $"{ETime.Value.Hour:D2}:{ETime.Value.Minute:D2}";
            int BatchId = Convert.ToInt32(EBatch.SelectedValue);
                int CourseId = Convert.ToInt32(ECourse.SelectedValue);
                int SubjectId = Convert.ToInt32(ESubject.SelectedValue);
                int RoomId = Convert.ToInt32(ERoom.SelectedValue);
                // int LecturerId = Convert.ToInt32(Lecturer.SelectedValue);
                Exam time1 = new Exam 
                {
                    Date = EDate.Text,
                    Ditals = Ditals.Text,

                    StartTime = startTime,
                    EndTime = EndTime,
                    BatchId = BatchId,
                    CourseId = CourseId,
                    SubjectId = SubjectId,
                    RoomId = RoomId
                };
              
                String Timem = _ExamController.AddExam(time1);
                MessageBox.Show(Timem);
                EXAMGV();
            }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Examdata
            if (Examdata.SelectedRows.Count > 0)
            {

                ERoom.Text = Examdata.SelectedRows[0].Cells["RoomName"].Value.ToString();
                EBatch.Text = Examdata.SelectedRows[0].Cells["BatchName"].Value.ToString();
                Ditals.Text = Examdata.SelectedRows[0].Cells["Ditals"].Value.ToString();
                ECourse.Text = Examdata.SelectedRows[0].Cells["CourseName"].Value.ToString();
                ESubject.Text = Examdata.SelectedRows[0].Cells["SubjectName"].Value.ToString();

            }
        }

        private void EDelete_Click(object sender, EventArgs e)
        {
            //DeleteButton
            if (string.IsNullOrWhiteSpace(ERoom.Text)|| string.IsNullOrWhiteSpace(EBatch.Text) || string.IsNullOrWhiteSpace(Ditals.Text) || string.IsNullOrWhiteSpace(ECourse.Text))
            {
                MessageBox.Show("Please Select Delete NIC .");
                return;
            }
            if (Examdata.SelectedRows.Count > 0)
            {
                int Examid = Convert.ToInt32(Examdata.SelectedRows[0].Cells["ExamId"].Value);
                _ExamController.ExamDelete(Examid);
                MessageBox.Show("EXAM DATE Delete Successfully!");
                EXAMGV();

            }
        }
    }
}
