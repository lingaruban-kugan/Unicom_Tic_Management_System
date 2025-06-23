using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    public class CourseController
    {
        // Delete a course by CourseId
        public string DeleteCourse(int courseId)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Courses WHERE CourseID = @courseID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@courseID", courseId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Course deleted successfully" : "Delete failed or course not found";
                }
            }
        }

        // Get all courses
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Courses";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Course course = new Course
                            {
                                CourseId = reader.GetInt32(0),
                                CourseName = reader.GetString(1)
                            };
                            courses.Add(course);
                        }
                    }
                }
            }

            return courses;
        }

        //Get course by ID
        public Course GetCourseById(int courseId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Courses WHERE CourseId = @CourseId";
                var cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseId", courseId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Course
                        {
                            CourseId = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        };
                    }
                }
            }

            return null;
        }

        // Add a new course
        public void AddCourse(string courseName)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";
                var cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseName", courseName);

                cmd.ExecuteNonQuery();
            }
        }

        //Update course by CourseId
        public void UpdateCourse(int courseId, string newCourseName)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID";
                var cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseName", newCourseName);
                cmd.Parameters.AddWithValue("@CourseID", courseId); 
                cmd.ExecuteNonQuery();
            }
        }
    }
}
