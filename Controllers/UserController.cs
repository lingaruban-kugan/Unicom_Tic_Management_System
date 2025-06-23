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
    internal class UserController
    {
        public static void AddUser(string username, string password, string role)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role);";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateUser(string username, string newPassword, string newRole ,int ID)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                string query = "UPDATE Users SET Password = @Password, Role = @Role ,Username = @Username WHERE UserID = @UserID;";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Role", newRole);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@UserID", ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(string username)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                string query = "DELETE FROM Users WHERE Username = @Username;";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var conn = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Users;";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {User user = new User();
                        user.UserID = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Password =reader.GetString(2);
                        user.Role = reader.GetString(3);
                        users.Add(user);
                        
                    }
                }
            }

            return users;
        }
        public User GetUserById(int userId)
        {
            using (SQLiteConnection connection = Dbconfig.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return null;
        }

    }

}

