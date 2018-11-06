﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorDatabase
    {
        public FornecedorDTO Salvar(FornecedorDTO dto)
        {
            string Script = @"INSERT Funcionario(Id_Fornecedor,en_endereço,cnpj,tel_contem,cel_celular,uf_uf,ds_descricao,el_email,Nm_numero,Nm_nome)
                                          VALUES(@Id_Fornecedor,@en_endereço,@cnpj,@tel_contem,@cel_celular,@uf_uf,@ds_descricao,@el_email,@Nm_numero,@Nm_nome)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Usuario", dto.Id_Fornecedor));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("Nm_numero", dto.Nm_numero));
            parms.Add(new MySqlParameter("tel_contem", dto.tel_contem));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("el_email", dto.el_email));
            parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);
        }

        public List<FornecedorDTO> ConsultarFornecedorFiltros(int id)
        {
            string script = @"select * from Tb_Fornecedor where Id_Fornecedor like @Id_Fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Fornecedor", id);
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueViewDTo> lista = new List<EstoqueViewDTo>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.Nm_nome = reader.GetInt32("Nm_nome");
                dto.Nm_numero = reader.GetInt32("Nm_numero");
                dto.tel_contem = reader.GetInt32("tel_contem");
                dto.uf_uf = reader.GetInt32("uf_uf");
                dto.cel_celular = reader.GetInt32("cel_celular");
                dto.cnpj = reader.GetInt32("cnpj");
                dto.ds_descricao = reader.GetInt32("ds_descricao");
                dto.el_email = reader.GetInt32("el_email");
                dto.en_endereço = reader.GetInt32("en_endereço");




                lista.Add(dto);
            }

            reader.Close();
            return lista;
        }

        public int RemoverFornecedor(string id)
        {
            string script = @"DELETE FROM Funcionario WHERE idFuncionario = @Id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Fornecedor", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        public int AlterarFornecedor(FornecedorDTO dto)
        {
            string Script = @"UPDATE Tb_Fornecedor SET en_endereço = @en_endereço ,
                                                       cnpj = @cnpj,
                                                       tel_contem = @tel_contem,
                                                       cel_celular = @cel_celular,
                                                       uf_uf = @uf_uf,
                                                       ds_descricao = @ds_descricao,
                                                       el_email = @el_email,
                                                       Nm_numero = @Nm_numero,
                                                       Nm_nome =@Nm_nome,
                                                       id_produto = @id_produto,
                                                       WHERE Id_Fornecedor = @Id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("en_endereço", dto.en_endereço));
            parms.Add(new MySqlParameter("el_email", dto.el_email));
            parms.Add(new MySqlParameter("ds_descricao", dto.ds_descricao));
            parms.Add(new MySqlParameter("cnpj", dto.cnpj));
            parms.Add(new MySqlParameter("cel_celular", dto.cel_celular));
            parms.Add(new MySqlParameter("uf_uf", dto.uf_uf));
            parms.Add(new MySqlParameter("tel_contem", dto.tel_contem));
            parms.Add(new MySqlParameter("Nm_numero", dto.Nm_numero));
            parms.Add(new MySqlParameter("Nm_nome", dto.Nm_nome));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(Script, parms);


        }

        public List<FornecedorViewDTO> Listar()
        {
            string Script = @"SELECT *FROM Tb_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<FornecedorViewDTO> lista = new List<FornecedorViewDTO>();
            while (reader.Read)
            {
                FornecedorViewDTO dto = new FornecedorViewDTO();
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.Nm_numero = reader.GetInt("Nm_numero");
                dto.tel_contem = reader.GetInt("tel_contem");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.cel_celular = reader.GetInt("cel_celular");
                dto.cnpj = reader.GetInt("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.el_email = reader.GetString("el_email");
                dto.en_endereço = reader.GetString("en_endereço");


                lista.Add(dto);

            }
            return lista;

        }
        public List<FornecedorViewDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from Tb_Estoque where nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorViewDTO> lista = new List<FornecedorViewDTO>();
            while (reader.Read())
            {
                FornecedorViewDTO dto = new FornecedorViewDTO();
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.Nm_numero = reader.GetInt("Nm_numero");
                dto.tel_contem = reader.GetInt("tel_contem");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.cel_celular = reader.GetInt("cel_celular");
                dto.cnpj = reader.GetInt("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.el_email = reader.GetString("el_email");
                dto.en_endereço = reader.GetString("en_endereço");


                lista.Add(dto);

            }
            return lista;
        }
        public List<FornecedorViewDTO> ConsultarpoID(int id)
        {
            string script = @"select * from Tb_Fornecedor where Id_Fornecedor like @Id_Fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_Fornecedor", id);
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorViewDTO> lista = new List<FornecedorViewDTO>();
            while (reader.Read())
            {
                FornecedorViewDTO dto = new FornecedorViewDTO();
                dto.Id_Fornecedor = reader.GetInt32("Id_Fornecedor");
                dto.id_produto = reader.GetInt32("id_produto");
                dto.Nm_nome = reader.GetString("Nm_nome");
                dto.Nm_numero = reader.GetInt("Nm_numero");
                dto.tel_contem = reader.GetInt("tel_contem");
                dto.uf_uf = reader.GetString("uf_uf");
                dto.cel_celular = reader.GetInt("cel_celular");
                dto.cnpj = reader.GetInt("cnpj");
                dto.ds_descricao = reader.GetString("ds_descricao");
                dto.el_email = reader.GetString("el_email");
                dto.en_endereço = reader.GetString("en_endereço");


            }
            return lista;
        }
    }
}