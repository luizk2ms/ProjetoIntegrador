using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Controle_de_Usuario
{
    class UsuarioPermisoes
    {
        class UsuarioPermissoes
        {
            public string Cliente { get; set; }
            public string Funcionario { get; set; }
            public string Usuario { get; set; }
            public string Produto { get; set; }
            public string Compra { get; set; }
            public string Estoque { get; set; }
            public string Fornecedor { get; set; }
            public string FluxoDeCaixa { get; set; }
            public string FolhaDePgmt { get; set; }

            public UsuarioPermissoes Permissoes(string Cod)
            {
                UsuarioPermissoes user = new UsuarioPermissoes();
                user.Cliente = Cod.Substring(0, 5);
                user.Funcionario = Cod.Substring(6, 5);
                user.Usuario = Cod.Substring(12, 5);
                user.Produto = Cod.Substring(24, 5);
                user.Compra = Cod.Substring(30, 5);
                user.Estoque = Cod.Substring(42, 5);
                user.Fornecedor = Cod.Substring(48, 5);
                user.FluxoDeCaixa = Cod.Substring(54, 5);
                user.FolhaDePgmt = Cod.Substring(60, 5);

                return user;
            }
        }
    }
}
