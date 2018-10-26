using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Tb_PedidoCompra
{
    class Tb_PedidoCompraDTO
    {
        public int Id_PedidoCompra { get; set; }
        public int Fk_Pedido_id_pedido { get; set; }
    }
}
