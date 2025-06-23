using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_Tic_Management_System.Data;
using Unicom_Tic_Management_System.Models;

namespace Unicom_Tic_Management_System.Controllers
{
    internal class TimetableController
    {
        public List<Timetable> GetAllTimetables()
        {
            List<Timetable> timetables = new List<Timetable>();

            using (var connection = Dbconfig.GetConnection())
            {
                

                string query = @"
            SELECT t.TimetableID, t.SubjectID, s.SubjectName, t.TimeSlot, t.RoomID, r.RoomName
            FROM Timetables t
            INNER JOIN Subjects s ON t.SubjectID = s.SubjectID
            INNER JOIN Rooms r ON t.RoomID = r.RoomID";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetables.Add(new Timetable
                        {
                            TimetableId = reader.GetInt32(0),
                            SubjectId = reader.GetInt32(1),
                            SubjectName = reader.GetString(2),
                            TimeSlot = reader.GetString(3),
                            RoomId = reader.GetInt32(4),
                            RoomName = reader.GetString(5)
                        });
                    }
                }
            }
            return timetables;
        }

        public string AddTimetable(Timetable timetable)
        {
            using (var connection = Dbconfig.GetConnection())
            {
               

                // Get SubjectID from SubjectName
                int subjectId = GetSubjectIdByName(timetable.SubjectName, connection);
                if (subjectId == -1)
                    return "Invalid Subject Name";

                // Get RoomID from RoomName
                int roomId = GetRoomIdByName(timetable.RoomName, connection);
                if (roomId == -1)
                    return "Invalid Room Name";

                string query = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@SubjectID, @TimeSlot, @RoomID)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    cmd.ExecuteNonQuery();
                }

                return "Timetable added successfully";
            }
        }

        public string DeleteTimetable(int timetableId)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                
                string query = "DELETE FROM Timetables WHERE TimetableID = @TimetableID";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Timetable deleted successfully" : "Delete failed or timetable not found";
                }
            }
        }


        public string UpdateTimetable(Timetable timetable)
        {
            using (var connection = Dbconfig.GetConnection())
            {
                

                int subjectId = GetSubjectIdByName(timetable.SubjectName, connection);
                if (subjectId == -1)
                    return "Invalid Subject Name";

                int roomId = GetRoomIdByName(timetable.RoomName, connection);
                if (roomId == -1)
                    return "Invalid Room Name";

                string query = "UPDATE Timetables SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID WHERE TimetableID = @TimetableID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Timetable updated successfully" : "Update failed or timetable not found";
                }
            }
        }

        public int GetSubjectIdByName(string subjectName, SQLiteConnection connection)
        {
            string query = "SELECT SubjectID FROM Subjects WHERE SubjectName = @SubjectName LIMIT 1";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public int GetRoomIdByName(string roomName, SQLiteConnection connection)
        {
            string query = "SELECT RoomID FROM Rooms WHERE RoomName = @RoomName LIMIT 1";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@RoomName", roomName);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
