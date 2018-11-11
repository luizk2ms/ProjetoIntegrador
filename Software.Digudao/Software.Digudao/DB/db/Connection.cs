
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.db
{
    class Connection
    {
        public MySqlConnection Create()
        {

            string connectionString = "server=localhost;database=bancod;uid=root;password=1234;sslmode=none";

            //Base de Dados Frei
            //string connectionString = "server=192.168.0.100;database=bancod;uid=nsf;password´=nsf2018;sslmode=nome";

            //Base de Dados Azure
            //string connectionString = "server=70.37.57.127;database=bancod;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
