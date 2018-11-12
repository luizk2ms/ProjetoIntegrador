//using MySql.Data.MySqlClient;
//using Software.Digudao.DB.db;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Software.Digudao.DB.Controle_de_Usuario
//{
//    class UsuarioDatabase
//    {
//        public int CadastrarUsuario(UsuarioDTO dto)
//        {
//            string script = @"INSERT tb_usuario(nm_Usuario, ds_Senha, Cod_Perm, ds_Situacao)
//                                         VALUES(@nm_Usuario, @ds_Senha, @Cod_Perm, @ds_Situacao)";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("nm_Usuario", dto.nm_Usuario));
//            parms.Add(new MySqlParameter("ds_Senha", dto.ds_Senha));
//            parms.Add(new MySqlParameter("Cod_Perm", dto.Cod_Perm));
//            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));
            

//            Database db = new Database();
//            return db.ExecuteInsertScriptWithPk(script, parms);
//        }

//        public int AlterarUsuario(UsuarioDTO dto)
//        {
//            string script = @"UPDATE tb_usuario SET nm_Usuario = @nm_Usuario,
//                                                      ds_Senha = @ds_Senha,
//                                                      Cod_Perm = @Cod_Perm,
//                                                   ds_Situacao = @ds_Situacao

//                                              WHERE id_Usuario = @id_Usuario";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_Usuario", dto.id_Usuario));
//            parms.Add(new MySqlParameter("nm_Usuario", dto.nm_Usuario));
//            parms.Add(new MySqlParameter("ds_Senha", dto.ds_Senha));
//            parms.Add(new MySqlParameter("Cod_Perm", dto.Cod_Perm));
//            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));

//            Database db = new Database();
//            return db.ExecuteInsertScriptWithPk(script, parms);
//        }

//        public int RemoverUsuario(int id)
//        {
//            string script = @"DELETE FROM tb_usuario WHERE id_Usuario = @id_Usuario";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("id_Usuario", id));

//            Database db = new Database();
//            return db.ExecuteInsertScriptWithPk(script, parms);
//        }

       
        
//    }
//}
