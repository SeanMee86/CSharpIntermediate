using System;
using MySql.Data.MySqlClient;

namespace MongoConnect
{
    class MySQLConnect
    {
        public void MySQLMainMethod()
        {
            var connStr = "server=localhost;username=root;password=root;database=pavillon";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connection to Database...");
                conn.Open();

                var query = "SELECT * FROM `wp_options`";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    for (int i = 0; i < rdr.FieldCount; i++)
                        Console.WriteLine(rdr[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
