using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Produto
{
    class ProdutoDataBase
    {
        public int Cadastrar(ProdutoDTO dto)
        {
            string script = @"INSERT Funcionario(Nm_Nome,Tm_Tamanho,Pc_Preco,Ql_Quantidade)
                                          VALUES(@Nm_Nome,@Tm_Tamanho,@Pc_Preco,@Ql_Quantidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Pc_Preco", dto.Pc_Preco));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Ql_Quantidade", dto.Ql_Quantidade));
            parms.Add(new MySqlParameter("Tm_Tamanho", dto.Tm_Tamanho));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int ConsultarPorId(int id)
        {
            string script = @"SELECT *FROM Tb_Produto WHERE id_Produto like @id_Produto ";
            List<MyqlParameter> parms = new List<MyqlParameter>();
            parms.Add(new MySqlParameter("Tb_Produto", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoViewDTO> produto = new List<ProdutoViewDTO>();
            while (reader.Read)

            {
                ProdutoViewDTO dto = new ProdutoViewDTO();
                dto.Id_Produto = reader.GeatInt32("Id_Produto");
                dto.Nm_Nome = reader.GeatString("Nm_Nome");
                dto.Pc_Preco = reader.GeaDecimal("Pc_Preco");
                dto.Ql_Quantidade = reader.GeatInt("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GeatString("Tm_Tamanho");




            }
            reader.close();
            return produto;
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


        public List<ProdutoDTO> ConsultarProdutos()
        {
            string script = @"SELECT * FROM Tb_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> Produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GeatInt32("Id_Produto");
                dto.Nm_Nome = reader.GeatString("Nm_Nome");
                dto.Pc_Preco = reader.GeaDecimal("Pc_Preco");
                dto.Ql_Quantidade = reader.GeatInt("Ql_Quantidade");
                dto.Tm_Tamanho = reader.GeatString("Tm_Tamanho");

                Produtos.Add(dados);
            }

            reader.Close();
            return Produtos;

        }
    }
}
