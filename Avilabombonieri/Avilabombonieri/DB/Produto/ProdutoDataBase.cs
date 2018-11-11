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
            string script = @"INSERT Funcionario(Ds_Descricao,Nm_Nome,Dt_Datadevalidade,Kg_kilo,Lt_litros,Ml,Vl_Valor)
                                          VALUES(@Ds_Descricao,@Nm_Nome,@Dt_Datadevalidade,@Kg_kilo,@Lt_litros,@Ml,@Vl_Valor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Ds_Descricao", dto.Ds_Descricao));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Dt_Datadevalidade", dto.Dt_Datadevalidade));
            parms.Add(new MySqlParameter("Kg_kilo", dto.Kg_kilo));
            parms.Add(new MySqlParameter("Lt_litros", dto.Lt_litros));
            parms.Add(new MySqlParameter("Ml", dto.Ml));
            parms.Add(new MySqlParameter("Vl_Valor", dto.Vl_Valor));
           


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
            List<ProdutoDTO> produto = new List<ProdutoDTO>();
            while (reader.Read)

            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id_Produto = reader.GeatInt32("Id_Produto");
                dto.Nm_Nome = reader.GeatString("Nm_Nome");
                dto.Vl_Valor = reader.GeaDecimal("Pc_Preco");
                dto.Ml = reader.GeaDecimal("Ml");
                dto.Lt_litros = reader.GeaDecimal("Lt_litros");
                dto.Kg_kilo = reader.GeaDecimal("Kg_kilo");
                dto.Dt_Datadevalidade = reader.GeatString("Tm_Tamanho");
                dto.Ds_Descricao = reader.GeatString("Ds_Descricao");




            }
            reader.close();
            return produto;
        }

        public int RemoverPRodutos(int id)
        {
            string script = @"DELETE FROM Tb_Produto WHERE Id_Produto = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Produto", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarProdutos(ProdutoDTO dto)
        {
            string script = @"UPDATE Funcionario SET 
                                                    Ds_Descricao = @Ds_Descricao,
                                                    Nm_Nome = @Nm_Nome,
                                                    Dt_Datadevalidade = @Dt_Datadevalidade,
                                                    Kg_kilo = @Kg_kilo,
                                                    Lt_litros = @Lt_litros,
                                                    Ml = @Ml,
                                                    Vl_Valor = @Vl_Valor,

                                                    WHERE Id_Produto = @Id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Produto", dto.Id_Produto));
            parms.Add(new MySqlParameter("Ds_Descricao", dto.Ds_Descricao));
            parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));
            parms.Add(new MySqlParameter("Dt_Datadevalidade", dto.Dt_Datadevalidade));
            parms.Add(new MySqlParameter("Kg_kilo", dto.Kg_kilo));
            parms.Add(new MySqlParameter("Lt_litros", dto.Lt_litros));
            parms.Add(new MySqlParameter("Ml", dto.Ml));
            parms.Add(new MySqlParameter("Vl_Valor", dto.Vl_Valor));

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
                dto.Vl_Valor = reader.GeaDecimal("Pc_Preco");
                dto.Ml = reader.GeaDecimal("Ml");
                dto.Lt_litros = reader.GeaDecimal("Lt_litros");
                dto.Kg_kilo = reader.GeaDecimal("Kg_kilo");
                dto.Dt_Datadevalidade = reader.GeatString("Tm_Tamanho");
                dto.Ds_Descricao = reader.GeatString("Ds_Descricao");


                Produtos.Add(dto);
            }

            reader.Close();
            return Produtos;

        }
    }
}
