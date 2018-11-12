using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Estoque
{
    class EstoqueBusiness
    {
        public void SalvarEstoque(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.SalvarEstoque(dto);
        }

        public void Alterar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(ID);
        }

        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();
        }

        public List<EstoqueDTO> ConsultarporNome(string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<EstoqueDTO> ConsultarpoID(int id)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarpoID(id);
        }
    }
}
