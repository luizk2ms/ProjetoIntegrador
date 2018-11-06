using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoBusiness
    {
        public int Salvar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Remover(ID);
        }

        public List<PedidoViewDTO> Listar()
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Listar();
        }

        public List<PedidoViewDTO> ConsultarporNome(string nome)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<PedidoDTO> ConsultarpoId(int ID)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.ConsultarporId(ID);
        }
    }
}
