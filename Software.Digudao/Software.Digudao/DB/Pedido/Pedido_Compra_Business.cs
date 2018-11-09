using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoBusiness
    {
        public PedidoDTO Cadastrar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Cadastrar(dto);
        }

        public void Alterar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.(dto);
        }
        public void Remover(int ID)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Remover(ID);
        }

        public List<PedidoDTO> Listar()
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Listar();
        }

        public List<PedidoDTO> ListarporNome(string Nome)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.(nome);
        }

        public List<PedidoDTO> ConsultarpoId(int ID)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.ConsultarporId(ID);
        }
    }
}
