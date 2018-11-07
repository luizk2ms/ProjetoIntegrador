using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonha.Banco.BD.Cardapio.ItemdpProdutonoCardapio
{
    class ProdutonoCardapioDTO
    {
        public int IdProdutonoCardapio { get; set; }
        public int FkidCardapio { get; set; }
        public int FKidEstoque { get; set; }
    }
}
