using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Produto
{
    class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Salvar(dto);
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

        public List<ProdutoViewDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();
        }

        public List<ProdutoViewDTO> ConsultarporNome(string nome)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<ProdutoViewDTO> ConsultarpoId(int ID)
        {
            ProdutoDatabase db = new ProdutoDatabase]();
            return db.ConsultarporId(ID);
        }
    }
}
