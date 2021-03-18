using MSPR_API.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSPR_API.Controllers.db
{
    public class dbInfo
    {
        public static void Add(Information i)
        {
            MySqlConnection conn = db.GetSqlConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert INTO informations (Id, Name, Value) VALUES(@i, @n, @v)";
            cmd.Parameters.AddWithValue("@i", i.Id);
            cmd.Parameters.AddWithValue("@n", i.Name);
            cmd.Parameters.AddWithValue("@v", i.Value);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("La connexion à la bdd a échoué :/(Add Information)");
                conn.Close();
            }

        }
    }
}