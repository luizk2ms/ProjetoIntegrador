using System;
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
        public string ds_endereço { get; set; }
        public int cp_cep { get; set; }
        public int cpf_cpf { get; set; }
        public int tl_empresa { get; set; }
        public int cel_celular { get; set; }
        public string em_email { get; set; }



    }
}
