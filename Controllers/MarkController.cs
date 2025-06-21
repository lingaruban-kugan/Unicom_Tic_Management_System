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
    public class MarkController
    {
        public string CreateMark(Mark mark)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);

                    cmd.ExecuteNonQuery();
                    return "Mark added successfully";
                }
            }
        }
        public string UpdateMark(Mark mark)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.Parameters.AddWithValue("@MarkID", mark.MarkId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Mark updated successfully" : "Update failed or mark not found";
                }
            }
        }
        public string DeleteMark(int markID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Marks WHERE MarkID = @MarkID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarkID", markID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Mark deleted successfully" : "Delete failed or mark not found";
                }
            }
        }
        public List<Mark> GetAllMarks()
        {
            List<Mark> marks = new List<Mark>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Marks";

                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
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
        public Mark GetMarkById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Marks WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@MarkID", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Mark
                        {
                            MarkId = reader.GetInt32(0),
                            StudentId = reader.GetInt32(1),
                            ExamId = reader.GetInt32(2),
                            Score = reader.GetInt32(3)

                        };
                    }
                }
            }

            return null;
        }

    }
}
