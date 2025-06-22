using C__UnicomManagementSystem.Controllers;
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

namespace C__UnicomManagementSystem.form
{
    public partial class LecturerDitalsShowLecturer : Form
    {
        LecturerContoller _LecturerContoller;
        public LecturerDitalsShowLecturer()
        {
            _LecturerContoller = new LecturerContoller();
            InitializeComponent();
            LecturerTableDitals();
        }
        private void LecturerTableDitals()
        {
            int lecturerId = Convert.ToInt32(LoginDitals.Get("LecturerId"));
            var lecturerList = _LecturerContoller.GetAllLecturerDitals(lecturerId);

            if (lecturerList != null && lecturerList.Count > 0)
            {
                var lecturer = lecturerList[0];

                LecturerDitalsShow.Text =
                    $"Name: {lecturer.FullName}\r\n" +
                    $"NIC: {lecturer.NIC}\r\n" +
                    $"Address: {lecturer.Address}\r\n" +
                    $"Contact: {lecturer.ContactNO}\r\n" +
                    $"Specialization: {lecturer.Specialization}";
            }
            else
            {
                LecturerDitalsShow.Text = "No lecturer data found.";
            }

        }
    }
}
