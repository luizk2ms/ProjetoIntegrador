﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Produto
{
    class ProdutoDTO
    {
        public int Id_Produto { get; set; }
        public string Nm_Nomepro { get; set; }
        public string Tm_Tamanho { get; set; }
        public string Ql_Quantidade { get; set; }
        public string pc_preco { get; set; }
        public int FkFornecedor { get; set; }
        public int fk_id_funcionario_produto { get; set; }
    }
}
