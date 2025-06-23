using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Data;

namespace Unicom_Tic_Management_System
{
    public partial class StudentForm : Form
    {
        StudentController _studentController = new StudentController();
        private  CourseController _courseController;
        private int selectedStudentId = -1;
        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourse();
            addtocombobox();

        }
        private void LoadStudents()
        {
            List< Student > students = _studentController.GetAllStudents();
            StudentGV.DataSource = students;
            StudentGV.Columns["StudentId"].Visible = false;
            StudentGV.ClearSelection();
        }
        public void addtocombobox() 
        {
            CourseController courseController = new CourseController();
            List<Course> courses = courseController.GetAllCourses();
            ComCourse.DataSource = courses;
            ComCourse.DisplayMember = "CourseName";
            ComCourse.ValueMember = "CourseId";
        }
        private void LoadCourse()
        {
            //var courses = _courseController.GetAllCourses();
            //ComCourse.DataSource = courses;
            //ComCourse.DisplayMember = "Name";
            //ComCourse.ValueMember = "Id";

        }
        private void ClearForm()
        {
            txName.Clear();
            txAddress.Clear();
            ComCourse.SelectedIndex = -1;
            selectedStudentId = -1;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void txName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txName.Text) || string.IsNullOrWhiteSpace(txAddress.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            
            Student student = new Student
            {
                Name = txName.Text,
                Address = txAddress.Text,
                CourseId = Convert.ToInt32(ComCourse.SelectedValue)
            };

            _studentController.CreateStudent(student);
            LoadStudents();
            ClearForm();
            MessageBox.Show("Student Added Successfully");
            ClearInputs();
        }
        private void ClearInputs() 
        {
            txName.Text = "";
            txAddress.Text = "";
        }

        private void txCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentGV_CellContentClick(object sender, EventArgs e)
        {
            if (StudentGV.SelectedRows.Count > 0)
            {
                var row = StudentGV.SelectedRows[0];
                var studentView = row.DataBoundItem as Student;

                if (studentView != null)
                {
                    selectedStudentId = studentView.StudentId;

                    var student = _studentController.GetStudentById(selectedStudentId);
                    if (student != null)
                    {
                        txName.Text = student.Name;
                        txAddress.Text = student.Address;
                        ComCourse.SelectedValue = student.CourseId;
                    }
                }
            }
            else
            {
                ClearInputs();
                selectedStudentId = -1;
            }
        }



        private void lbDOB_Click(object sender, EventArgs e)
        {

        }

        private void lbCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _studentController.DeleteStudent(selectedStudentId);
                LoadStudents();
                ClearForm();
                MessageBox.Show("Student Deleted Successfully");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txName.Text) || string.IsNullOrWhiteSpace(txAddress.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }
            var student = new Student
            {
                StudentId = selectedStudentId,
                Name = txName.Text,
                Address = txAddress.Text,
               // CourseId = (int)cmbSection.SelectedValue
            };

            _studentController.UpdateStudent(student);
            LoadStudents();
            ClearForm();
            MessageBox.Show("Student Updated Successfully");


        }

        private void txDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
