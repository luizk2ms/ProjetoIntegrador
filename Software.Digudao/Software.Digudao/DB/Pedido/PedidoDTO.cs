﻿using System;
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
        public string qn_quantidade { get; set; }
        public string Tm_tamanho_tamanho { get; set; }
        public decimal FK_preço { get; set; }
        public int pedidoid_produto { get; set; }
        public string tl_total { get; set; }
       

    }
}
