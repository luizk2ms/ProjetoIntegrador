//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Avilabombonieri.DB.Cardapio
//{
//    class Cardapio_DATABASE
//    {
//        public int Salvar(Cardapio_DATABASE dto)
//        {
//            string script = @"insert into tb_cardapio(nm_produto,vl_valor,tp_tipo,fk_id_funcionario_cp)
//                                            values (@nm_produto,@vl_valor,@tp_tipo,@fk_id_funcionario_cp)";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("nm_produto", dto.NomeProduto));
//            parms.Add(new MySqlParameter("vl_valor", dto.Valor));
//            parms.Add(new MySqlParameter("tp_tipo", dto.Tipo));
//            parms.Add(new MySqlParameter("fk_id_funcionario_cp", dto.FkFuncionario));

//            DataBase db = new DataBase();
//            return db.ExecuteInsertScriptWithPk(script, parms);
//        }

//        internal int Salvar(Cardapio_DTO dto)
//        {
//            throw new NotImplementedException();
//        }

//        public void Alterar(Cardapio_DATABASE dto)
//        {
//            string script = @"update tb_cardapio set nm_produto=@nm_produto,
//                                                     vl_valor=@vl_valor,
//                                                     tp_tipo=@tp_tipo,
//                                                     fk_id_funcionario_cp=@fk_id_funcionario_cp
//                                               where id_cardapio =@id_cardapio";
//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_cardapio", dto.ID));
//            parms.Add(new MySqlParameter("nm_produto", dto.NomeProduto));
//            parms.Add(new MySqlParameter("vl_valor", dto.Valor));
//            parms.Add(new MySqlParameter("tp_tipo", dto.Tipo));
//            parms.Add(new MySqlParameter("fk_id_funcionario_cp", dto.FkFuncionario));

//            DataBase db = new DataBase();
//            db.ExecuteInsertScript(script, parms);

//        }

//        internal void Alterar(Cardapio_DTO dto)
//        {
//            throw new NotImplementedException();
//        }

//        public void Remover(int id)
//        {
//            string script = @"delete from tb_cardapio where id_cardapio like @id_cardapio";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_cardapio", id));

//            DataBase db = new DataBase();
//            db.ExecuteInsertScript(script, parms);
//        }

//        public List<Cardapio_DATABASE> Listar()
//        {
//            string script = @"select * from tb_cardapio";
//            List<MySqlParameter> parms = new List<MySqlParameter>();

//            DataBase db = new DataBase();
//            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
//            List<Cardapio_DATABASE> lista = new List<Cardapio_DATABASE>();
//            while (reader.Read())
//            {
//                Cardapio_DATABASE dto = new Cardapio_DATABASE();
//                dto.ID = reader.GetInt32("id_cardapio");
//                dto.NomeProduto = reader.GetString("nm_produto");
//                dto.Valor = reader.GetDecimal("vl_valor");
//                dto.Tipo = reader.GetString("tp_tipo");
//                dto.FkFuncionario = reader.GetInt32("fk_id_funcionario_cp");

//                lista.Add(dto);
//            }
//            reader.Close();
//            return lista;
//        }

//        public List<Cardapio_DATABASE> ConsultarporNome(string nome)
//        {
//            string script = @"select * from tb_cardapio where nm_produto like @nm_produto";
//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("nm_produto", nome + "%"));
//            DataBase db = new DataBase();
//            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
//            List<Cardapio_DATABASE> lista = new List<Cardapio_DATABASE>();
//            while (reader.Read())
//            {
//                Cardapio_DATABASE dto = new Cardapio_DATABASE();
//                dto.ID = reader.GetInt32("id_cardapio");
//                dto.NomeProduto = reader.GetString("nm_produto");
//                dto.Valor = reader.GetDecimal("vl_valor");
//                dto.Tipo = reader.GetString("tp_tipo");
//                dto.FkFuncionario = reader.GetInt32("fk_id_funcionario_cp");

//                lista.Add(dto);
//            }
//            reader.Close();
//            return lista;
//        }

//        public List<Cardapio_DATABASE> ConsultarporId(int Id)
//        {
//            string script = @"select * from tb_cardapio where id_cardapio like @id_cardapio";
//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_cardapio", Id + "%"));
//            DataBase db = new DataBase();
//            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
//            List<Cardapio_DATABASE> lista = new List<Cardapio_DATABASE>();
//            while (reader.Read())
//            {
//                Cardapio_DATABASE dto = new Cardapio_DATABASE();
//                dto.ID = reader.GetInt32("id_cardapio");
//                dto.NomeProduto = reader.GetString("nm_produto");
//                dto.Valor = reader.GetDecimal("vl_valor");
//                dto.Tipo = reader.GetString("tp_tipo");
//                dto.FkFuncionario = reader.GetInt32("fk_id_funcionario_cp");

//                lista.Add(dto);
//            }
//            reader.Close();
//            return lista;
//        }
//    }
//}
