using MySql.Data.MySqlClient;
using Software.Digudao.DB.db;
using System.Collections.Generic;

namespace prototipos.DB.Fornecedor
{
    class FornecedorDatabase
    {
        public void Salvar(FornecedorDTO dto)
        {
            string Script = @"INSERT tb_fonecedor(en_endereço, Nm_nome, cnpj, tel_telefone, cel_celular, uf_uf, ds_descricao, email, br_bairro, cd_cidade, nr_numero, CEP, pr_preco_unitario)
                                             VALU(@en_endereço, @Nm_nome, @cnpj , @tel_telefone, @cel_celular, @uf_uf, @ds_descricao, @email, @br_bairro, @cd_cidade, @nr_numero, @CEP, @pr_preco_unitario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("en_endereco", dto.en_endereco));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("email", dto.email));
            parms.Add(new MySqlParameter("br_bairro", dto.br_bairro));
            parms.Add(new MySqlParameter("cd_cidade", dto.cd_cidade));
            parms.Add(new MySqlParameter("nr_numero", dto.nr_numero));
            parms.Add(new MySqlParameter("CEP", dto.CEP));
            parms.Add(new MySqlParameter("pr_preco_unitario", dto.pr_preco_unitario));
            

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);
        }

        public List<FornecedorDTO> ConsultarFornecedor(int id)
        {
            string script = @"select * from tb_fonecedor where Id_Fornecedor like @Id_Fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Fornecedor", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.br_bairro = reader.GetString("br_bairro");
                dto.cd_cidade = reader.GetString("cd_cidade");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.CEP = reader.GetString("CEP");
                dto.cnpj = reader.GetString("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.email = reader.GetString("email");
                dto.en_endereco = reader.GetString("en_endereco");
                dto.fk_ID_Funcionario = reader.GetInt32("fk_ID_Funcionario");
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.nr_numero = reader.GetString("nr_numero");
                dto.pr_preco_unitario = reader.GetDecimal("pr_preco_unitario");
                dto.tel_telefone = reader.GetString("tel_telefone");
                dto.uf_uf = reader.GetString("uf_uf");

                lista.Add(dto);
            }
            return lista;
        }

        public int RemoverFornecedor(int id)
        {
            string script = @"DELETE FROM tb_fonecedor WHERE  Id_Fornecedor like @Id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Fornecedor", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        public void Alterar(FornecedorDTO dto)
        {
            string Script = @"UPDATE tb_fonecedor SET  br_bairro = @br_bairro,
                                                       cd_cidade = @cd_cidade,
                                                       cel_celular = @cel_celular,
                                                       CEP = @CEP,
                                                       cnpj = @cnpj,
                                                       ds_descricao = @ds_descricao,
                                                       email = @email,
                                                       en_endereco = @en_endereco,
                                                       fk_ID_Funcionario = @fk_ID_Funcionario,
                                                       Id_Fornecedor = @Id_Fornecedor,
                                                       Nm_nome = @Nm_nome,
                                                       nr_numero = @nr_numero,
                                                       pr_preco_unitario = @pr_preco_unitario,
                                                       tel_telefone = @tel_telefone,
                                                       uf_uf = @uf_uf
                                                       WHERE Id_Fornecedor = @Id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("br_bairro", dto.br_bairro));
            parms.Add(new MySqlParameter("cd_cidade", dto.cd_cidade));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("CEP", dto.CEP));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("email", dto.email));
            parms.Add(new MySqlParameter("en_endereco", dto.en_endereco));
            parms.Add(new MySqlParameter("fk_ID_Funcionario", dto.fk_ID_Funcionario));
            parms.Add(new MySqlParameter("Id_Fornecedor", dto.Id_Fornecedor));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("nr_numero", dto.nr_numero));
            parms.Add(new MySqlParameter("pr_preco_unitario", dto.pr_preco_unitario));
            parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);


        }

        public List<FornecedorDTO> Listar()
        {
            string script = @"select * from tb_fonecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                parms.Add(new MySqlParameter("br_bairro", dto.br_bairro));
                parms.Add(new MySqlParameter("cd_cidade", dto.cd_cidade));
                parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
                parms.Add(new MySqlParameter("CEP", dto.CEP));
                parms.Add(new MySqlParameter("cnpj", dto.cnpj));
                parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
                parms.Add(new MySqlParameter("email", dto.email));
                parms.Add(new MySqlParameter("en_endereco", dto.en_endereco));
                parms.Add(new MySqlParameter("fk_ID_Funcionario", dto.fk_ID_Funcionario));
                parms.Add(new MySqlParameter("Id_Fornecedor", dto.Id_Fornecedor));
                parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
                parms.Add(new MySqlParameter("nr_numero", dto.nr_numero));
                parms.Add(new MySqlParameter("pr_preco_unitario", dto.pr_preco_unitario));
                parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
                parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));


                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }


        public List<FornecedorDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from tb_fonecedor where Nm_nome like @Nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Nm_nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.br_bairro = reader.GetString("br_bairro");
                dto.cd_cidade = reader.GetString("cd_cidade");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.CEP = reader.GetString("CEP");
                dto.cnpj = reader.GetString("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.email = reader.GetString("email");
                dto.en_endereco = reader.GetString("en_endereco");
                dto.fk_ID_Funcionario = reader.GetInt32("fk_ID_Funcionario");
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.nr_numero = reader.GetString("nr_numero");
                dto.pr_preco_unitario = reader.GetDecimal("pr_preco_unitario");
                dto.tel_telefone = reader.GetString("tel_telefone");
                dto.uf_uf = reader.GetString("uf_uf");
               





                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
    }
}

    

