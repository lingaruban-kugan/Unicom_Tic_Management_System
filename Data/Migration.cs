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

            string CreateTableQuery = @"
                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Students (
                    StuTEXT NOT NULL,
                    Address TEXt NOT NULL,
                    CourseID INTEdentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name GER, 
                    FOREIGN KEY(CourseID) REFERENCES Course(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER, 
                    FOREIGN KEY(CourseID) REFERENCES Course(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    SubjectID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID)
                );          

                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER, 
                    Score INTEGER NOT NULL,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );

                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL, 
                    Role TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT, 
                    RoomName TEXT NOT NULL, 
                    RoomType TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT NOT NULL, 
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID),
                    FOREIGN KEY(RoomID) REFERENCES Room(RoomID)
                );

                CREATE TABLE IF NOT EXISTS Student_Exams (
                    StudentID INTEGER,
                    ExamID INTEGER,
                    PRIMARY KEY (StudentID, ExamID),
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );";


            using (var conn = Dbconfig.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(CreateTableQuery, conn);
                cmd.ExecuteNonQuery();


            }


        }
    }
}
