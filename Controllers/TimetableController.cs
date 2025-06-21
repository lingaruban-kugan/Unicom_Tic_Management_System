using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    internal class TimetableController
    {
        public string AddTimetable(Timetable timetable)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@SubjectID, @TimeSlot, @RoomID)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);

                    cmd.ExecuteNonQuery();
                    return "Timetable added successfully";
                }
            }
        }



        public string UpdateTimetable(Timetable timetable)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Timetables SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID WHERE TimetableID = @TimetableID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableId);
                   
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Timetable updated successfully" : "Update failed or timetable not found";
                }
            }
        }


        public string DeleteTimetable(int timetableID)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Timetables WHERE TimetableID = @TimetableID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetableID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Timetable deleted successfully" : "Delete failed or timetable not found";
                }
            }
        }


        public List<Timetable> GetAllTimetables()
        {
            List<Timetable> timetables = new List<Timetable>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Timetables";

                using (var cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetables.Add(new Timetable
                        {
                            TimetableId = reader.GetInt32(0),
                            SubjectId = reader.GetInt32(1),
                            TimeSlot = reader.GetString(2),
                            RoomId = reader.GetInt32(3)
                        });
                    }
                }
            }

            return timetables;
        }


        public Timetable GetTimetableById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Timetables WHERE TimetableID = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Timetable
                        {
                            TimetableId = reader.GetInt32(0),
                            SubjectId = reader.GetInt32(1),
                            TimeSlot = reader.GetString(2),
                            RoomId = reader.GetInt32(3)
                        };
                    }
                }
            }

            return null;
        }


    }
}
