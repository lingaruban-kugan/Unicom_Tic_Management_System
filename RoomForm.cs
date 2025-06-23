using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Data;

namespace Unicom_Tic_Management_System
{
    public partial class RoomForm : Form
    {
        private RoomController roomController = new RoomController();
        int selectedRoomID = -1;
        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
        }
        private void LoadRooms()
        {
            List<Room> rooms = roomController.GetAllRooms();
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = rooms;
        }

        private void Roomnametx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = txtRoomType.Text.Trim();

            if (string.IsNullOrEmpty(roomName) || string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Please enter both Room Name and Room Type.");
                return;
            }

            roomController.AddRoom(roomName, roomType);
            MessageBox.Show("Room added successfully.");

            ClearForm();
            LoadRooms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
                string result = roomController.DeleteRoom(roomId);
                MessageBox.Show(result);

                LoadRooms();
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
        }
        private void ClearForm()
        {
            txtRoomName.Text = "";
            txtRoomType.Text = "";
        }
        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }

        private void RoomgvSelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                var row = dgvRooms.SelectedRows[0];
                var roomView = row.DataBoundItem as Room;

                if (roomView != null)
                {
                    selectedRoomID = roomView.RoomID;
                    var room = roomController.GetRoomById(selectedRoomID);
                    if (room != null)
                    {
                        txtRoomName.Text = room.RoomName;
                        txtRoomType.Text = room.RoomType;
                    }
                }
            }
            else
            {
                ClearForm();
                //selectedRoomID = -1;
            }

        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
