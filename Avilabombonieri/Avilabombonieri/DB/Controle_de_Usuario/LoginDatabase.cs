//using MySql.Data.MySqlClient;
//using Software.Digudao.DB.db;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Software.Digudao.DB.Controle_de_Usuario
//{
//    class LoginDatabase
//    {
//        public UsuarioDTO Autenticar(string nome, string senha)
//        {
//            string script = @"SELECT * FROM tb_usuario WHERE nm_Usuario = @nm_Usuario AND ds_Senha = @ds_Senha";

//            List<MySqlParameter> parms = new List<MySqlParameter>();
//            parms.Add(new MySqlParameter("nm_Usuario", nome));
//            parms.Add(new MySqlParameter("ds_Senha", senha));

//            Database db = new Database();
//            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

//            UsuarioDTO dto = new UsuarioDTO();
//            if (reader.Read())
//            {
//                dto.id_Usuario = reader.GetInt32("id_Usuario");
//                dto.nm_Usuario = reader.GetString("nm_Usuario");
//                dto.ds_Senha = reader.GetString("ds_Senha");
//                dto.Cod_Perm = reader.GetString("Cod_Perm");
//                dto.ds_Situacao = reader.GetBoolean("ds_Situacao");
//            }
//            return dto;
//        }
//    }
//}



