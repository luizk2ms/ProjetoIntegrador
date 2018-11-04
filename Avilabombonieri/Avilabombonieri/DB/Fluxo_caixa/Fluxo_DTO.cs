using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Fluxo_caixa
{
    class Fluxo_DTO
    {
        public int Id_fluxo_de_caixa { get; set; }
        public decimal vl_total_recebido { get; set; }
        public bool fluxo_caixa_diario { get; set; }
        public bool fluxo_caixa_mensal { get; set; }
        public int FKIDfuncionarios { get; set; }
    }
}
