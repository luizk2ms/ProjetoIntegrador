using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoDTO
    {
        public int Id_Pedido { get; set; }
        public int Cliente_id_cliente { get; set; }
        public int qn_quantidade { get; set; }
        public int Tm_tamanho_tamanho { get; set; }
        public int pc_preçoporcaixa_caixa { get; set; }
        public int id_produto { get; set; }
      
    }
}
