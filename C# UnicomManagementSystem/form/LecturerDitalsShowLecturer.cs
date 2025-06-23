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
            try
            {
                int lecturerId = Convert.ToInt32(LoginDitals.Get("LoginID"));
                var lecturer = _LecturerContoller.GetLecturerById(lecturerId);

                if (lecturer != null)
                {
                    LecturerDitalsShow.Text =
       "👨 Name           : " + lecturer.FullName + Environment.NewLine +
       "🆔 NIC            : " + lecturer.NIC + Environment.NewLine +
       "🏠 Address        : " + lecturer.Address + Environment.NewLine +
       "📞 Contact No.    : " + lecturer.ContactNO + Environment.NewLine +
       "📚 Specialization : " + lecturer.Specialization;

                }
                else
                {
                    MessageBox.Show("Lecturer details not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lecturer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

