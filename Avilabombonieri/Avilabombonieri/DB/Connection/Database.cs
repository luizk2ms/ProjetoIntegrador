using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Connection
{
    class Database
    {
        public void ExecuteInsertScript(string Script, List<MySqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = Script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();
        }

        public int ExecuteInsertScriptWithPk(string Script, List<MySqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = Script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();

            int id = Convert.ToInt32(command.LastInsertedId);
            return id;
        }

        public MySqlDataReader ExecuteSelectScript(string Script, List<MySqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = Script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            MySqlDataReader reader =
                 command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
