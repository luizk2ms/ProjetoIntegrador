using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Produto
{
    class ProdutoDTO
    {
        public int Id_Produto { get; set; }
        public string Nm_Nome { get; set; }
        public string Ds_Descricao { get; set; }
        public string Vl_Valor { get; set; }
        public string Kg_kilo { get; set; }
        public decimal Ml { get; set; }
        public decimal Lt_litros { get; set; }
        public DateTime Dt_Datadevalidade { get; set; }
    }
}
