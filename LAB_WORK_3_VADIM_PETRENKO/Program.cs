using MySql.Data.MySqlClient; 
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_WORK_3_VADIM_PETRENKO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DB_DA.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();

                Console.WriteLine("Connection Successful...");
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        private static void QueryEmployee(MySqlConnection conn)
        {
            string id, name, country;
            string sql = "Select Code, Name, Continent from country";
       
            MySqlCommand cmd = new MySqlCommand();
         
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader["Code"].ToString();
                        name = reader["Name"].ToString();
                        country = reader["Continent"].ToString();
                        Console.WriteLine("------------------------------------------------------------------ ");
                        Console.WriteLine("Koд:" + id + " Название:" + name + " Kонтинент:" + country); 
                        Console.WriteLine("------------------------------------------------------------------ ");
                    }


                }
            }


        }
    }
}