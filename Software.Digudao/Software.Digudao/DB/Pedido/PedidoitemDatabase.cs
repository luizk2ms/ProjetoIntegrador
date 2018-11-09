using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Pedido
{
    class PedidoitemDatabase
    {
        public int Salvar(PedidoitemDTO dto)
        {
            string script = @"INSERT INTO tb_pedidoitem (Id_PedidoItem,Produto_id_Produto) VALUES (@Id_PedidoItem,@Produto_id_Produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Produto_id_Produto", dto.Produto_id_Produto));
            parms.Add(new MySqlParameter("Id_PedidoItem", dto.Id_PedidoItem));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int id)
        {
            string script = @"DELETE *FROM tb_pedido_item WHERE Id_PedidoItem= @Id_PedidoItem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_PedidoItem", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoitemDTO> ConsultarPorPedido(int Id_PedidoItem)
        {
            string script = @"SELECT * FROM FROM tb_pedido_item WHERE Id_PedidoItem= @Id_PedidoItem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_PedidoItem", Id_PedidoItem));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoitemDTO> lista = new List<PedidoitemDTO>();
            while (reader.Read())
            {
                PedidoitemDTO dto = new PedidoitemDTO();
                dto.Id_PedidoItem = reader.GetInt32("Id_PedidoItem");
                dto.Pedido_id_Pedido = reader.GetInt32("Pedido_id_Pedido");
                dto.Produto_id_Produto = reader.GetInt32("Produto_id_Produto");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
