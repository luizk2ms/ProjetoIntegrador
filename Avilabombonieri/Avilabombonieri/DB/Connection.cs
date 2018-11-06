using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB
{
    class Connection
    {
        public MySqlConnection Create()
        {
            
            string connectionString = "server=104.214.59.125;database=futebol;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
