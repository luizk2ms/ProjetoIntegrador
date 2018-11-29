using MySql.Data.MySqlClient;

namespace Software.Digudao.DB.db
{
    class Connection
    {
        public MySqlConnection Create()
        {
////// HEAD
            //string connectionString = "server=104.214.59.125;database=digudão;uid=nsf;password=nsf@2018;sslmode=none";
/////
            //string connectionString = "server=104.214.59.125;database=bancod;uid=nsf;password=nsf@2018;sslmode=none";
            /// 6788262e182e7d97102c90b6cb97fbfc490dafeb

            //Base de Dados Frei
            //string connectionString = "server=192.168.0.100;database=bancod;uid=nsf;password´=nsf2018;sslmode=nome";

            //Base de Dados Azure
            string connectionString = "server=70.37.57.127;database=bancod;uid=nsf;password=nsf@2018;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
