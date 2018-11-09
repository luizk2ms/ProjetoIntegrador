using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Produto
{
    class ProdutoBusiness
    {
        class JogadoresBusiness
        {
            public int Salvar(Produto_Compra_DTO dto)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.Cadastrar(dto);
            }

            public void Alterar(Produto_Compra_DTO dto)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                db.AlterarProdutos(dto);
            }
            public void Remover(int ID)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                db.RemoverPRodutos(ID);
            }

            public List<Produto_Compra_DTO> Listar()
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.Listar();
            }

            public List<Produto_Compra_DTO)> ConsultarporNome(string nome)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.C(nome);
            }

            public List<Produto_Compra_DTO> ConsultarpoId(int ID)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.ConsultarPorId(ID);
            }

        }
    }
}
