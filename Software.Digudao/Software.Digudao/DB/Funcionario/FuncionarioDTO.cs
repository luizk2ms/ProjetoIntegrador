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
        public string Nm_Nome { get; set; }
        public string lg_login { get; set; }
        public string sn_senha { get; set; }
        public string ds_endereço { get; set; }
        public int cp_cep { get; set; }
        public int cpf_cpf { get; set; }
        public int tl_empresa { get; set; }
        public int cel_celular { get; set; }
        public string cr_cargo { get; set; }
        public DateTime dt_datadeentrada { get; set; }
        public DateTime dt_datasaida { get; set; }
        public int id_FolhadePagamento { get; set; }
        public string uf_uf { get; set; }
        public int nm_numero { get; set; }
        

    }
}
