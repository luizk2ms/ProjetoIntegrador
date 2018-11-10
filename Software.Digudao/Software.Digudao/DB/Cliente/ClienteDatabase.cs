using MySql.Data.MySqlClient;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Cliente
{
    class ClienteDatabase
    {
        public int Salvar(ClienteDTO dto)
        {
            string Script = @"INSERT INTO Tb_Cliente (Nm_Nome,
                                                     ds_endereço,
                                                     cp_cep,
                                                     cpf_cpf,
                                                     tl_empresa,
                                                     cel_celular,
                                                     em_email)
                                                     VALUES 
                                                     (@Nm_Nome,
                                                     @ds_endereço,
                                                     @cp_cep,
                                                     @cpf_cpf,
                                                     @tl_empresa,
                                                     @cel_celular,
                                                     @em_email)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("ds_endereço", dto.ds_endereço));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("tl_empresa", dto.tl_empresa));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("em_email", dto.em_email));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(ClienteDTO dto)
        {
            string Script = @"UPDATE Tb_Cliente SET Nm_Nome = @Nm_Nome,
                                                    ds_endereço = @ds_endereço,
                                                    cp_cep = @cp_cep,
                                                    cpf_cpf = @cpf_cpf,
                                                    tl_empresa = @tl_empresa,
                                                    cel_celular = @cel_celular,
                                                    em_email = @em_email,
                                              WHERE Id_Cliente = @Id_Cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("ds_endereço", dto.ds_endereço));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("tl_empresa", dto.tl_empresa));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("em_email", dto.em_email));
            parms.Add(new MySqlParameter("Id_Cliente", dto.Id_Cliente));

            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public void Remover(int id)
        {
            string Script = @"SELECT FROM Tb_Cliente WHERE Id_Cliente = @Id_Cliente ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Cliente", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<ClienteDTO> Listar()
        {
            string Script = @"SELECT *FROM Tb_Cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.Id_Cliente = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.em_email = reader.GetString("em_email");

                lista.Add(dto);

            }
            return lista;

        }
        public List<ClienteDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from Tb_Cliente where Nm_Nome like @Nm_Nome";
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
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.em_email = reader.GetString("em_email");

                lista.Add(dto);

            }
            return lista;
        }
        public List<ClienteDTO> ConsultarpoID(int id)
        {
            string script = @"select * from Tb_Cliente where Id_Cliente like @Id_Cliente";
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
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.em_email = reader.GetString("em_email");

                lista.Add(dto);

            }
            return lista;

        }
    }
}
