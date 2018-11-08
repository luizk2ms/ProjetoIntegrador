using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Produto
{
    class ProdutoDatabase
    {
        public int Cadastrar(ProdutoDTO dto)
        {
            string script = @"INSERT Tb_Produto(Nm_Nome,Tm_Tamanho,Pc_Preco,Ql_Quantidade)
                                          VALUES(@Nm_Nome,@Tm_Tamanho,@Pc_Preco,@Ql_Quantidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Pc_Preco", dto.Pc_Preco));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));
            

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ProdutoDTO> ConsultarPorId(int ID)
        {
            string script = @"SELECT *FROM Tb_Produto WHERE id_Produto like @id_Produto ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Produto", ID + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GeatInt32("Id_Produto");
                dto.Nm_Nome = reader.GeatString("Nm_Nome");
                dto.Pc_Preco = reader.GeaDecimal("Pc_Preco");
                dto.Ql_Quantidade = reader.GeatInt("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GeatString("Tm_Tamanho");

                lista.Add(dto);
            }
            return lista;
        }

        public int RemoverPRodutos(int id)
        {
            string script = @"DELETE FROM Funcionario WHERE idFuncionario = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Produto", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarProdutos(ProdutoDTO dto)
        {
            string script = @"UPDATE Funcionario SET 
                                                    Nm_Nome = @Nm_Nome,
                                                    Tm_Tamanho = @Tm_Tamanho,
                                                    Pc_Preco = @Pc_Preco,
                                                    Ql_Quantidade = @Ql_Quantidade

                                                    WHERE Id_Produto = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Produto", dto.Id_Produto));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));
            parms.Add(new MySqlParameter("Pc_Preco", dto.Pc_Preco));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        public List<ProdutoDTO> Listar()
        {
            string script = @"SELECT * FROM Tb_Produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GetInt32("Id_Produto");
                dto.Nm_Nome = reader.GetString("Nm_Nome");
                dto.Pc_Preco = reader.GetDecimal("Pc_Preco");
                dto.Ql_Quantidade = reader.GetInt32("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GeatString("Tm_Tamanho");

                lista.Add(dto);
            }

            reader.Close();
            return lista;

        }
    }
}
