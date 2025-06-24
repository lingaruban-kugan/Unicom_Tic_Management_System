using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_Tic_Management_System
{
    public partial class ControlForn : Form
    {
        public ControlForn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlForn_Load(object sender, EventArgs e)
        {
           
        }

        private void butTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm frm = new TimetableForm();
            frm.Show();
        }

        private void butExams_Click(object sender, EventArgs e)
        {
            ExamForm frm = new ExamForm();
            frm.Show();
        }

        private void butStudent_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            frm.Show();
        }

        private void butCourse_Click(object sender, EventArgs e)
        {
            CourseForm frm = new CourseForm();
            frm.Show();
        }

        private void butUser_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
        }
    }
}
