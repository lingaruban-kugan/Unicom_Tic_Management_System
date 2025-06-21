using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    public class StudentController
    {
       
        public string CreateStudent(Student student)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Students (Name, Address, CourseID) VALUES (@Name, @Address, @CourseID)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseId);

                    cmd.ExecuteNonQuery();
                    return "Student added successfully";
                }
            }
        }

        public string UpdateStudent(Student student)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Students SET Name = @Name, Address = @Address, CourseID = @CourseID WHERE StudentID = @StudentID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseId);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Student updated successfully" : "Update failed or student not found";
                }
            }
        }

        public string DeleteStudent(int studentID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Student deleted successfully" : "Delete failed or student not found";
                }
            }
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Students";

                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {

                            StudentId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            CourseId = reader.GetInt32(3)

                        });
                    }
                }
            }

            return students;
        }
        public Student GetStudentById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Students WHERE StudentID = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            CourseId = reader.GetInt32(3)
                        };
                    }
                }
            }

            return null;
        }

    }
}