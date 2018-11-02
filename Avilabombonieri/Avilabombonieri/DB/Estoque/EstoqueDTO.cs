using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Estoque
{
    class EstoqueDTO
    {
        public int Id_Estoque { get; set; }
        public string Qn_Quantidade { get; set; }
        public string Tm_tamanho { get; set; }
        public DateTime dt_data { get; set; }
        public string nm_nome { get; set; }
        public decimal Pc_preco { get; set; }
        public string Qn_QuantidadeEmKg { get; set; }
    }
}
