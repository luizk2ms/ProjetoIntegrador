using MySql.Data.MySqlClient;
using Software.Digudao.DB.db;
using System.Collections.Generic;

namespace prototipos.DB.Pedido
{
    class PedidoDatabase
    {
        public int Salvar(PedidoDTO dto)
        {
            string Script = @"INSERT INTO tb_pedidoitem (Produto_id_Produto,
                                                     Pedido_id_Pedido,
                                                     Funcionario_id_Funcionario,
                                                     Cm_Cadastro,
                                                     data)
                                                     VALUES 
                                                     (@Produto_id_Produto,
                                                     @Pedido_id_Pedido,
                                                     @Funcionario_id_Funcionario,
                                                     @Cm_Cadastro,
                                                     @data)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Produto_id_Produto", dto.Produto_id_Produto));
            parms.Add(new MySqlParameter("Pedido_id_Pedido", dto.Pedido_id_Pedido));
            parms.Add(new MySqlParameter("Funcionario_id_Funcionario", dto.Funcionario_id_Funcionario));
            parms.Add(new MySqlParameter("Cm_Cadastro", dto.Cm_Cadastro));
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(PedidoDTO dto)
        {
            string Script = @"UPDATE INTO tb_pedidoitem (Produto_id_Produto = @Produto_id_Produto,
                                                     Pedido_id_Pedido = @Pedido_id_Pedido,
                                                     Funcionario_id_Funcionario = @Pedido_id_Pedido,
                                                     Cm_Cadastro = @Cm_Cadastro,
                                                     data = @data
                                                  WHERE Id_PedidoItem = @Id_PedidoItem)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", dto.Id_PedidoItem));
            parms.Add(new MySqlParameter("Pedido_id_Pedido", dto.Pedido_id_Pedido));
            parms.Add(new MySqlParameter("Produto_id_Produto", dto.Produto_id_Produto));
            parms.Add(new MySqlParameter("Cm_Cadastro", dto.Cm_Cadastro));
            parms.Add(new MySqlParameter("data", dto.data));
         

            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public void Remover(int id)
        {
            string Script = @"SELECT FROM tb_pedidoitem WHERE Id_Pedido = @Id_Pedido ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<PedidoDTO> Listar()
        {
            string Script = @"SELECT *FROM tb_pedidoitem";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO dto = new PedidoDTO();
                dto.Id_PedidoItem = reader.GetInt32("Id_PedidoItem");
                dto.Pedido_id_Pedido = reader.GetInt32("Pedido_id_Pedido");
                dto.Produto_id_Produto = reader.GetInt32("Produto_id_Produto");
                dto.Cm_Cadastro = reader.GetInt32("Cm_Cadastro");
                dto.data = reader.GetDateTime("data");

                lista.Add(dto);

            }
            return lista;

        }

        public List<PedidoDTO> ConsultarpoID(int id)
        {
            string script = @"select * from tb_pedidoitem where Id_PedidoItem like @Id_PedidoItem";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("tb_pedidoitem", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO dto = new PedidoDTO();
                dto.Id_PedidoItem = reader.GetInt32("Id_PedidoItem");
                dto.Pedido_id_Pedido = reader.GetInt32("Pedido_id_Pedido");
                dto.Produto_id_Produto = reader.GetInt32("Produto_id_Produto");
                dto.Cm_Cadastro = reader.GetInt32("Cm_Cadastro");
                dto.data = reader.GetDateTime("data");
                lista.Add(dto);

            }
            return lista;
        
        }
    }
}
    
