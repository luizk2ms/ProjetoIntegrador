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

            string connectionString = "server=104.214.59.125;database=bancodb;uid=nsf;password=nsf@2018;sslmode=none";

            //Base de Dados Frei
            //string connectionString = "server=192.168.0.100;database=bancodb;uid=nsf;password´=nsf2018;sslmode=nome";

            //Base de Dados Azure
            //string connectionString = "server=70.37.57.127;database=bancodb;uid=nsf;password´=nsf2018;sslmode=nome";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
