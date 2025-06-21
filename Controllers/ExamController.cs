using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    internal class ExamController
    {
        public string CreateExam(Exam exam)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Exams (ExamName, SubjectID) VALUES (@ExamName, @SubjectID)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectId);
                    cmd.ExecuteNonQuery();

                    return "Exam added successfully";
                }
            }
        }
        public string UpdateExam(Exam exam, int examID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Exams SET ExamName = @ExamName, SubjectID = @SubjectID WHERE ExamID = @ExamID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectId);
                    cmd.Parameters.AddWithValue("@ExamID", examID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? "Exam updated successfully" : "Exam not found or update failed";
                }
            }
        }
        public string DeleteExam(int examID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Exams WHERE ExamID = @ExamID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0 ? "Exam deleted successfully" : "Exam not found or delete failed";
                }
            }
        }
        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Exams";
                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamName = reader["ExamName"].ToString(),
                            SubjectId = Convert.ToInt32(reader["SubjectID"])
                            // You can include ExamID too if needed
                        });
                    }
                }
            }

            return exams;
        }
        public Exam GetExamById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Exams WHERE ExamId = @ExamId", conn);
                cmd.Parameters.AddWithValue("@ExamId", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Exam
                        {
                            ExamId = reader.GetInt32(0),
                            ExamName = reader.GetString(2),
                            SubjectId = reader.GetInt32(1)

                        };
                    }
                }
            }
            return null;

        }     
    }   
}
        

    

