using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Produto
{
    class ProdutoBusiness
    {

            public void Salvar(ProdutoDTO dto)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                db.Salvar(dto);
            }

            public void Alterar(ProdutoDTO dto)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                db.Alterar(dto);
            }
            public void Remover(int ID)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                db.Remover(ID);
            }

            public List<ProdutoDTO> Listar()
            {
                ProdutoDataBase db = new ProdutoDataBase();
                return db.Listar();
            }



            public List<ProdutoDTO> ConsultarpoID(int id)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                return db.ConsultarpoID(id);
            }
            public List<ProdutoDTO> ConsultarporNome(string Nome)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                return db.ConsultarporNome(Nome);
            }

            public List<ViewConsultarProdutosDTO> ConsultarporNomeView(string Nome)
            {
                ProdutoDataBase db = new ProdutoDataBase();
                return db.ConsultarporNomeView(Nome);
            }
        }
    }
