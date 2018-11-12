using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Connection
{
    class Connection
    {
        public MySqlConnection Create()
        {
            //string connectionString = "server=70.37.57.127;database=backs;uid=nsf;password=nsf@2018;sslmode=none";
            string connectionString = "server=192.168.0.100; database=bancod;uid=nsf;password=nsf@2018;sslmode=none";
            //string connectionString = "server=localhost;database=backs;uid=root;password=chapadao15";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
