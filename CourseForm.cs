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
using static System.Collections.Specialized.BitVector32;

namespace Unicom_Tic_Management_System
{
    public partial class CourseForm : Form
    { //CourseController controller;
        private CourseController courseController =  new CourseController();
        public CourseForm()
        {
            InitializeComponent();
            Addto_view();
           // controller = new CourseController();
        }
        private void Addto_view()
        {
            CourseController courrse = new CourseController();
            List<Course> courses = courrse.GetAllCourses();
            coursegv.DataSource = courses;

        }
        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void BtADD_Click(object sender, EventArgs e)
        {
            //Course course = new Course();
            //course.CourseName = txCourseName.Text;
            
            //courseController.AddCourse(course.CourseName);

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
                int id = Convert.ToInt32(coursegv.SelectedRows[0].Cells["Id"].Value);
                var cou = new Course
                {
                    CourseId = id,
                    CourseName = txCourseName.Text.Trim()
                };
                courseController.UpdateCourse(cou.CourseId,cou.CourseName);
                Addto_view();
                txCourseName.Clear();
            }
        }

        private void txCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtDELETE_Click(object sender, EventArgs e)
        {
            if (coursegv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(coursegv.SelectedRows[0].Cells["CourseId"].Value);
                courseController.DeleteCourse(id);
                Addto_view();
                txCourseName.Clear();
            }
            else
            {
                MessageBox.Show("Please select a section to delete.");
            }
        }

        private void coursegv_SelectionChanged(object sender, EventArgs e) { }
       
        
    }
}
