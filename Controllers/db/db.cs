using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSPR_API.Controllers.db
{
    public class db
    {
        public static MySqlConnection GetSqlConnection()
        {
            string connStr = "server=127.0.0.1;user=root;database=mspr_maintenance;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return conn;
        }
    }
}