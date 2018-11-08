using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Produto
{
    class ProdutoViewDTO
    {
        public int Id_Produto { get; set; }
        public string Nm_Nome { get; set; }
        public string Tm_Tamanho { get; set; }
        public decimal Pc_Preco { get; set; }
        public int Ql_Quantidade { get; set; }
    }
}
