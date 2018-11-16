using MySql.Data.MySqlClient;
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
        public void Salvar(ProdutoDTO dto)
        {
            string Script = @"INSERT INTO tb_produto (Nm_Nomepro,
                                                     Tm_Tamanho,
                                                     Ql_Quantidade,
                                                     pc_preco,
                                                      fk_id_fonrcedor,
                                                      fk_id_funcionario_produto)
                                                     VALUES 
                                                     (@Nm_Nomepro,
                                                     @Tm_Tamanho,
                                                     @Ql_Quantidade,
                                                     @pc_preco,
                                                     @fk_id_fonrcedor,
                                                     @fk_id_funcionario_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nomepro", dto.Nm_Nome));
            parms.Add(new MySqlParameter("pc_preco", dto.pç_preço));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));
            parms.Add(new MySqlParameter("fk_id_funcionario_produto", dto.fk_id_funcionario_produto));
            parms.Add(new MySqlParameter("fk_id_fonrcedor", dto.FkFornecedor));
            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }
        public void Alterar(ProdutoDTO dto)
        {
            string Script = @"UPDATE tb_produto SET Nm_Nomepro = @Nm_Nomepro,
                                                    Tm_Tamanho = @Tm_Tamanho,
                                                    Ql_Quantidade = @Ql_Quantidade,
                                                    pc_preco = @pc_preco,
                                                    fk_id_funcionario_produto = @fk_id_funcionario_produto,
                                                    fk_id_fonrcedor=@fk_id_fonrcedor
                                              WHERE Id_Produto = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nomepro", dto.Nm_Nome));
            parms.Add(new MySqlParameter("pc_preco", dto.pç_preço));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));
            parms.Add(new MySqlParameter("fk_id_funcionario_produto", dto.fk_id_funcionario_produto));
            parms.Add(new MySqlParameter("Id_Produto", dto.Id_Produto));
            parms.Add(new MySqlParameter("fk_id_fonrcedor", dto.FkFornecedor));




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
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nomepro");
                dto.pç_preço = reader.GetString("pc_preco");
                dto.Ql_Quantidade = reader.GetString("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");





                lista.Add(dto);

            }
            reader.Close();
            return lista;

        }
        public List<ProdutoDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_produto where Nm_Nomepro like @Nm_Nomepro";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nomepro", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nomepro");
                dto.pç_preço = reader.GetString("pc_preco");
                dto.Ql_Quantidade = reader.GetString("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");

                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
        public List<ProdutoDTO> ConsultarpoID(int id)
        {
            string script = @"select * from tb_produto where Id_Produto like @Id_Produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Cliente", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nomepro");
                dto.pç_preço = reader.GetString("pc_preco");
                dto.Ql_Quantidade = reader.GetString("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");

                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }

        public List<ViewConsultarProdutosDTO> ConsultarporNomeView(string Nome)
        {
            string script = @"select * from consultar_produtos where Nm_Nomepro like @Nm_Nomepro";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_Nomepro", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ViewConsultarProdutosDTO> lista = new List<ViewConsultarProdutosDTO>();
            while (reader.Read())
            {
                ViewConsultarProdutosDTO dto = new ViewConsultarProdutosDTO();
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nomepro");
                dto.pç_preço = reader.GetString("pc_preco");
                dto.Ql_Quantidade = reader.GetString("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.Nome_id_funcionario_produto = reader.GetString("nm_nomefunci");
                dto.NomeFornecedor = reader.GetString("Nm_nome");

                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
        public List<ProdutoDTO> ConsultarpoTamanho(string Tamanho)
        {
            string script = @"select * from tb_produto where Tm_Tamanho like @Tm_Tamanho";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Tm_Tamanho", Tamanho + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nomepro");
                dto.pç_preço = reader.GetString("pc_preco");
                dto.Ql_Quantidade = reader.GetString("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GetString("Tm_Tamanho");
                dto.fk_id_funcionario_produto = reader.GetInt32("fk_id_funcionario_produto");

                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
    }
}
