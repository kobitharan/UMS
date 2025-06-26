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
    public partial class TimetableMenu : Form
    {
        private readonly StudentController _studentController;
        private readonly CourseController _CourseController;
        private readonly NICADDController _NICADDController;
        private readonly TimetableController _TimetableController;
        private readonly LecturerContoller _LecturerContoller;



        public TimetableMenu()
        {
            _LecturerContoller = new LecturerContoller();
            _studentController = new StudentController();
            _CourseController = new CourseController();
            _NICADDController = new NICADDController();
            _TimetableController = new TimetableController();
            InitializeComponent();

            //Date.Format = DateTimePickerFormat.Custom;
            //Date.CustomFormat = "yyyy-MM-dd ";
            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "yyyy-MM-dd";
            Date.MinDate = DateTime.Today;          // prevents selecting past dates
            Date.Value = DateTime.Today;

            STime.Format = DateTimePickerFormat.Custom;
            STime.CustomFormat = "HH:mm";
            STime.ShowUpDown = true;

            ETime.Format = DateTimePickerFormat.Custom;
            ETime.CustomFormat = "HH:mm";
            ETime.ShowUpDown = true;
            CMBLoadCourse();
            CMBLoadbatch();
            // CMBLoadSubject();
            CMBLoadRoom();
            CMBLoadLecturer();
            TimeTableGV();

        }
        private void TimeTableGV()
        {

            var TimeTable = _TimetableController.GetTimeTableDitals(); // make sure this returns List<Batch>
            dataGridViewTimeTable.DataSource = TimeTable;
            dataGridViewTimeTable.ClearSelection();
            // ClearInputs();
            //  BatchdataGridView();
            dataGridViewTimeTable.Columns["TimeTableId"].Visible = false;
            dataGridViewTimeTable.Columns["Ditals"].Visible = false;
            dataGridViewTimeTable.Columns["SubjectName"].Visible = false;
            dataGridViewTimeTable.Columns["BatchId"].Visible = false;
            dataGridViewTimeTable.Columns["CourseId"].Visible = false;
            dataGridViewTimeTable.Columns["SubjectId"].Visible = false;
            dataGridViewTimeTable.Columns["RoomId"].Visible = false;
            dataGridViewTimeTable.Columns["LecturerId"].Visible = false;
            dataGridViewTimeTable.Columns["RegistrationDate"].Visible = false;


        }
        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            Course.DataSource = sections;
            Course.DisplayMember = "CourseName";
            Course.ValueMember = "CourseId";
            CMBLoadSubject();

        }
        private void CMBLoadRoom()
        {
            var sections = _CourseController.GetAllRoom();
            Room.DataSource = sections;
            Room.DisplayMember = "RoomName";
            Room.ValueMember = "RoomId";

        }
        private void CMBLoadbatch()
        {
            var sections = _CourseController.GetAllBatch();
            BatchCB.DataSource = sections;
            BatchCB.DisplayMember = "BatchName";
            BatchCB.ValueMember = "BatchId";

        }//Subject
        private void CMBLoadLecturer()
        {
            var sections = _LecturerContoller.GetAllLecturer();
            Lecturer.DataSource = sections;
            Lecturer.DisplayMember = "FullName";
            Lecturer.ValueMember = "LecturerId";

        }//Subject
        //private void CMBLoadSubject()
        //{
        //    var sections = _CourseController.GeSubjectName(Convert.ToInt32(Course.SelectedValue));

        //   // var sections = _CourseController.GeSubjectName(Course.Value);
        //    Subject .DataSource = sections;
        //    Subject.DisplayMember = "SubjectName";
        //    Subject.ValueMember = "SubjectId";

        //}
        private void CMBLoadSubject()
        {
            if (Course.SelectedValue != null && int.TryParse(Course.SelectedValue.ToString(), out int courseId))
            {
                var sections = _CourseController.GeSubjectName(courseId);
                Subject.DataSource = sections;
                Subject.DisplayMember = "SubjectName";
                Subject.ValueMember = "SubjectId";
            }
            else
            {
                Subject.DataSource = null;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (BatchCB.SelectedValue == null || Subject.SelectedValue == null ||
                Lecturer.SelectedValue == null || Room.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string startTime = $"{STime}";
            string endTime = $"{ETime}";
            string date = Date.Text;
            int batchId = Convert.ToInt32(BatchCB.SelectedValue);
            int courseId = Convert.ToInt32(Course.SelectedValue);
            int subjectId = Convert.ToInt32(Subject.SelectedValue);
            int roomId = Convert.ToInt32(Room.SelectedValue);
            int lecturerId = Convert.ToInt32(Lecturer.SelectedValue);



            if (_TimetableController.IsTimeOverlapping(date, startTime, endTime, batchId, lecturerId, roomId))
            {
                MessageBox.Show("Time conflict detected! Either Batch, Lecturer, or Room is already assigned during this time.");
                return;
            }


            Timetable time = new Timetable
            {
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                BatchId = batchId,
                CourseId = courseId,
                SubjectId = subjectId,
                RoomId = roomId,
                LecturerId = lecturerId
            };

            string msg = _TimetableController.AddTimeTabble(time);
            MessageBox.Show(msg);
            TimeTableGV();
        }

        private void Subjectbu_Click(object sender, EventArgs e)
        { }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBLoadSubject();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimeTable.SelectedRows.Count > 0)
            {
                int TimeTableID = Convert.ToInt32(dataGridViewTimeTable.SelectedRows[0].Cells["TimeTableId"].Value);
               String TimeTableMsg =_TimetableController.DeleteTimeTable(TimeTableID);
                MessageBox.Show(TimeTableMsg);
                TimeTableGV();
            }
        }

        private void dataGridViewTimeTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTimeTable.SelectedRows.Count > 0)
            {
                 Date.Text = dataGridViewTimeTable.SelectedRows[0].Cells["Date"].Value.ToString();
                 STime.Text = dataGridViewTimeTable.SelectedRows[0].Cells["StartTime"].Value.ToString();
                BatchCB.Text = dataGridViewTimeTable.SelectedRows[0].Cells["BatchName"].Value.ToString();
                 ETime.Text = dataGridViewTimeTable.SelectedRows[0].Cells["EndTime"].Value.ToString();
                Lecturer.Text = dataGridViewTimeTable.SelectedRows[0].Cells["LecturerName"].Value.ToString();
                Course.Text = dataGridViewTimeTable.SelectedRows[0].Cells["CourseName"].Value.ToString();
              //  Subject.Text = dataGridViewTimeTable.SelectedRows[0].Cells["Subject"].Value.ToString();
                Room.Text = dataGridViewTimeTable.SelectedRows[0].Cells["RoomName"].Value.ToString();
            }
        }
    }
}
