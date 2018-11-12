using Avilabombonieri.DB.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace prototipos.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public void Cadastrar(FuncionarioDTO dto)
        {
            string Script = @"INSERT tb_funcionario( nm_numero, tl_telefone, cel_celular,cr_cargo, ds_endereco, cpf_cpf,cp_cep,dt_datadeentrada,dt_datasaida,nm_empresa)
                                          VALUES(@nm_numero,@tl_telefone,@cel_celular,@cr_cargo,@ds_endereco,@cpf_cpf,@cp_cep,@dt_datadeentrada,@dt_datasaida,@nm_empresa)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            //parms.Add(new MySqlParameter("lg_login", dto.lg_login));
            
            parms.Add(new MySqlParameter("nm_numero", dto.nm_numero));
            //parms.Add(new MySqlParameter("sn_senha", dto.sn_senha));
            parms.Add(new MySqlParameter("tl_telefone", dto.tl_empresa));
            //parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
            parms.Add(new MySqlParameter("ds_endereco", dto.ds_endereço));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("dt_datadeentrada", dto.dt_datadeentrada));
            parms.Add(new MySqlParameter("dt_datasaida", dto.dt_datasaida));
            parms.Add(new MySqlParameter("nm_empresa", dto.Nomedaempresa));


            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }

        internal FuncionarioDTO logar(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDTO> ConsultarFuncionario(int CPF)
        {
            string script = $"SELECT * FROM tb_funcionario WHERE CPF like '%{CPF}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> Funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dados = new FuncionarioDTO();
                dados.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dados.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");
                dados.Nm_Nome = reader.GetString("nm_nomefunci");
                dados.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dados.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dados.cpf_cpf = reader.GetString("cpf_cpf");
                dados.cp_cep = reader.GetString("cp_cep");
                dados.ds_endereço = reader.GetString("ds_endereco");
                dados.cr_cargo = reader.GetString("cr_cargo");
                dados.lg_login = reader.GetString("lg_login");
                dados.nm_numero = reader.GetString("nm_numero");
                dados.sn_senha = reader.GetString("sn_senha");
                dados.tl_empresa = reader.GetString("tl_empresa");
                dados.uf_uf = reader.GetString("uf_uf");
                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }

        public void RemoverFuncionario(int id)
        {
            string script = @"DELETE FROM tb_funcionario WHERE id_Funcionario = @id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void AlterarFuncionario(FuncionarioDTO dto)
        {
            string script = @"UPDATE Funcionario SET Login, nm_nomefunci = @nm_nomefunci,
                                                            nm_numero = @nm_numero,
                                                            tl_empresa = @tl_empresa,
                                                            uf_uf = @uf_uf,
                                                            cel_celular = @cel_celular,
                                                            cr_cargo = @cr_cargo,
                                                            ds_endereco = @ds_endereco,
                                                            cpf_cpf = @cpf_cpf,
                                                            cp_ce = @cp_cep,
                                                            dt_datadeentrada = @dt_datadeentrada,
                                                            dt_datasaida = @dt_datasaida

                                         WHERE Id_Funcionario = @Id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", dto.Id_Funcionario));
            parms.Add(new MySqlParameter("lg_login", dto.lg_login));
            parms.Add(new MySqlParameter("nm_nomefunci", dto.Nm_Nome));
            parms.Add(new MySqlParameter("nm_numero", dto.nm_numero));
            parms.Add(new MySqlParameter("sn_senha", dto.sn_senha));
            parms.Add(new MySqlParameter("tl_empresa", dto.tl_empresa));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
            parms.Add(new MySqlParameter("ds_endereco", dto.ds_endereço));
            parms.Add(new MySqlParameter("cpf_cpf", dto.cpf_cpf));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("dt_datadeentrada", dto.dt_datadeentrada));
            parms.Add(new MySqlParameter("dt_datasaida", dto.dt_datasaida));
            parms.Add(new MySqlParameter("id_FolhadePagamento", dto.id_FolhadePagamento));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string Script = @"SELECT *FROM tb_funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.Nm_Nome = reader.GetString("nm_nomefunci");
                dto.tl_empresa = reader.GetString("tl_empresa");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.cpf_cpf = reader.GetString("cpf_cpf");
                dto.cp_cep = reader.GetString("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereco");
                dto.nm_numero = reader.GetString("nm_numero");
                dto.lg_login = reader.GetString("lg_login");
                dto.sn_senha = reader.GetString("sn_senha");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");

                lista.Add(dto);

            }
            reader.Close();
            return lista;

        }


        public List<FuncionarioDTO> ListarPorId(int id)
        {
            string script = @"select * from tb_funcionario where Id_Funcionario like @Id_Funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Funcionario", id + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.tl_empresa = reader.GetString("tl_empresa");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.cpf_cpf = reader.GetString("cpf_cpf");
                dto.cp_cep = reader.GetString("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereco");
                dto.nm_numero = reader.GetString("nm_numero");
                dto.lg_login = reader.GetString("lg_login");
                dto.sn_senha = reader.GetString("sn_senha");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");

                lista.Add(dto);

            }
            reader.Close();
            return lista;

        }
        public List<FuncionarioDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_funcionario where nm_nomefunci like @nm_nomefunci";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nomefunci", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.tl_empresa = reader.GetString("tl_telefone");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.cpf_cpf = reader.GetString("cpf_cpf");
                dto.cp_cep = reader.GetString("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereco");
                dto.nm_numero = reader.GetString("nm_numero");
                //dto.lg_login = reader.GetString("lg_login");
                //dto.sn_senha = reader.GetString("sn_senha");
                //dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.Nomedaempresa = reader.GetString("nm_empresa");


                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }

        public List<FuncionarioDTO> ConsultarporCPF(string CPF)
        {
            string script = @"select * from tb_funcionario where cpf_cpf like @cpf_cpf";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("cpf_cpf", CPF + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id_Funcionario = reader.GetInt32("Id_Funcionario");
                dto.tl_empresa = reader.GetString("tl_telefone");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.cpf_cpf = reader.GetString("cpf_cpf");
                dto.cp_cep = reader.GetString("cp_cep");
                dto.ds_endereço = reader.GetString("ds_endereco");
                dto.nm_numero = reader.GetString("nm_numero");
                //dto.lg_login = reader.GetString("lg_login");
                //dto.sn_senha = reader.GetString("sn_senha");
                //dto.uf_uf = reader.GetString("uf_uf");
                dto.dt_datasaida = reader.GetDateTime("dt_datasaida");
                dto.dt_datadeentrada = reader.GetDateTime("dt_datadeentrada");
                dto.cr_cargo = reader.GetString("cr_cargo");
                dto.Nomedaempresa = reader.GetString("nm_empresa");


                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
    }
}
