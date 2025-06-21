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
            this.butTimetable = new System.Windows.Forms.Button();
            this.butMarks = new System.Windows.Forms.Button();
            this.butExams = new System.Windows.Forms.Button();
            this.butStudent = new System.Windows.Forms.Button();
            this.butCourse = new System.Windows.Forms.Button();
            this.butUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butTimetable
            // 
            this.butTimetable.Location = new System.Drawing.Point(467, 39);
            this.butTimetable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butTimetable.Name = "butTimetable";
            this.butTimetable.Size = new System.Drawing.Size(100, 23);
            this.butTimetable.TabIndex = 0;
            this.butTimetable.Text = "Timetable";
            this.butTimetable.UseVisualStyleBackColor = true;
            // 
            // butMarks
            // 
            this.butMarks.Location = new System.Drawing.Point(467, 85);
            this.butMarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butMarks.Name = "butMarks";
            this.butMarks.Size = new System.Drawing.Size(100, 23);
            this.butMarks.TabIndex = 1;
            this.butMarks.Text = "Marks";
            this.butMarks.UseVisualStyleBackColor = true;
            this.butMarks.Click += new System.EventHandler(this.button2_Click);
            // 
            // butExams
            // 
            this.butExams.Location = new System.Drawing.Point(467, 125);
            this.butExams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butExams.Name = "butExams";
            this.butExams.Size = new System.Drawing.Size(100, 26);
            this.butExams.TabIndex = 2;
            this.butExams.Text = "Exams";
            this.butExams.UseVisualStyleBackColor = true;
            // 
            // butStudent
            // 
            this.butStudent.Location = new System.Drawing.Point(467, 176);
            this.butStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butStudent.Name = "butStudent";
            this.butStudent.Size = new System.Drawing.Size(100, 23);
            this.butStudent.TabIndex = 3;
            this.butStudent.Text = "Student";
            this.butStudent.UseVisualStyleBackColor = true;
            // 
            // butCourse
            // 
            this.butCourse.Location = new System.Drawing.Point(467, 226);
            this.butCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butCourse.Name = "butCourse";
            this.butCourse.Size = new System.Drawing.Size(100, 23);
            this.butCourse.TabIndex = 4;
            this.butCourse.Text = "Course";
            this.butCourse.UseVisualStyleBackColor = true;
            // 
            // butUser
            // 
            this.butUser.Location = new System.Drawing.Point(467, 268);
            this.butUser.Name = "butUser";
            this.butUser.Size = new System.Drawing.Size(100, 23);
            this.butUser.TabIndex = 5;
            this.butUser.Text = "User";
            this.butUser.UseVisualStyleBackColor = true;
            // 
            // ControlForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.butUser);
            this.Controls.Add(this.butCourse);
            this.Controls.Add(this.butStudent);
            this.Controls.Add(this.butExams);
            this.Controls.Add(this.butMarks);
            this.Controls.Add(this.butTimetable);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlForn";
            this.Text = "ControlForn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butTimetable;
        private System.Windows.Forms.Button butMarks;
        private System.Windows.Forms.Button butExams;
        private System.Windows.Forms.Button butStudent;
        private System.Windows.Forms.Button butCourse;
        private System.Windows.Forms.Button butUser;
    }
}