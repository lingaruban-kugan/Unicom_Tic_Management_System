using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static void UpdateUser(string username, string newPassword, string newRole)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                string query = "UPDATE Users SET Password = @Password, Role = @Role WHERE Username = @Username;";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Role", newRole);
                    cmd.Parameters.AddWithValue("@Username", username);
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

        public static List<(int UserID, string Username, string Role)> GetAllUsers()
        {
            var users = new List<(int, string, string)>();

            using (var conn = Dbconfig.GetConnection())
            {
                string query = "SELECT UserID, Username, Role FROM Users;";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add((
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        ));
                    }
                }
            }

            return users;
        }
    }

}

