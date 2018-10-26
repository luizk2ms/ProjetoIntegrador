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
        public string Tm_Tamanho { get; set; }
        public string Ql_Quantidade { get; set; }
        public decimal pç_preço { get; set; }
        public int id_Estoque { get; set; }
    }
}
