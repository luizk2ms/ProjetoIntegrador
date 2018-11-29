using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoDTO
    {
        public int Id_PedidoItem { get; set; }
        public int Produto_id_Produto { get; set; }
        public int Pedido_id_Pedido { get; set; }
        public int Funcionario_id_Funcionario { get; set; }
        public int Cm_Cadastro { get; set; }
        public DateTime data { get; set; }
        
       

    }
}
