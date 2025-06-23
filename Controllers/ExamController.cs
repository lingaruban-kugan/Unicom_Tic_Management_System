using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    internal class ExamController
    {
        public string CreateExam(Exam exam)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Exams (ExamName, CourseId, Date) VALUES (@ExamName, @CourseId, @Date)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@CourseId", exam.CourseId);
                    cmd.Parameters.AddWithValue("@Date", exam.Date);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Exam added successfully";
        }

        public string UpdateExam(Exam exam)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Exams SET ExamName = @ExamName, CourseId = @CourseId, Date = @Date WHERE ExamId = @ExamId";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@CourseId", exam.CourseId);
                    cmd.Parameters.AddWithValue("@Date", exam.Date);
                    cmd.Parameters.AddWithValue("@ExamId", exam.ExamId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Exam updated successfully" : "Exam update failed";
                }
            }
        }

        public string DeleteExam(int examId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Exams WHERE ExamId = @ExamId";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamId", examId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Exam deleted successfully" : "Exam delete failed";
                }
            }
        }

        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();
            using (var connection = Dbconfig.GetConnection())
            {
                string query = @"
                    SELECT Exams.ExamId, Exams.ExamName, Exams.CourseId, Courses.CourseName, Exams.Date
                    FROM Exams 
                    LEFT JOIN Courses ON Exams.CourseId = Courses.CourseId";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamId = Convert.ToInt32(reader["ExamId"]),
                            ExamName = reader["ExamName"].ToString(),
                            CourseId = Convert.ToInt32(reader["CourseId"]),
                            CourseName = reader["CourseName"].ToString(),
                            Date = reader["Date"].ToString()
                        });
                    }
                }
            }
            return exams;
        }

        public Exam GetExamById(int examId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = @"
                    SELECT Exams.ExamId, Exams.ExamName, Exams.CourseId, Courses.CourseName, Exams.Date
                    FROM Exams 
                    LEFT JOIN Courses ON Exams.CourseId = Courses.CourseId
                    WHERE ExamId = @ExamId";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamId", examId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Exam
                            {
                                ExamId = Convert.ToInt32(reader["ExamId"]),
                                ExamName = reader["ExamName"].ToString(),
                                CourseId = Convert.ToInt32(reader["CourseId"]),
                                CourseName = reader["CourseName"].ToString(),
                                Date = reader["Date"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
