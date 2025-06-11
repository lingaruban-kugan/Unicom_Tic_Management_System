using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_Tic_Management_System.Models
{
    internal class Migration
    {
        public static void Createtable()
        {

            string CreateTableQuarry =
                @"CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CourseID INTEGER NOT NULL, 
                    FOREIGN KEY(CourseID) REFERENCES Courses
                );

                CREATE TABLE IF NOT EXISTS Subject (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER NOT NULL, 
                    FOREIGN KEY(CourseID) REFERENCES Courses
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    SubjectID INTEGER NOT NULL,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects
                );          
                
                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL, 
                    Score INTEGER NOT NULL,
                    FOREIGN KEY(StudentID) REFERENCES Students,
                    FOREIGN KEY(ExamID) REFERENCES Exams
                );    

                CREATE TABLE IF NOT EXISTS Course (
                   CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                   CourseName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS User (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL, 
                    Role TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Room (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT, 
                    RoomName TEXT NOT NULL, 
                    RoomType TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Timetable (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER NOT NULL,
                    TimeSlot TEXT NOT NULL, 
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects,
                    FOREIGN KEY(RoomID) REFERENCES Rooms
                );

                CREATE TABLE IF NOT EXISTS Student_Exam (
                    FOREIGN KEY(SubjectID) REFERENCES  Subjects,
                    FOREIGN KEY(ExamID) REFERENCES  Exams,
                    FOREIGN KEY(Score) REFERENCES  Marks
                )";

            using (var conn = Dbconfig.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(CreateTableQuarry, conn);
                cmd.ExecuteNonQuery();


            }
            MessageBox.Show("Table created successfully.");


        }
    }
}
