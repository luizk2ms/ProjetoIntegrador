﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Cliente
{
    class ClienteDTO
    {
        public int Id_Cliente { get; set; }
        public string Nm_Nome { get; set; }
        public string Endereco { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
    }
}