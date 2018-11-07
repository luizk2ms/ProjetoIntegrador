using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Cardapio
{
    class Cardapio_DTO
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public int FkFuncionario { get; set; }
    }
}
