using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Estoque
{
    class EstoqueDTO
    {
        public int Id_Estoque { get; set; }
        public int Qn_Quantidade { get; set; }
        public string Tm_tamanho { get; set; }
        public DateTime dt_datavl { get; set; }
        public string nm_nome { get; set; }
        public decimal pc_preçoporcaixa { get; set; }
        public decimal kl_kilo { get; set; }
        public int id_produto_id { get; set; }
    }
}
