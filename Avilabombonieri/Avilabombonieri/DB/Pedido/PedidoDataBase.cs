using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Pedido
{
    class PedidoDatabase
    {
        public PedidoDTO Cadastrar(PedidoDTO dto)
        {
            string script = @"INSERT Funcionario(Id_Pedido, pc_preçoporcaixa_caixa, Cliente_id_cliente,qn_quantidade,Tm_tamanho_tamanho)
                                          VALUES(@Id_Pedido,@pc_preçoporcaixa_caixa,@Cliente_id_cliente,@qn_quantidade,@Tm_tamanho_tamanho)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", dto.Id_Pedido));
            parms.Add(new MySqlParameter("Cliente_id_cliente", dto.Cliente_id_cliente));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("pc_preçoporcaixa_caixa", dto.pc_preçoporcaixa_caixa));
            parms.Add(new MySqlParameter("qn_quantidade", dto.qn_quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho_tamanho", dto.Tm_tamanho_tamanho));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

    }
    public List<PedidoViewDTO> ConsultarporNome(string Nome)
    {
        string script = @"select * from Tb_Pedido where Nm_Nome like @Nm_Nome";
        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("Nm_Nome", Nome + "%"));
        Database db = new Database();
        MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
        List<PedidoViewDTO> lista = new List<PedidoViewDTO>();
        while (reader.Read())
        {
            PedidoViewDTO dto = new PedidoViewDTO();
            dto.Id_Pedido = reader.GetInt32("Id_Pedido");
            dto.id_produto = reader.GetInt32("id_produto");
            dto.pc_preçoporcaixa_caixa = reader.GetDecimal("pc_preçoporcaixa_caixa");
            dto.qn_quantidade = reader.GetInt32("qn_quantidade");
            dto.Tm_tamanho_tamanho = reader.GetString("Tm_tamanho_tamanho");
            dto.Cliente_id_cliente = reader.GetInt32("Cliente_id_cliente");


            lista.Add(dto);

        }
        return lista;
    }
    public List<PedidoViewDTO> ConsultarpoID(int id)
    {
        string script = @"select * from Tb_Pedido where Id_Pedido like @Id_Pedido";
        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("Id_Pedido", id));
        Database db = new Database();
        MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
        List<PedidoViewDTO> lista = new List<PedidoViewDTO>();
        while (reader.Read())
        {
            PedidoViewDTO dto = new PedidoViewDTO();
            dto.Id_Pedido = reader.GetInt32("Id_Pedido");
            dto.id_produto = reader.GetInt32("id_produto");
            dto.pc_preçoporcaixa_caixa = reader.GetDecimal("pc_preçoporcaixa_caixa");
            dto.qn_quantidade = reader.GetInt32("qn_quantidade");
            dto.Tm_tamanho_tamanho = reader.GetString("Tm_tamanho_tamanho");
            dto.Cliente_id_cliente = reader.GetInt32("Cliente_id_cliente");

            lista.Add(dto);

        }
        return lista;
    }



        public void Alterar(PedidoDTO dto)
        {
            string Script = @"UPDATE Tb_Cliente SET pc_preçoporcaixa_caixa = @pc_preçoporcaixa_caixa,
                                                    qn_quantidade = @qn_quantidade,
                                                    Tm_tamanho_tamanho = @cp_cep,
                                                    id_produto = @cpf_cpf,
                                                    Cliente_id_cliente = @tl_empresa,
                                              WHERE Id_Pedido = @Id_Pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Pedido", dto.Id_Pedido));
            parms.Add(new MySqlParameter("Cliente_id_cliente", dto.id_produto));
            parms.Add(new MySqlParameter("id_produto", dto.pc_preçoporcaixa_caixa));
            parms.Add(new MySqlParameter("pc_preçoporcaixa_caixa", dto.qn_quantidade));
            parms.Add(new MySqlParameter("qn_quantidade", dto.Tm_tamanho_tamanho));
            parms.Add(new MySqlParameter("Tm_tamanho_tamanho", dto.Cliente_id_cliente));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<PedidoDTO> ConsultarFuncionarios()
        {
            string script = @"SELECT * FROM Pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoDTO> pedidos = new List<PedidoDTO>();
            while (reader.Read())
            {
                PedidoDTO dados = new PedidoDTO();
                dto.Id_Pedido = reader.GetInt32("Id_Pedido");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.pc_preçoporcaixa_caixa = reader.GetDecimal("pc_preçoporcaixa_caixa");
                dto.qn_quantidade = reader.GetInt32("qn_quantidade");
                dto.Tm_tamanho_tamanho = reader.GetString("Tm_tamanho_tamanho");
                dto.Cliente_id_cliente = reader.GetInt32("Cliente_id_cliente");

                pedidos.Add(dados);
            }

            reader.Close();
            return pedidos;
        }
    }
}
