using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System
{
    public partial class TimetableForm : Form
    {
        private TimetableController timetableController = new TimetableController();
        private int selectedTimetableId = -1;

        public TimetableForm()
        {
            InitializeComponent();

            // Event handlers assign பண்ணுற இடம்
            butADD.Click += butADD_Click;
            butUPDATE.Click += butUPDATE_Click;
            butDELETE.Click += butDELETE_Click;
            timetableGridView.SelectionChanged += timetableGridView_SelectionChanged;

            LoadTimetableData();
        }

        private void LoadTimetableData()
        {
            var timetableList = timetableController.GetAllTimetables();
            timetableGridView.DataSource = null;
            timetableGridView.DataSource = timetableList;

            if (timetableGridView.Columns["TimetableId"] != null)
                timetableGridView.Columns["TimetableId"].Visible = false;
        }

        private void ClearInputs()
        {
            txSubjectId.Clear();
            txTimeSlot.Clear();
            txRoomId.Clear();
            selectedTimetableId = -1;
        }

        private bool ValidateInputs()
        {
            if (!int.TryParse(txSubjectId.Text.Trim(), out _))
            {
                MessageBox.Show("Please enter a valid numeric Subject ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txTimeSlot.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid Time Slot.");
                return false;
            }

            if (!int.TryParse(txRoomId.Text.Trim(), out _))
            {
                MessageBox.Show("Please enter a valid numeric Room ID.");
                return false;
            }

            return true;
        }

        private void butADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                var timetable = new Timetable
                {
                    SubjectId = Convert.ToInt32(txSubjectId.Text.Trim()),
                    TimeSlot = txTimeSlot.Text.Trim(),
                    RoomId = Convert.ToInt32(txRoomId.Text.Trim())
                };

                string result = timetableController.AddTimetable(timetable);
                MessageBox.Show(result);
                LoadTimetableData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void butUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTimetableId == -1)
                {
                    MessageBox.Show("Please select a timetable to update.");
                    return;
                }

                if (!ValidateInputs())
                    return;

                var timetable = new Timetable
                {
                    TimetableId = selectedTimetableId,
                    SubjectId = Convert.ToInt32(txSubjectId.Text.Trim()),
                    TimeSlot = txTimeSlot.Text.Trim(),
                    RoomId = Convert.ToInt32(txRoomId.Text.Trim())
                };

                string result = timetableController.UpdateTimetable(timetable);
                MessageBox.Show(result);
                LoadTimetableData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void butDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTimetableId == -1)
                {
                    MessageBox.Show("Please select a timetable to delete.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete the selected timetable?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string result = timetableController.DeleteTimetable(selectedTimetableId);
                    MessageBox.Show(result);
                    LoadTimetableData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

        private void timetableGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (timetableGridView.SelectedRows.Count > 0)
            {
                var row = timetableGridView.SelectedRows[0];
                if (row.DataBoundItem is Timetable timetable)
                {
                    selectedTimetableId = timetable.TimetableId;
                    txSubjectId.Text = timetable.SubjectId.ToString();
                    txTimeSlot.Text = timetable.TimeSlot;
                    txRoomId.Text = timetable.RoomId.ToString();
                }
            }
        }

        private void txSubjectId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
