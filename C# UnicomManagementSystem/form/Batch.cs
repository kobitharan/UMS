using C__UnicomManagementSystem.Controllers;
using C__UnicomManagementSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__UnicomManagementSystem.form
{
    public partial class Batch : Form
    {
        BatchController _BatchController;
        CourseController _CourseController;
        public Batch()
        {
            _BatchController = new BatchController();
            _CourseController = new CourseController();

            InitializeComponent();
            BatchGV();
            CMBLoadCourse();
        }
        private void BatchGV()
        { 

             var batches = _BatchController.GetAllBatch(); // make sure this returns List<Batch>
              BatchdataGRV.DataSource = batches;
              BatchdataGRV.ClearSelection();
           // ClearInputs();
            //  BatchdataGridView();
            BatchdataGRV.Columns["CourseId"].Visible = false;
            BatchdataGRV.Columns["BatchId"].Visible = false;
            // selectedId = -1;
        }
        private void Cleardata()
        {
            BatchYear.Clear();
            StartDate.Clear();  
            Enddate.Clear();

        }

     private void button1_Click(object sender, EventArgs e)
        {
            //Batch ADD pannurathu-----------------

            Batches Batch = new Batches()
            {
                BatchName = BatchYear.Text,
               StartDate= StartDate.Text,
                EndDate =Enddate.Text,
               // CourseName= Courses.Text,
                CourseId = Convert.ToInt32(Courses.SelectedValue)

            };
            string getMessage = _BatchController.AddBatch(Batch);
            MessageBox.Show(getMessage);
            BatchGV();
            Cleardata();
        }

        private void BatchdataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) 
        {
            if (BatchdataGRV.SelectedRows.Count > 0)
            {

            BatchYear.Text = BatchdataGRV.SelectedRows[0].Cells["BatchName"].Value.ToString();
            StartDate.Text = BatchdataGRV.SelectedRows[0].Cells["StartDate"].Value.ToString();
            Enddate.Text = BatchdataGRV.SelectedRows[0].Cells["EndDate"].Value.ToString();
            Courses.Text = BatchdataGRV.SelectedRows[0].Cells["CourseName"].Value.ToString();


            //int BatchId = Convert.ToInt32(BatchdataGRV.SelectedRows[0].Cells["BatchId"].Value);
          //  int CourseId1 = Convert.ToInt32(BatchdataGRV.SelectedRows[0].Cells["CourseId"].Value);


            }
        }
        private void CMBLoadCourse()
        {
            var sections = _CourseController.GetAllCourse();
            Courses.DataSource = sections;
            Courses.DisplayMember = "CourseName";
            Courses.ValueMember = "CourseId";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Courses
          
        }

        private void BatchdataGRV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (BatchdataGRV.SelectedRows.Count > 0)
            //{

            //    BatchYear.Text = BatchdataGRV.SelectedRows[0].Cells["BatchYear"].Value.ToString();
            //    StartDate.Text = BatchdataGRV.SelectedRows[0].Cells["StartDate"].Value.ToString();
            //    Enddate.Text = BatchdataGRV.SelectedRows[0].Cells["EndDate"].Value.ToString();
            //    Courses.Text = BatchdataGRV.SelectedRows[0].Cells["CourseName"].Value.ToString();


            //   // int BatchId = Convert.ToInt32(BatchdataGRV.SelectedRows[0].Cells["BatchId"].Value);
            //   // int CourseId1 = Convert.ToInt32(BatchdataGRV.SelectedRows[0].Cells["CourseId"].Value);


            //}

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (BatchdataGRV.SelectedRows.Count > 0)
            {
                Batches batch = new Batches
                {
                    BatchId = Convert.ToInt32(BatchdataGRV.SelectedRows[0].Cells["BatchId"].Value)
                };
                string getMessage = _BatchController.DeleteBatch(batch);
                MessageBox.Show(getMessage);
                BatchGV();
                Cleardata();
            }
            else
            {
                MessageBox.Show("Please select a batch to delete.");

            }
        }

        private void BatchdataGRV_SelectionChanged(object sender, EventArgs e)
        {
            if (BatchdataGRV.SelectedRows.Count > 0)
            {

                BatchYear.Text = BatchdataGRV.SelectedRows[0].Cells["BatchName"].Value.ToString();
                StartDate.Text = BatchdataGRV.SelectedRows[0].Cells["StartDate"].Value.ToString();
                Enddate.Text = BatchdataGRV.SelectedRows[0].Cells["EndDate"].Value.ToString();
                Courses.Text = BatchdataGRV.SelectedRows[0].Cells["CourseName"].Value.ToString();
                Courses.Text = BatchdataGRV.SelectedRows[0].Cells["CourseName"].Value.ToString();

            }
        }

        private void Batch_Load(object sender, EventArgs e)
        {

        }
    }
}
