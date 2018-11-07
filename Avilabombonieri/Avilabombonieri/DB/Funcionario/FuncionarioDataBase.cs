using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public FuncionarioDTO Cadastrar(FuncionarioDTO dto)
        {
            string script = @"INSERT Funcionario(Login, Nm_Nome, Data_nascimento, CPF, RG, Endereco, Complemento, Cargo, observacao)
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
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        internal FuncionarioDTO logar(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDTO> ConsultarFuncionariosFiltro(string CPF)
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
                dados.cpf_cpf = reader.GetString("cpf_cpf");
                dados.cp_cep = reader.GetString("cp_cep");
                dados.ds_endereço = reader.GetString("ds_endereço");
                dados.cr_cargo = reader.GetString("cr_cargo");
                dados.lg_login = reader.GetString("lg_login");
                dados.nm_numero = reader.GetString("nm_numero");
                dados.sn_senha = reader.GetInt32("sn_senha");
                dados.tl_empresa = reader.GeatString("tl_empresa");
                dados.uf_uf = reader.GetString("uf_uf");
                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }

        public int RemoverFuncionario(string id)
        {
            string script = @"DELETE FROM Funcionario WHERE idFuncionario = @idFuncionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idFuncionario", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
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

        public List<FuncionarioViewDTO> Listar()
        {
            string Script = @"SELECT *FROM Tb_Cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<FuncionarioViewDTO> lista = new List<FuncionarioViewDTO>();
            while (reader.Read)
            {
                FuncionarioViewDTO dto = new FuncionarioViewDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Cliente");
                dto.lg_login = reader.GetString("lg_login");
                dto.Nm_Nome = reader.GetInt("Nm_Nome");
                dto.nm_numero = reader.GetInt("nm_numero");
                dto.sn_senha = reader.GetInt("sn_senha");
                dto.uf_uf = reader.GetInt("uf_uf");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.cp_cep = reader.GetString("cp_cep");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.ds_endereço = reader.GetString("ds_endereço");
                dto.dt_datadeentrada = reader.GetString("dt_datadeentrada");
                dto.dt_datasaida = reader.GetString("dt_datasaida");


                lista.Add(dto);

            }
            return lista;
        }


            public int ConsultarPorId(int id)
        {
            string script = @"SELECT *FROM Tb_Funcionario WHERE id_Funcionario like id_Funcionario";

            List<MyqlParameter> parms = new List<MyqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO funcionario = new FuncionarioDTO();
            if (reader.Read())
            {
                funcionario.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                funcionario.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");
                funcionario.Nm_Nome = reader.GetString("Nm_Nome");
                funcionario.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                funcionario.dt_datasaida = reader.GetDateTime("dt_datasaida");
                funcionario.cpf_cpf = reader.GetString("cpf_cpf");
                funcionario.cp_cep = reader.GetString("cp_cep");
                funcionario.ds_endereço = reader.GetString("ds_endereço");
                funcionario.cr_cargo = reader.GetString("cr_cargo");
                funcionario.lg_login = reader.GetString("lg_login");
                funcionario.nm_numero = reader.GetString("nm_numero");
                funcionario.sn_senha = reader.GetInt32("sn_senha");
                funcionario.tl_empresa = reader.GeatString("tl_empresa");
                funcionario.uf_uf = reader.GetString("uf_uf");

                funcionario.Add(funcionario);

            }
            reader.close();
            
        }
    }
}
