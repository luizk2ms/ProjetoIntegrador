using Software.Digudao.DB.db;
using System.Collections.Generic;

namespace prototipos.DB.Estoque
{
    class EstoqueDatabase
    {
        public void SalvarEstoque(EstoqueDTO dto)
        {
            string Script = @"INSERT INTO tb_estoque(Qn_Quantidade,
                                                     Tm_tamanho,
                                                     dt_data,
                                                     Pc_preco,
                                                     fk_id_produto_estoque,
                                                     Qn_QuantidadeEmKg)
                                                     VALUES(@Qn_Quantidade,
                                                     @Tm_tamanho,
                                                     @dt_data,
                                                     @Pc_preco,
                                                     @fk_id_produto_estoque,
                                                     @Qn_QuantidadeEmKg)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Qn_Quantidade", dto.Qn_Quantidade));
            parms.Add(new MySqlParameter("dt_data", dto.dt_data));
            parms.Add(new MySqlParameter("Pc_preco", dto.Pc_preco));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("Qn_QuantidadeEmKg", dto.Qn_QuantidadeEmKg));
            parms.Add(new MySqlParameter("fk_id_produto_estoque", dto.fk_id_produto_estoque));




            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(EstoqueDTO dto)
        {
            string Script = @"UPDATE tb_estoque SET Qn_Quantidade = @Qn_Quantidade,
                                                     Tm_tamanho = @Tm_tamanho,
                                                     dt_data = @dt_data,
                                                     fk_id_produto_estoque = @fk_id_produto_estoque,
                                                     Pc_preco = @Pc_preco,
                                                     Qn_QuantidadeEmKg = @Qn_QuantidadeEmKg
                                               WHERE Id_Estoque = @Id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Qn_Quantidade", dto.Qn_Quantidade));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("dt_data", dto.dt_data));
            parms.Add(new MySqlParameter("Pc_preco", dto.Pc_preco));
            parms.Add(new MySqlParameter("Tm_tamanho", dto.Tm_tamanho));
            parms.Add(new MySqlParameter("Qn_QuantidadeEmKg", dto.Qn_QuantidadeEmKg));
            parms.Add(new MySqlParameter("fk_id_produto_estoque", dto.fk_id_produto_estoque));
            parms.Add(new MySqlParameter("Id_Estoque", dto.fk_id_produto_estoque));


            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);

        }

        public void Remover(int id)
        {
            string Script = @"SELECT FROM tb_estoque WHERE Id_Estoque = @Id_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Estoque", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<EstoqueDTO> Listar()
        {
            string Script = @"SELECT *FROM tb_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Estoque");
                dto.Pc_preco = reader.GetString("Pc_preco");
                dto.fk_id_produto_estoque = reader.GetInt32("fk_id_produto_estoque");
                dto.Qn_Quantidade = reader.GetString("Qn_Quantidade");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_data = reader.GetDateTime("dt_data");
                dto.Qn_QuantidadeEmKg = reader.GetString("Qn_QuantidadeEmKg");


                lista.Add(dto);

            }
            return lista;

        }
        public List<EstoqueDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_estoque where nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Estoque");
                dto.Pc_preco = reader.GetString("Pc_preco");
                dto.fk_id_produto_estoque = reader.GetInt32("fk_id_produto_estoque");
                dto.Qn_QuantidadeEmKg = reader.GetString("Qn_QuantidadeEmKg");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_data = reader.GetDateTime("dt_data");
                dto.Qn_Quantidade = reader.GetString("Qn_Quantidade");

                lista.Add(dto);

            }
            return lista;
        }
        public List<EstoqueDTO> ConsultarpoID(int id)
        {
            string script = @"select * from tb_estoque where Id_Estoque like @Id_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Estoque", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id_Estoque = reader.GetInt32("Id_Estoque");
                dto.Pc_preco = reader.GetString("Pc_preco");
                dto.fk_id_produto_estoque = reader.GetInt32("fk_id_produto_estoque");
                dto.Qn_QuantidadeEmKg = reader.GetString("Qn_QuantidadeEmKg");
                dto.Tm_tamanho = reader.GetString("Tm_tamanho");
                dto.dt_data = reader.GetDateTime("dt_data");
                dto.Qn_Quantidade = reader.GetString("Qn_Quantidade");

            }
            return lista;

        }


    }
}
