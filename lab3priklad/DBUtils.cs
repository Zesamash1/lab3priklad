using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace lab3priklad
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "world";
            string username = "monty";
            string password = "some_pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);

        }
    }
}