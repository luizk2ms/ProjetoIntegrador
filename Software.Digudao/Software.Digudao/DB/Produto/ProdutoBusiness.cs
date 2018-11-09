using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Produto
{
    class ProdutoBusiness
    {
            public int Cadastrar(ProdutoDTO dto)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.Cadastrar(dto);
            }

            public void Alterar(ProdutoDTO dto)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                db.Alterar(dto);
            }
            public int Remover(int id)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                db.Remover(id);
            }

            public List<ProdutoDTO> Listar()
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.Listar();
            }

            public List<ProdutoDTO> ConsultarPorId(int ID)
            {
                ProdutoDatabase db = new ProdutoDatabase();
                return db.ConsultarPorId(ID);
            }

        
    }
}
