using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    public class CourseController
    {
        //private string _connectionString;


        public string DeleteCourse(int courseid)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Courses WHERE CourseID = @courseID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@courseID", courseid);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Student deleted successfully" : "Delete failed or student not found";
                }
            }
        }

        // ✅ Get all courses (FIXED)
        public List<Course> GetAllCourses()
        {
            List<Course> course = new List<Course>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Courses";
                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course couses = new Course(); 
                        couses.CourseId = reader.GetInt32(0);
                        couses.CourseName = reader.GetString(1);
                        course.Add(couses);
                    }
                }
            }

            return course;
            /* List<Course> course = new List<Course>();

             using (SQLiteConnection connection = Dbconfig.GetConnection())
             {
                 string query = "SELECT * FROM Courses";
                 Course couses = new Course();
                 using (var cmd = new SQLiteCommand(query, connection))
                 using (SQLiteDataReader reader = cmd.ExecuteReader())


                     while (reader.Read())
                     {
                         Course course = new Course();
                         course.CourseId = reader.GetInt32(0);
                         course.CourseName = reader.GetString(1);
                         course.Add(course);
                     }

             }

             return course;*/
        }
        public Course GetCourseById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses WHERE CourseId = @CourseId", conn);
                cmd.Parameters.AddWithValue("@CourseId", id);

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

        public void AddCourse(string courseName)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", connection);
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.ExecuteNonQuery();
            }
        }


        // Update existing Course by CourseID
        public void UpdateCourse(int courseId, string newCourseName)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {

                var cmd = new SQLiteCommand("UPDATE Course SET CourseName = @CourseName WHERE CourseID = @CourseID");
                cmd.Parameters.AddWithValue("@CourseName", newCourseName);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.ExecuteNonQuery();
            }
        }

       
        //public string DeleteStudent(int courseid)
        //{
        //    using (SQLiteConnection connection = Dbconfig.GetConnection())
        //    {
        //        string query = "DELETE FROM Courses WHERE CourseID = @courseID";

        //        using (var cmd = new SQLiteCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@courseID", courseid);

        //            int rows = cmd.ExecuteNonQuery();
        //            return rows > 0 ? "Student deleted successfully" : "Delete failed or student not found";
        //        }
        //    }
        //}

        // ✅ Get all courses (FIXED)
        //public List<Course> GetAllStudents()
        //{
        //    List<Course> course = new List<Course>();

        //    using (SQLiteConnection connection = Dbconfig.GetConnection())
        //    {
        //        string query = "SELECT * FROM Courses";
        //        Course couses = new Course();
        //        using (var cmd = new SQLiteCommand(query, connection))
        //        using (SQLiteDataReader reader = cmd.ExecuteReader())

        //        {
        //            while (reader.Read())
        //            {



        //                couses.CourseId = reader.GetInt32(0);
        //                couses.CourseName = reader.GetString(1);
        //                course.Add(couses);


        //            }
        //        }
        //    }

        //    return course;
        //}
        //public Course GetCourseById(int id)
        //{
        //    using (var conn = Dbconfig.GetConnection())
        //    {
        //        var cmd = new SQLiteCommand("SELECT * FROM Courses WHERE CourseId = @CourseId", conn);
        //        cmd.Parameters.AddWithValue("@CourseId", id);

        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                return new Course
        //                {
        //                    CourseId = reader.GetInt32(0),
        //                    CourseName = reader.GetString(1)
        //                };
        //            }
        //        }
        //    }

        //    return null;
        //}
    }
}
