using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int Id_Funcionario { get; set; }
        public string nm_nomefunci { get; set; }
        public int ds_endereco { get; set; }
        public string cp_cep { get; set; }
        public string cpf_cpf { get; set; }
        public string tl_telefone { get; set; }
        public string cel_celular { get; set; }
        public string cr_cargo { get; set; }
        public DateTime dt_datadeentrada { get; set; }
        public DateTime dt_datasaida { get; set; }
        public string nm_numero { get; set; }
        public string nm_empresa { get; set; }


    }
}
