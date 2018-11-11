using Frei.ProjetoIntegrador.Academia.Validacoes;
using Frei.ProjetoIntegrador.Digudão.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Controle_de_Usuario
{
    class UsuarioBUsiness
    {
        class UsuarioBusiness
        {
            public int CadastrarUsuario(UsuarioDTO dto)
            {
                exReg regex = new exReg();
                regex.ValidarSenha(dto.ds_Senha);

                UsuarioDatabase db = new UsuarioDatabase();
                return db.CadastrarUsuario(dto);
            }

            public int AlterarUsuario(UsuarioDTO dto)
            {
                exReg regex = new exReg();
                regex.ValidarSenha(dto.ds_Senha);

                UsuarioDatabase db = new UsuarioDatabase();
                return db.AlterarUsuario(dto);
            }

            public int RemoverUsuario(int id)
            {
                UsuarioDatabase db = new UsuarioDatabase();
                return db.RemoverUsuario(id);
            }

        }
    }
}
