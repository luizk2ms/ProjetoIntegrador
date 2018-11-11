using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Produto
{
    class ProdutoDTO
    {
        public int Id_Produto { get; set; }
        public string Nm_Nome { get; set; }
        public string Tm_Tamanho { get; set; }
        public string Ql_Quantidade { get; set; }
        public string pç_preço { get; set; }
        public int fk_id_funcionario_produto { get; set; }
    }
}
