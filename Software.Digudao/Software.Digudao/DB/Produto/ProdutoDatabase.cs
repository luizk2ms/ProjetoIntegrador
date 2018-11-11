using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Produto
{
    class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO dto)
        {
            string Script = @"INSERT INTO tb_produto (Nm_Nome,
                                                     Tm_Tamanho,
                                                     Ql_Quantidade,
                                                     pç_preço,
                                                     fk_id_funcionario_produto)
                                                     VALUES 
                                                     (@Nm_Nome,
                                                     @Tm_Tamanho,
                                                     @Ql_Quantidade,
                                                     @pç_preço,
                                                     @fk_id_funcionario_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("pç_preço", dto.pç_preço));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(ProdutoDTO dto)
        {
            string Script = @"UPDATE tb_produto SET Nm_Nome = @Nm_Nome,
                                                    Tm_Tamanho = @Tm_Tamanho,
                                                    Ql_Quantidade = @Ql_Quantidade,
                                                    pç_preço = @pç_preço,
                                                    fk_id_funcionario_produto = @fk_id_funcionario_produto,
                                              WHERE Id_Produto = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("pç_preço", dto.pç_preço));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));


            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public void Remover(int id)
        {
            string Script = @"SELECT FROM tb_produto WHERE Id_Produto = @Id_Produto ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Produto", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<ProdutoDTO> Listar()
        {
            string Script = @"SELECT *FROM tb_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.pç_preço = reader.GetDecimal("pç_preço");
                dto.Ql_Quantidade = reader.GetInt32("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");





                lista.Add(dto);

            }
            return lista;

        }
        public List<ProdutoDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_produto where Nm_Nome like @Nm_Nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.pç_preço = reader.GetDecimal("pç_preço");
                dto.Ql_Quantidade = reader.GetInt32("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");

                lista.Add(dto);

            }
            return lista;
        }
        public List<ProdutoDTO> ConsultarpoID(int id)
        {
            string script = @"select * from tb_produto where Id_Cliente like @Id_Cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Cliente", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Cliente");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.pç_preço = reader.GetDecimal("pç_preço");
                dto.Ql_Quantidade = reader.GetInt32("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");

                lista.Add(dto);

            }
            return lista;
        }
    }
}
