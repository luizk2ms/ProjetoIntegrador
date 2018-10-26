using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int Id_Funcionario { get; set; }
        public string Nm_Nome { get; set; }
        public string ds_endereço { get; set; }
        public string cp_cep { get; set; }
        public string cpf_cpf { get; set; }
        public decimal tl_empresa { get; set; }
        public decimal cel_celular { get; set; }
        public string cr_cargo { get; set; }
        public decimal sl_salario { get; set; }
        public decimal hr_horadeentrada { get; set; }
        public decimal hrs_horadesaida { get; set; }
    }
}
