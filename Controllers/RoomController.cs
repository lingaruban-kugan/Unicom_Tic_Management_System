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
    public class RoomController
    {
        public void AddRoom(string roomName, string roomType)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@RoomName, @RoomType)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomName", roomName);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get all rooms
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Rooms";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2)
                            };
                            rooms.Add(room);
                        }
                    }
                }
            }

            return rooms;
        }

        // Get room by ID
        public Room GetRoomById(int roomId)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Rooms WHERE RoomID = @RoomID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Room
                            {
                                RoomID = reader.GetInt32(0),
                                RoomName = reader.GetString(1),
                                RoomType = reader.GetString(2)
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Update room
        public void UpdateRoom(int roomId, string newRoomName, string newRoomType)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @RoomID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomName", newRoomName);
                    cmd.Parameters.AddWithValue("@RoomType", newRoomType);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete room
        public string DeleteRoom(int roomId)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "Room deleted successfully" : "Delete failed or room not found";
                }
            }
        }
    }

}

