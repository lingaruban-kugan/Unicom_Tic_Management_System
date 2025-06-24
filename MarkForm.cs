using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System
{
    public partial class MarkForm : Form
    {
        private MarkController _markController = new MarkController();
        private StudentController _studentController = new StudentController();
        private ExamController _examController = new ExamController();

        private int selectedMarkId = -1;

        public MarkForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadExams();
            LoadMarks();
            ClearForm();
        }

        private void LoadStudents()
        {
            var students = _studentController.GetAllStudents();
            comboStudent.DataSource = students;
            comboStudent.DisplayMember = "Name";    // Your Student model property
            comboStudent.ValueMember = "StudentId";
            comboStudent.SelectedIndex = -1;
        }

        private void LoadExams()
        {
            var exams = _examController.GetAllExams();
            comboExam.DataSource = exams;
            comboExam.DisplayMember = "ExamName";   // Your Exam model property
            comboExam.ValueMember = "ExamId";
            comboExam.SelectedIndex = -1;
        }

        private void LoadMarks()
        {
            var marks = _markController.GetAllMarks();
            dgvMarks.DataSource = null;
            dgvMarks.DataSource = marks;

            // Hide MarkId column if you want
            if (dgvMarks.Columns["MarkId"] != null)
                dgvMarks.Columns["MarkId"].Visible = false;

            dgvMarks.ClearSelection();
        }

        private void ClearForm()
        {
            comboStudent.SelectedIndex = -1;
            comboExam.SelectedIndex = -1;
            txtScore.Clear();
            selectedMarkId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboStudent.SelectedIndex == -1 || comboExam.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please select student, exam and enter a score.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid numeric score.");
                return;
            }

            var mark = new Mark
            {
                StudentId = (int)comboStudent.SelectedValue,
                ExamId = (int)comboExam.SelectedValue,
                Score = score
            };

            string result = _markController.CreateMark(mark);
            MessageBox.Show(result);
            LoadMarks();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (comboStudent.SelectedIndex == -1 || comboExam.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please select student, exam and enter a score.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid numeric score.");
                return;
            }

            var mark = new Mark
            {
                MarkId = selectedMarkId,
                StudentId = (int)comboStudent.SelectedValue,
                ExamId = (int)comboExam.SelectedValue,
                Score = score
            };

            string result = _markController.UpdateMark(mark);
            MessageBox.Show(result);
            LoadMarks();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this mark?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string result = _markController.DeleteMark(selectedMarkId);
                MessageBox.Show(result);
                LoadMarks();
                ClearForm();
            }
        }

        private void dgvMarks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarks.SelectedRows.Count > 0)
            {
                var row = dgvMarks.SelectedRows[0];
                var mark = row.DataBoundItem as Mark;

                if (mark != null)
                {
                    selectedMarkId = mark.MarkId;
                    comboStudent.SelectedValue = mark.StudentId;
                    comboExam.SelectedValue = mark.ExamId;
                    txtScore.Text = mark.Score.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvMarks.ClearSelection();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            if (Role.RoleName == "Student") 
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }
    }
}
