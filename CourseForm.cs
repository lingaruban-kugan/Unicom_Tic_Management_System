using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_Tic_Management_System.Controllers;
using Unicom_Tic_Management_System.Data;

namespace Unicom_Tic_Management_System
{
    public partial class CourseForm : Form
    {
        private CourseController courseController = new CourseController();
        private int selectCourseId = -1;

        public CourseForm()
        {
            InitializeComponent();
            Addto_view();
        }

        private void Addto_view()
        {
            CourseController courrse = new CourseController();
            List<Course> courses = courrse.GetAllCourses();

            // Assign the courses list to the DataGridView
            coursegv.DataSource = courses;

            // Ensure the correct column names
            // This assumes that CourseId is the column in your DataGridView
        }

        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your existing cell click logic (if needed)
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Any additional load logic (if needed)
        }

        private void BtADD_Click(object sender, EventArgs e)
        {
            var Course = new Course
            {
                CourseName = txCourseName.Text.Trim()
            };
            courseController.AddCourse(Course.CourseName);
            Addto_view();
            txCourseName.Clear();
        }

        private void BtUPDATE_Click(object sender, EventArgs e)
        {
            if (coursegv.SelectedRows.Count > 0)
            {
                // Ensure that the column name "CourseId" is correct
                int courseId = Convert.ToInt32(coursegv.SelectedRows[0].Cells["CourseId"].Value);
                string newCourseName = txCourseName.Text.Trim();

                if (!string.IsNullOrEmpty(newCourseName))  // Ensure course name is not empty
                {
                    var updatedCourse = new Course
                    {
                        CourseId = courseId,
                        CourseName = newCourseName
                    };

                    courseController.UpdateCourse(updatedCourse.CourseId, updatedCourse.CourseName);
                    Addto_view();  // Refresh the DataGridView after the update
                    txCourseName.Clear();  // Clear the TextBox after update
                }
                else
                {
                    MessageBox.Show("Course name cannot be empty.");
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.");
            }
        }


        private void BtDELETE_Click(object sender, EventArgs e)
        {
            if (coursegv.SelectedRows.Count > 0)
            {
                // Use the correct column name, "CourseId"
                int id = Convert.ToInt32(coursegv.SelectedRows[0].Cells["CourseId"].Value);
                courseController.DeleteCourse(id);
                Addto_view();
                txCourseName.Clear();
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void ClearInputs()
        {
            txCourseName.Text = "";
        }

        private void coursegv_SelectionChanged(object sender, EventArgs e)
        {
            if (coursegv.SelectedRows.Count > 0)
            {
                var row = coursegv.SelectedRows[0];
                Course courseView = row.DataBoundItem as Course;

                if (courseView != null)
                {
                    selectCourseId = courseView.CourseId;
                    txCourseName.Text = courseView.CourseName;
                }
            }
            else
            {
                ClearInputs();
                selectCourseId = -1;
            }
        }
    }
}
