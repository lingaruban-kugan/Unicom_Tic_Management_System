using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    internal class MarkController
    {
        public string CreateMark(Mark mark)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Mark added successfully." : "Failed to add mark.";
                }
            }
        }

        public string UpdateMark(Mark mark)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.Parameters.AddWithValue("@MarkID", mark.MarkId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Mark updated successfully." : "Mark not found or update failed.";
                }
            }
        }

        public string DeleteMark(int markId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Marks WHERE MarkID = @MarkID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarkID", markId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Mark deleted successfully." : "Mark not found or delete failed.";
                }
            }
        }

        public List<Mark> GetAllMarks()
        {
            List<Mark> marks = new List<Mark>();

            using (var connection = Dbconfig.GetConnection())
            {
                string query = "SELECT MarkID, StudentID, ExamID, Score FROM Marks";
                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            MarkId = Convert.ToInt32(reader["MarkID"]),
                            StudentId = Convert.ToInt32(reader["StudentID"]),
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }
            }

            return marks;
        }

        public Mark GetMarkById(int markId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "SELECT MarkID, StudentID, ExamID, Score FROM Marks WHERE MarkID = @MarkID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarkID", markId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mark
                            {
                                MarkId = Convert.ToInt32(reader["MarkID"]),
                                StudentId = Convert.ToInt32(reader["StudentID"]),
                                ExamId = Convert.ToInt32(reader["ExamID"]),
                                Score = Convert.ToInt32(reader["Score"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
