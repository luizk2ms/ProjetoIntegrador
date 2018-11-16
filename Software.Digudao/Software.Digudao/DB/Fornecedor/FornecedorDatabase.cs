using MySql.Data.MySqlClient;
using prototipos.DB.Estoque;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorDatabase
    {
        public void Salvar(FornecedorDTO dto)
        {
            string Script = @"INSERT tb_fonecedor(id_produto,en_endereço,cnpj,tel_telefone,cel_celular,uf_uf,ds_descricao,el_email,fk_ID_Funcionario ,Nm_nome,Bairro,Cidade,Numero,CEP,PrecoUnitario)
                                      VALUES     (@id_produto,@en_endereço,@cnpj,@tel_telefone,@cel_celular,@uf_uf,@ds_descricao,@el_email,@fk_ID_Funcionario,@Nm_nome,@Bairro,@Cidade,@Numero,@CEP,@PrecoUnitario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));
            parms.Add(new MySqlParameter("Bairro", dto.Bairro));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("CEP", dto.CEP));
            parms.Add(new MySqlParameter("Cidade", dto.Cidade));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("el_email", dto.el_email));
            parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));
            parms.Add(new MySqlParameter("fk_ID_Funcionario", dto.fk_ID_Funcionario));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("Numero", dto.Numero));
            parms.Add(new MySqlParameter("PrecoUnitario", dto.PrecoUnitario));
            parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));




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
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.tel_telefone = reader.GetString("tel_contem");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.cnpj = reader.GetString("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.el_email = reader.GetString("el_email");
                dto.en_endereço = reader.GetString("en_endereço");
                dto.fk_ID_Funcionario = reader.GetInt32("fk_ID_Funcionario");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.Bairro = reader.GetString("Bairro");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.CEP = reader.GetString("CEP");
                dto.Cidade = reader.GetString("Cidade");
                dto.Numero = reader.GetString("Numero");
                dto.PrecoUnitario = reader.GetString("PrecoUnitario");

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
            string Script = @"UPDATE tb_fonecedor SET en_endereco = @en_endereco ,
                                                       cnpj = @cnpj,
                                                       tel_contem = @tel_contem,
                                                       cel_celular = @cel_celular,
                                                       uf_uf = @uf_uf,
                                                       ds_descricao = @ds_descricao,
                                                       el_email = @el_email,
                                                       id_produto = @id_produto,
                                                       fk_ID_Funcionario = @fk_ID_Funcionario,
                                                       Nm_nome = @Nm_nome,
                                                       PrecoUnitario = @PrecoUnitario,
                                                       CEP = @CEP,
                                                       Numero = @Numero,
                                                       Cidade = @Cidade,
                                                       Bairro = @Bairro
                                                       WHERE Id_Fornecedor = @Id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Bairro", dto.Bairro));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("CEP", dto.CEP));
            parms.Add(new MySqlParameter("Cidade", dto.Cidade));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("el_email", dto.el_email));
            parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));
            parms.Add(new MySqlParameter("fk_ID_Funcionario", dto.fk_ID_Funcionario));
            parms.Add(new MySqlParameter("Id_Fornecedor", dto.Id_Fornecedor));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("Numero", dto.Numero));
            parms.Add(new MySqlParameter("PrecoUnitario", dto.PrecoUnitario));
            parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("Cidade", dto.Cidade));
            parms.Add(new MySqlParameter("Bairro", dto.Bairro));

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
                parms.Add(new MySqlParameter("Bairro", dto.Bairro));
                parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
                parms.Add(new MySqlParameter("CEP", dto.CEP));
                parms.Add(new MySqlParameter("Cidade", dto.Cidade));
                parms.Add(new MySqlParameter("cnpj", dto.cnpj));
                parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
                parms.Add(new MySqlParameter("el_email", dto.el_email));
                parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));
                parms.Add(new MySqlParameter("fk_ID_Funcionario", dto.fk_ID_Funcionario));
                parms.Add(new MySqlParameter("Id_Fornecedor", dto.Id_Fornecedor));
                parms.Add(new MySqlParameter("id_produto", dto.id_produto));
                parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
                parms.Add(new MySqlParameter("Numero", dto.Numero));
                parms.Add(new MySqlParameter("PrecoUnitario", dto.PrecoUnitario));
                parms.Add(new MySqlParameter("tel_telefone", dto.tel_telefone));
                parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
                parms.Add(new MySqlParameter("Cidade", dto.Cidade));
                parms.Add(new MySqlParameter("Bairro", dto.Bairro));


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
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.tel_telefone = reader.GetString("tel_telefone");
                dto.Bairro = reader.GetString("Bairro");
                dto.cel_celular = reader.GetString("cel_celular");
                dto.CEP = reader.GetString("CEP");
                dto.Cidade = reader.GetString("Cidade");
                dto.cnpj = reader.GetString("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.el_email = reader.GetString("el_email");
                dto.en_endereço = reader.GetString("en_endereço");
                dto.fk_ID_Funcionario = reader.GetInt32("fk_ID_Funcionario");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.Numero = reader.GetString("Numero");
                dto.PrecoUnitario = reader.GetDecimal("PrecoUnitario");
                dto.tel_telefone = reader.GetString("tel_telefone");
                dto.uf_uf = reader.GetString("uf_uf");





                lista.Add(dto);

            }
            reader.Close();
            return lista;
        }
    }
}

    

