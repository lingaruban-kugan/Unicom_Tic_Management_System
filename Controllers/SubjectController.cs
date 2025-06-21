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
    public class SubjectController
    {
        public string CreateSubject(Subject subject)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Subject (SubjectName, CourseID) VALUES (@SubjectName, @CourseID)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);

                    cmd.ExecuteNonQuery();
                    return "Subject added successfully";
                }
            }
        }
        public string UpdateSubject(Subject subject)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Subject SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Subject updated successfully" : "Update failed or subject not found";
                }
            }
        }
        public string DeleteSubject(int subjectID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Subject WHERE SubjectID = @SubjectID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Subject deleted successfully" : "Delete failed or subject not found";
                }
            }
        }
        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Subject";

                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            SubjectName = reader["SubjectName"].ToString(),
                            CourseID = Convert.ToInt32(reader["CourseID"])
                        });
                    }
                }
            }

            return subjects;
        }

        public Subject GetSubjectById(int id) 
        {
            using (var conn = Dbconfig.GetConnection()) 
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subject WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseID = reader.GetInt32(2)


                        };
                    }
                }
            }

            return null;
        }
        
    }
}
