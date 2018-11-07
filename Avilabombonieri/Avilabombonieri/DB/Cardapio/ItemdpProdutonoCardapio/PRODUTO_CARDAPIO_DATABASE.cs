using Lanchonha.Banco.BD.Cardapio.ItemdpProdutonoCardapio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Cardapio.ItemdpProdutonoCardapio
{
    class PRODUTO_CARDAPIO_DATABASE
    {
        public int Salvar(ProdutonoCardapioDTO dto)
        {
            string script = @"insert into tb_produto_no_cardapio (fk_id_estoque_para_pc,fk_id_cardapio_para_pc)
                                                     values     (@fk_id_estoque_para_pc,@fk_id_cardapio_para_pc)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_id_estoque_para_pc", dto.FKidEstoque));
            parms.Add(new MySqlParameter("fk_id_cardapio_para_pc", dto.FkidCardapio));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int Id)
        {
            string script = @"delete from tb_produto_no_cardapio where id_produto_no_cardapiopc like @id_produto_no_cardapiopc";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto_no_cardapiopc", Id));
            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);

        }
    }
}
