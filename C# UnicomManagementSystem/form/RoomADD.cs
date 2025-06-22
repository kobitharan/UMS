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
    public partial class RoomADD : Form
    {
        RoomController _RoomController;
        AddController _AddController;
        public RoomADD()
        {
            InitializeComponent();
            _RoomController = new RoomController();
            _AddController = new AddController();
            RoomdGV();
        }
      
        private void RoomdGV()
        {
            Room  roomName = new Room ();
            List<Room > room1 = _RoomController.GetAllRooms();
            dataShow.DataSource = room1 ;
            dataShow.ClearSelection();

        }
        private void ADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RoomName.Text))
            {
                Room room = new Room ();    
                room.RoomName = RoomName.Text;

                string getMessage = _RoomController.AddRoom(room);
                MessageBox.Show(getMessage);
                RoomdGV();
                RoomName.Clear();
            }
            else
            {
                MessageBox.Show("Enter Room Name . ");
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RoomName.Text))
            {
                Room room = new Room();
                room.RoomName = RoomName.Text;

                string getMessage = _RoomController.UpdateRoom(room);
                MessageBox.Show(getMessage);
                RoomdGV();
                RoomName.Clear();

                //  string getMessage = _AddController.UpdateRoom(room);
                // MessageBox.Show(getMessage);
                // RoomdGV();
            }
        }
    }
}
