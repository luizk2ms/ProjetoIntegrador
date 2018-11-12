//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Software.Digudao.DB.Controle_de_Usuario
//{
//    class LoginBusiness
//    {
//        public UsuarioDTO Autenticar(string nome, string senha)
//        {
//            if (nome == string.Empty)
//                throw new ArgumentException("O nome não pode ficar em branco.");

//            if (senha == string.Empty)
//                throw new ArgumentException("A senha não pode ficar em branco.");

//            LoginDatabase db = new LoginDatabase();
//            return db.Autenticar(nome, senha);
//        }
//    }
//}
