using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Produto
{
    class ProdutoBusiness
    {

        public void Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Salvar(dto);
        }

        public void Alterar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Remover(ID);
        }

        public List<ProdutoDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();
        }



        public List<ProdutoDTO> ConsultarpoID(int id)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.ConsultarpoID(id);
        }
        public List<ProdutoDTO> ConsultarporNome(string Nome)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.ConsultarporNome(Nome);
        }

        public List<ViewConsultarProdutosDTO> ConsultarporNomeView(string Nome)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.ConsultarporNomeView(Nome);
        }
    }
}
