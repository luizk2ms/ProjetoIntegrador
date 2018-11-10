using MySql.Data.MySqlClient;
using prototipos.DB.Fornecedor;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public void Cadastrar(FuncionarioDTO dto)
        {
            string Script = @"INSERT Funcionario(Login, Nm_Nome, Data_nascimento, CPF, RG, Endereco, Complemento, Cargo, observacao)
                                          VALUES(@Login, @Nm_Nome, @Data_nascimento, @CPF, @RG, @Endereco, @Complemento, @Cargo, @observacao)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", dto.Id_Funcionario));
            parms.Add(new MySqlParameter("lg_login", dto.lg_login));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("nm_numero", dto.nm_numero));
            parms.Add(new MySqlParameter("sn_senha", dto.sn_senha));
            parms.Add(new MySqlParameter("tl_empresa", dto.tl_empresa));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
            parms.Add(new MySqlParameter("ds_endereço", dto.ds_endereço));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("dt_datadeentrada", dto.dt_datadeentrada));
            parms.Add(new MySqlParameter("dt_datasaida", dto.dt_datasaida));
            parms.Add(new MySqlParameter("id_FolhadePagamento", dto.id_FolhadePagamento));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }

        internal FuncionarioDTO logar(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDTO> ConsultarFuncionario(int CPF)
        {
            string script = $"SELECT * FROM Funcionario WHERE CPF like '%{CPF}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> Funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dados = new FuncionarioDTO();
                dados.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dados.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");
                dados.Nm_Nome = reader.GetString("Nm_Nome");
                dados.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dados.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dados.cpf_cpf = reader.GetInt32("cpf_cpf");
                dados.cp_cep = reader.GetInt32("cp_cep");
                dados.ds_endereço = reader.GetString("ds_endereço");
                dados.cr_cargo = reader.GetString("cr_cargo");
                dados.lg_login = reader.GetString("lg_login");
                dados.nm_numero = reader.GetInt32("nm_numero");
                dados.sn_senha = reader.GetInt32("sn_senha");
                dados.tl_empresa = reader.GetInt32("tl_empresa");
                dados.uf_uf = reader.GetString("uf_uf");
                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }

        public void RemoverFuncionario(int id)
        {
            string script = @"DELETE FROM Funcionario WHERE id_Funcionario = @id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            string script = @"UPDATE Funcionario SET Usuario = @Usuario,
                                                       NomeF = @Nm_Nome,
                                             Data_nascimento = @Data_nascimento,
                                                         CPF = @CPF,
                                                          RG = @RG,
                                                    Endereco = @Endereco,
                                                 Complemento = @Complemento,
                                                       Cargo = @Cargo,
                                                  observacao = @observacao

                                         WHERE Id_Funcionario = @Id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", dto.Id_Funcionario));
            parms.Add(new MySqlParameter("lg_login", dto.lg_login));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("nm_numero", dto.nm_numero));
            parms.Add(new MySqlParameter("sn_senha", dto.sn_senha));
            parms.Add(new MySqlParameter("tl_empresa", dto.tl_empresa));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
            parms.Add(new MySqlParameter("ds_endereço", dto.ds_endereço));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("dt_datadeentrada", dto.dt_datadeentrada));
            parms.Add(new MySqlParameter("dt_datasaida", dto.dt_datasaida));
            parms.Add(new MySqlParameter("id_FolhadePagamento", dto.id_FolhadePagamento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string Script = @"SELECT *FROM Funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.nm_numero = reader.GetInt32("nm_numero");
                dto.lg_login = reader.GetString("lg_login");
                dto.sn_senha = reader.GetInt32("sn_senha");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");

                lista.Add(dto);

            }
            return lista;

        }


        public List<FuncionarioDTO> ListarPorId(int id)
        {
            string script = @"select * from Funcionario where Id_Funcionario like @Id_Funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.nm_numero = reader.GetInt32("nm_numero");
                dto.lg_login = reader.GetString("lg_login");
                dto.sn_senha = reader.GetInt32("sn_senha");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");

                lista.Add(dto);

            }
            return lista;

        }
        public List<FuncionarioDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from Funcionario where Id_Funcionario like @Id_Funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.tl_empresa = reader.GetInt32("tl_empresa");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cpf_cpf = reader.GetInt32("cpf_cpf");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.nm_numero = reader.GetInt32("nm_numero");
                dto.lg_login = reader.GetString("lg_login");
                dto.sn_senha = reader.GetInt32("sn_senha");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");



                lista.Add(dto);

            }
            return lista;
        }
    }
}
