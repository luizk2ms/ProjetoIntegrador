﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorDTO
    {
        public int Id_Fornecedor { get; set; }
        public int FK_produto { get; set; }
        public string en_endereço { get; set; }
        public int cnpj { get; set; }
        public int tel_contem { get; set; }
        public int cel_celular { get; set; }
        public string uf_uf { get; set; }
        public string ds_descricao { get; set; }
        public string el_email { get; set; }
        public int Nm_numero { get; set; }
        public string Nm_nome { get; set; }
    }
}
