using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_Tic_Management_System.Models
{
    public static class Dbconfig
    {
        private static string connectionString = "Data Source=Unicomtic.db.db;Version=3;";
        public static SQLiteConnection GetConnection    ()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
