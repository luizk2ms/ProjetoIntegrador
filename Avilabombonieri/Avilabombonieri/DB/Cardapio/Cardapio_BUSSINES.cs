using Frei.ProjetoIntegrador.Academia.Validacoes;
using prototipos.DB.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Cardapio
{
    class Cardapio_BUSSINES
    {
        public int Salvar(Cardapio_DTO dto)
        {
            exReg reg = new exReg();
            reg.ValidarValor(Convert.ToString(dto.Valor));

            if (dto.NomeProduto == null)
            {
                throw new ArgumentException("O campo Nome do Produto está em branco, por favor preencher.");
            }
            //if (dto.Tipo == null)
            //{
            //    throw new ArgumentException("O campo Tipo está em branco, por favor preencher.");
            //}


            Cardapio_DATABASE db = new Cardapio_DATABASE();
            return db.Salvar(dto);
        }

        public void Alterar(Cardapio_DTO dto)
        {

            exReg reg = new exReg();
            reg.ValidarValor(Convert.ToString(dto.Valor));

            if (dto.NomeProduto == null)
            {
                throw new ArgumentException("O campo Nome do Produto está em branco, por favor preencher.");
            }
            //if (dto.Tipo == null)
            //{
            //    throw new ArgumentException("O campo Tipo está em branco, por favor preencher.");
            //} 
            Cardapio_DATABASE db = new Cardapio_DATABASE();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            Cardapio_DATABASE db = new Cardapio_DATABASE();
            db.Remover(ID);
        }
    }
}

      