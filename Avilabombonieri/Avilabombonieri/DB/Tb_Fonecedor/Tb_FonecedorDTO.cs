using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Tb_Fonecedor
{
    class Tb_FonecedorDTO
    {
        public int Id_Fornecedor { get; set; }
        public int id_produto { get; set; }
        public string en_endereço { get; set; }
        public string cnpj { get; set; }
        public decimal teltelefone { get; set; }
        public decimal cel_celular { get; set; }
    }
}
