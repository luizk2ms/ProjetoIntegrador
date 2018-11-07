using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Folha_de_Pagamento
{
    class Folha_de_Pagamento_DTO
    {
        public int id_FolhadePagamento { get; set; }
        public int id_Funcionario { get; set; }
        public string Nm_Nome { get; set; }
        public string cr_cargo { get; set; }
        public decimal vl_salarioBruto { get; set; }
        public int ds_horae { get; set; }
        public int ds_horas { get; set; }
        public string ob_observacao { get; set; }
        public int ds_diastrabalhados { get; set; }
        public DateTime Dt_Data_de_Registro { get; set; }
    }
}
