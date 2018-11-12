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
        public string Qn_QuantidadeEmKg { get; set; }
        public string Tm_tamanho { get; set; }
        public DateTime dt_data { get; set; }
        public string Pc_preco { get; set; }
        public int fk_id_produto_estoque { get; set; }
        public string Qn_Quantidade { get; set; }
    }
}
