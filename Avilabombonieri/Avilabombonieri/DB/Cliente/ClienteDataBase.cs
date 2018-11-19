using Avilabombonieri.DB.Connection;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace prototipos.DB.Cliente
{
    class ClienteDatabase
    {
        public void Salvar(ClienteDTO dto)
        {
            string Script = @"INSERT INTO tb_cliente (Nm_Nome,
                                                     Ed_endereco,
                                                     CNPJ,
                                                     CPF,
                                                     Em_Email,
                                                     Nm_numero
                                                     )
                                                     VALUES 
                                                     (@Nm_Nome,
                                                     @Ed_endereco,
                                                     @CNPJ,
                                                     @CPF,
                                                     @Em_Email,
                                                     @Nm_numero
                                                     )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Ed_endereco", dto.Ed_endereco));
            parms.Add(new MySqlParameter("CNPJ", dto.CNPJ));
            parms.Add(new MySqlParameter("CPF", dto.CPF));
            parms.Add(new MySqlParameter("Em_Email", dto.Em_Email));
            parms.Add(new MySqlParameter("Nm_numero", dto.Nm_numero));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(ClienteDTO dto)
        {
            string Script = @"UPDATE tb_cliente SET Nm_Nome = @Nm_Nome,
                                                    Ed_endereco = @Ed_endereco,
                                                    CNPJ = @CNPJ,
                                                    CPF = @CPF,
                                                    Em_Email = @Em_Email,
                                                    Nm_numero = @Nm_numero
                                              WHERE Id_Cliente = @Id_Cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Ed_endereco", dto.Ed_endereco));
            parms.Add(new MySqlParameter("CNPJ", dto.CNPJ));
            parms.Add(new MySqlParameter("CPF", dto.CPF));
            parms.Add(new MySqlParameter("Em_Email", dto.Em_Email));
            parms.Add(new MySqlParameter("Nm_numero", dto.Nm_numero));
            parms.Add(new MySqlParameter("Id_Cliente", dto.Id_Cliente));
      



            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public void Remover(int id)
        {
            string Script = @"DELETE FROM tb_cliente WHERE Id_Cliente = @Id_Cliente ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Cliente", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<ClienteDTO> Listar()
        {
            string Script = @"SELECT *FROM tb_cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id_Cliente = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.Nm_numero = reader.GetString("Nm_numero");
                dto.CNPJ = reader.GetString("CNPJ");
                dto.CPF = reader.GetString("CPF");
                dto.Ed_endereco = reader.GetString("Ed_endereco");
                dto.Em_Email = reader.GetString("Em_Email");
     


                lista.Add(dto);

            }
            reader.Close();
            return lista;

        }
        public List<ClienteDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_cliente where Nm_Nome like @Nm_Nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id_Cliente = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.Nm_numero = reader.GetString("Nm_numero");
                dto.CNPJ = reader.GetString("CNPJ");
                dto.CPF = reader.GetString("CPF");
                dto.Ed_endereco = reader.GetString("Ed_endereco");
                dto.Em_Email = reader.GetString("Em_Email");
                dto.fk_id_funcionario_cliente = reader.GetInt32("fk_id_funcionario_cliente ");

                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
        public List<ClienteDTO> ConsultarpoID(int id)
        {
            string script = @"select * from tb_cliente where Id_Cliente like @Id_Cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Cliente", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id_Cliente = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.Nm_numero = reader.GetString("Nm_numero");
                dto.CNPJ = reader.GetString("CNPJ");
                dto.CPF = reader.GetString("CPF");
                dto.Ed_endereco = reader.GetString("Ed_endereco");
                dto.Em_Email = reader.GetString("Em_Email");
              


                lista.Add(dto);

            }
            reader.Close();
            return lista;

        }
    }
}
