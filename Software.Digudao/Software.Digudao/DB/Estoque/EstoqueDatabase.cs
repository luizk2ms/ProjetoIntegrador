using MySql.Data.MySqlClient;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Estoque
{
    class EstoqueDatabase
    {
        public int SalvarEstoque (EstoqueDTO dto)
        {
            string Script = @"INSERT INTO Tb_Estoque(Qn_Quantidade,
                                                     Tm_tamanho,
                                                     dt_datavl,
                                                     nm_nome,
                                                     pc_preçoporcaixa,
                                                     id_produto_id,
                                                     kl_kilo)
                                                     VALUES(@Qn_Quantidade,
                                                     @Tm_tamanho,
                                                     @dt_datavl,
                                                     @nm_nome,
                                                     @pc_preçoporcaixa,
                                                     @id_produto_id,
                                                     @kl_kilo)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Qn_Quantidade",dto.Qn_Quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("dt_datavl", dto.dt_datavl));
            parms.Add(new MySqlParameter("nm_nome", dto.nm_nome));
            parms.Add(new MySqlParameter("pc_preçoporcaixa", dto.pc_preçoporcaixa));
            parms.Add(new MySqlParameter("kl_kilo", dto.kl_kilo));
            parms.Add(new MySqlParameter("id_produto_id", dto.id_produto_id));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(EstoqueDTO dto)
        {
            string Script = @"UPDATE Tb_Estoque SET Qn_Quantidade = @Qn_Quantidade,
                                                     Tm_tamanho = @Tm_tamanho,
                                                     dt_datavl = @dt_datavl,
                                                     nm_nome = @nm_nome,
                                                     id_produto_id = @id_produto_id,
                                                     pc_preçoporcaixa = @pc_preçoporcaixa,
                                                     kl_kilo = @kl_kilo
                                               WHERE Id_Estoque = @Id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Qn_Quantidade", dto.Qn_Quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("dt_datavl", dto.dt_datavl));
            parms.Add(new MySqlParameter("nm_nome", dto.nm_nome));
            parms.Add(new MySqlParameter("pc_preçoporcaixa", dto.pc_preçoporcaixa));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("kl_kilo", dto.kl_kilo));
            parms.Add(new MySqlParameter("id_produto_id", dto.id_produto_id));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);

        }

        public void Remover(int id)
        {
            string Script = @"SELECT FROM Tb_Estoque WHERE Id_Estoque = @Id_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Estoque", id ));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<EstoqueDTO> Listar()
        {
            string Script = @"SELECT *FROM Tb_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Cliente");
                dto.nm_nome = reader.GetString("nm_nome");
                dto.pc_preçoporcaixa = reader.GetDecimal("pc_preçoporcaixa");
                dto.kl_kilo = reader.GetDecimal("kl_kilo");
                dto.id_produto_id = reader.GetInt32("id_produto_id");
                dto.Qn_Quantidade = reader.GetInt32("Qn_Quantidade");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_datavl = reader.GetDateTime("dt_datavl");

                lista.Add(dto);

            }
            return lista;

        }
        public List<EstoqueDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from Tb_Estoque where nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Cliente");
                dto.nm_nome = reader.GetString("nm_nome");
                dto.pc_preçoporcaixa = reader.GetDecimal("pc_preçoporcaixa");
                dto.kl_kilo = reader.GetDecimal("kl_kilo");
                dto.id_produto_id = reader.GetInt32("id_produto_id");
                dto.Qn_Quantidade = reader.GetInt32("Qn_Quantidade");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_datavl = reader.GetDateTime("dt_datavl"); ;

                lista.Add(dto);

            }
            return lista;
        }
        public List<EstoqueDTO> ConsultarpoID(int id)
        {
            string script = @"select * from Tb_Estoque where Id_Estoque like @Id_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Estoque", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Cliente");
                dto.nm_nome = reader.GetString("nm_nome");
                dto.pc_preçoporcaixa = reader.GetDecimal("pc_preçoporcaixa");
                dto.kl_kilo = reader.GetDecimal("kl_kilo");
                dto.id_produto_id = reader.GetInt32("id_produto_id");
                dto.Qn_Quantidade = reader.GetInt32("Qn_Quantidade");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_datavl = reader.GetDateTime("dt_datavl");

            }
            return lista;
            
        }
        
    }
}
