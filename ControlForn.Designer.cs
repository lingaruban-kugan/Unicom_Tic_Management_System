namespace Unicom_Tic_Management_System
{
    partial class ControlForn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.butStudent = new System.Windows.Forms.Button();
            this.butExams = new System.Windows.Forms.Button();
            this.butCourse = new System.Windows.Forms.Button();
            this.butMarks = new System.Windows.Forms.Button();
            this.butUser = new System.Windows.Forms.Button();
            this.butTimetable = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.butUser);
            this.panel3.Controls.Add(this.butTimetable);
            this.panel3.Controls.Add(this.butCourse);
            this.panel3.Controls.Add(this.butMarks);
            this.panel3.Controls.Add(this.butStudent);
            this.panel3.Controls.Add(this.butExams);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 450);
            this.panel3.TabIndex = 8;
            // 
            // butStudent
            // 
            this.butStudent.Location = new System.Drawing.Point(346, 224);
            this.butStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butStudent.Name = "butStudent";
            this.butStudent.Size = new System.Drawing.Size(100, 23);
            this.butStudent.TabIndex = 3;
            this.butStudent.Text = "Student";
            this.butStudent.UseVisualStyleBackColor = true;
            this.butStudent.Click += new System.EventHandler(this.butStudent_Click);
            // 
            // butExams
            // 
            this.butExams.Location = new System.Drawing.Point(346, 168);
            this.butExams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butExams.Name = "butExams";
            this.butExams.Size = new System.Drawing.Size(100, 26);
            this.butExams.TabIndex = 2;
            this.butExams.Text = "Exams";
            this.butExams.UseVisualStyleBackColor = true;
            this.butExams.Click += new System.EventHandler(this.butExams_Click);
            // 
            // butCourse
            // 
            this.butCourse.Location = new System.Drawing.Point(346, 283);
            this.butCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butCourse.Name = "butCourse";
            this.butCourse.Size = new System.Drawing.Size(100, 23);
            this.butCourse.TabIndex = 4;
            this.butCourse.Text = "Course";
            this.butCourse.UseVisualStyleBackColor = true;
            this.butCourse.Click += new System.EventHandler(this.butCourse_Click);
            // 
            // butMarks
            // 
            this.butMarks.Location = new System.Drawing.Point(346, 114);
            this.butMarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butMarks.Name = "butMarks";
            this.butMarks.Size = new System.Drawing.Size(100, 23);
            this.butMarks.TabIndex = 1;
            this.butMarks.Text = "Marks";
            this.butMarks.UseVisualStyleBackColor = true;
            this.butMarks.Click += new System.EventHandler(this.button2_Click);
            // 
            // butUser
            // 
            this.butUser.Location = new System.Drawing.Point(346, 349);
            this.butUser.Name = "butUser";
            this.butUser.Size = new System.Drawing.Size(100, 23);
            this.butUser.TabIndex = 5;
            this.butUser.Text = "User";
            this.butUser.UseVisualStyleBackColor = true;
            this.butUser.Click += new System.EventHandler(this.butUser_Click);
            // 
            // butTimetable
            // 
            this.butTimetable.Location = new System.Drawing.Point(346, 63);
            this.butTimetable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butTimetable.Name = "butTimetable";
            this.butTimetable.Size = new System.Drawing.Size(100, 23);
            this.butTimetable.TabIndex = 0;
            this.butTimetable.Text = "Timetable";
            this.butTimetable.UseVisualStyleBackColor = true;
            this.butTimetable.Click += new System.EventHandler(this.butTimetable_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(784, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ControlForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlForn";
            this.Text = "ControlForn";
            this.Load += new System.EventHandler(this.ControlForn_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butUser;
        private System.Windows.Forms.Button butTimetable;
        private System.Windows.Forms.Button butCourse;
        private System.Windows.Forms.Button butMarks;
        private System.Windows.Forms.Button butStudent;
        private System.Windows.Forms.Button butExams;
        private System.Windows.Forms.Button btnBack;
    }
}