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
            db.RemoverPedido(ID);
        }

        public List<PedidoDTO> Listar()
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Listar();
        }

        public List<PedidoDTO> ConsultarporNome(string Nome)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.ConsultarporNome(Nome);
        }

        public List<PedidoDTO> ConsultarPorID(int id)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.ConsultarPorID(id);
        }
    }
}
