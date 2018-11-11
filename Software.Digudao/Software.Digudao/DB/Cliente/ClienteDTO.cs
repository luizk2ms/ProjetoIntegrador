﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Cliente
{
    class ClienteDTO
    {
        public int Id_Cliente { get; set; }
        public string Nm_Nome { get; set; }
        public string Ed_endereco { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Em_Email { get; set; }
        public string Nm_numero { get; set; }
        public int fk_id_funcionario_cliente { get; set; }
    }
}
