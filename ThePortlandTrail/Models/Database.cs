using System;
using ThePortlandTrail;
using MySql.Data.MySqlClient;

namespace ThePortlandTrail.Models {
    public class DB {
        public static MySqlConnection Connection () {
            MySqlConnection conn = new MySqlConnection (DBConfiguration.ConnectionString);
            return conn;
        }
    }
}