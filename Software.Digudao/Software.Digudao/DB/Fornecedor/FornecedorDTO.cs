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
        public string en_endereco { get; set; }
        public string Nm_nome { get; set; }
        public string cnpj { get; set; }
        public string tel_telefone { get; set; }
        public string cel_celular { get; set; }
        public string uf_uf { get; set; }
        public string ds_descricao { get; set; }
        public string email { get; set; }
        public string br_bairro { get; set; }
        public string cd_cidade { get; set; }
        public string nr_numero { get; set; }
        public string CEP { get; set; }
        public decimal pr_preco_unitario { get; set; }
        public int fk_ID_Funcionario { get; set; }

    }
}
