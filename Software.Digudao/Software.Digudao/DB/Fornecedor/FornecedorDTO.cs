using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorDTO
    {
        public int Id_Fornecedor { get; set; }
        public int id_produto { get; set; }
        public string en_endereço { get; set; }
        public string cnpj { get; set; }
        public string tel_telefone { get; set; }
        public string cel_celular { get; set; }
        public string uf_uf { get; set; }
        public string ds_descricao { get; set; }
        public string el_email { get; set; }
        public int fk_ID_Funcionario { get; set; }
        public string Nm_nome { get; set; }
    }
}
