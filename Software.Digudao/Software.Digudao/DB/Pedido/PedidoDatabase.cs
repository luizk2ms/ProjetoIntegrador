using MySql.Data.MySqlClient;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoDatabase
    {
        public int Salvar(PedidoDTO dto)
        {
            string Script = @"INSERT INTO Tb_Pedido (Id_Pedido,
                                                     Cliente_id_cliente,
                                                     qn_quantidade,
                                                     Tm_tamanho_tamanho,
                                                     pc_preçoporcaixa_caixa,
                                                     pedidoid_produto)
                                                     VALUES 
                                                     (@Id_Pedido,
                                                     @Cliente_id_cliente,
                                                     @qn_quantidade,
                                                     @Tm_tamanho_tamanho,
                                                     @pc_preçoporcaixa_caixa,
                                                     @pedidoid_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", dto.Id_Pedido));
            parms.Add(new MySqlParameter("Cliente_id_cliente", dto.Cliente_id_cliente));
            parms.Add(new MySqlParameter("qn_quantidade", dto.qn_quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho_tamanho", dto.Tm_tamanho_tamanho));
            parms.Add(new MySqlParameter("pc_preçoporcaixa_caixa", dto.pc_preçoporcaixa_caixa));
            parms.Add(new MySqlParameter("pedidoid_produto", dto.pedidoid_produto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(PedidoDTO dto)
        {
            string Script = @"UPDATE INTO Tb_Pedido (Id_Pedido,
                                                     Cliente_id_cliente,
                                                     qn_quantidade,
                                                     Tm_tamanho_tamanho,
                                                     pc_preçoporcaixa_caixa,
                                                     pedidoid_produto)
                                                     VALUES 
                                                     (@Id_Pedido,
                                                     @Cliente_id_cliente,
                                                     @qn_quantidade,
                                                     @Tm_tamanho_tamanho,
                                                     @pc_preçoporcaixa_caixa,
                                                     @pedidoid_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", dto.Id_Pedido));
            parms.Add(new MySqlParameter("Cliente_id_cliente", dto.Cliente_id_cliente));
            parms.Add(new MySqlParameter("qn_quantidade", dto.qn_quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho_tamanho", dto.Tm_tamanho_tamanho));
            parms.Add(new MySqlParameter("pc_preçoporcaixa_caixa", dto.pc_preçoporcaixa_caixa));
            parms.Add(new MySqlParameter("pedidoid_produto", dto.pedidoid_produto));

            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public void Remover(int id)
        {
            string Script = @"SELECT FROM Tb_Pedido WHERE Id_Pedido = @Id_Pedido ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<PedidoDTO> Listar()
        {
            string Script = @"SELECT *FROM Tb_Pedido";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO dto = new PedidoDTO();
                dto.Id_Pedido = reader.GetInt32("Id_Pedido");
                dto.Cliente_id_cliente = reader.GetInt32("Cliente_id_cliente");
                dto.qn_quantidade = reader.GetInt32("qn_quantidade");
                dto.Tm_tamanho_tamanho = reader.GetString("Tm_tamanho_tamanho");
                dto.pc_preçoporcaixa_caixa = reader.GetInt32("pc_preçoporcaixa_caixa");
                dto.pedidoid_produto = reader.GetInt32("pedidoid_produto");

                lista.Add(dto);

            }
            return lista;

        }
   
        public List<PedidoDTO> ConsultarpoID(int id)
        {
            string script = @"select * from Tb_Pedido where Id_Pedido like @Id_Pedido";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Tb_Pedido", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<PedidoDTO> lista = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO dto = new PedidoDTO();
                dto.Id_Pedido = reader.GetInt32("Id_Pedido");
                dto.Cliente_id_cliente = reader.GetInt32("Cliente_id_cliente");
                dto.qn_quantidade = reader.GetInt32("qn_quantidade");
                dto.Tm_tamanho_tamanho = reader.GetString("Tm_tamanho_tamanho");
                dto.pc_preçoporcaixa_caixa = reader.GetInt32("pc_preçoporcaixa_caixa");
                dto.pedidoid_produto = reader.GetInt32("pedidoid_produto");

                lista.Add(dto);

            }
            return lista;
        }
    }
}
    
