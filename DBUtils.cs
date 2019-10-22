using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Sql.Connection
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "lab";
            string username = "root";
            string password = "mysql";

            return DBMySqlUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
