using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_WORK_3_VADIM_PETRENKO
{
    internal class DB_DA
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "world";
            string username = "monty";
            string password = "some_pass";

            return DB_MYSQL.GetDBConnection(host, port, database, username, password);
        }
    }
}
