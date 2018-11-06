using prototipos.DB;
using Software.Digudao.DB.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Folha_de_Pagamento
{
    class Folha_de_Pagamento_Database
    {
        class Foha_de_Pagamento__Database
        {
            public decimal TaxaIR(decimal SalarioBase)
            {
                string Script = $@"SELECT Ds_Aliquota FROM Tb_IR
                                    WHERE ds_Salario <={}

                                  ORDER BY ds_Salario
                                  DESC LIMIT 1";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);


                if (reader.Read())
                {
                    decimal taxa = reader.GetDecimal("ds_Salario");
                    return taxa;
                }
                else
                    return 0;

            }
            public decimal DeducaoIR(decimal SalarioBase)
            {
                string Script = $@"SELECT Ds_Deduzir FROM Tb_IR
                                    WHERE ds_Salario <={}

                                  ORDER BY ds_Salario
                                  DESC LIMIT 1";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);


                if (reader.Read())
                {
                    decimal taxa = reader.GetDecimal("Ds_Deduzir");
                    return taxa;
                }
                else
                    return 0;
            }
            public decimal TaxaINSS(decimal SalarioBase)
            {
                string Script = $@"SELECT Ds_Aliquota FROM Tb_Inss
                                    WHERE ds_Salario <=

                                  ORDER BY ds_Salario
                                  DESC LIMIT 1";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);



                if (reader.Read())
                {
                    decimal taxa = reader.GetDecimal("Ds_Aliquota");
                    return taxa;
                }
                else
                    return 0;
            }
            public List<Desconto_DTO> Descontos()
            {
                string Script = @"SELECT * FROM Tb_Desconto";
                List<MySqlParameter> parms = new List<MySqlParameter>();

                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);

                List<Desconto_DTO> descontos = new List<Desconto_DTO>();
                while (reader.Read())
                {
                    Desconto_DTO desconto = new Desconto_DTO();
                    desconto.id_Descontos = reader.GetInt32("id_Descontos");
                    desconto.ds_Porcentagem = reader.GetString("ds_Porcentagem");
                    desconto.ds_Tipo = reader.GetDecimal("ds_Tipo");

                    descontos.Add(desconto);
                }
                return descontos;
            }


            public List<Folha_de_Pagamento_View_DTO> ConsultarPorId(string id)
            {
                string script = @"SELECT * FROM Pagamento__ViewDTO WHERE id_FolhadePagamento LIKE @id_FolhadePagamento";
                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_FolhadePagamento", id + "%"));
                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
                List<Folha_de_Pagamento_View_DTO> folha = new List<Folha_de_Pagamento_View_DTO>();
                while (reader.Read())
                {
                    Folha_de_Pagamento_View_DTO dto = new Folha_de_Pagamento_View_DTO();
                    dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");
                    dto.id_Funcionario = reader.GetInt32("id_Funcionario");
                    dto.cr_cargo = reader.GetString("cr_cargo");
                    dto.ds_diastrabalhados = reader.GetDate("ds_diastrabalhados");
                    dto.ds_horae = reader.GetDate("ds_horae");
                    dto.ds_horas = reader.GetIDate("ds_horas");
                    dto.Dt_Data_de_Registro = reader.GetDate("Dt_Data_de_Registro");
                    dto.ob_observacao = reader.GetString("ob_observacao");
                    dto.vl_salarioBruto = reader.GetDecimal("vl_salarioBruto");
                    dto.Nm_Nome = reader.GetString("Nm_Nome");

                }
                reader.Close();
                return folha;
            }

            public int SalvarFolha(Folha_de_Pagamento_DTO dto)
            {
                string script = @"INSERT Tb_Folhadepagamento(vl_salarioBruto,ds_horae,ds_horas,ob_observacao,ds_diastrabalhados,Dt_Data_de_Registro,cr_cargo,id_Funcionario,Nm_Nome)
                                            VALUES(@vl_salarioBruto,@ds_horae,@ds_horas,@ob_observacao,@ds_diastrabalhados,@Dt_Data_de_Registro,@cr_cargo,@id_Funcionario,@Nm_Nome)";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
                parms.Add(new MySqlParameter("ds_diastrabalhados", dto.ds_diastrabalhados));
                parms.Add(new MySqlParameter("ds_horae", dto.ds_horae));
                parms.Add(new MySqlParameter("ds_horas", dto.ds_horas));
                parms.Add(new MySqlParameter("Dt_Data_de_Registro", dto.Dt_Data_de_Registro));
                parms.Add(new MySqlParameter("ob_observacao", dto.ob_observacao));
                parms.Add(new MySqlParameter("vl_salarioBruto", dto.vl_salarioBruto));
                parms.Add(new MySqlParameter("id_Funcionario", dto.id_Funcionario));
                parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));


                Database db = new Database();
                return db.ExecuteInsertScriptWithPk(script, parms);
            }
            public int AlterarFolha(Folha_de_Pagamento_DTO dto)
            {
                string script = @"UPDATE Tb_Folhadepagamento SET cr_cargo = @cr_cargo 
                                                                 ds_horae = @ds_horae,
                                                                 ds_horas = @ds_horas, 
                                                      ds_diastrabalhados = @ds_diastrabalhados,
                                                            ob_observacao = @ob_observacao
                                                          vl_salarioBruto = @vl_salarioBruto
                                                      Dt_Data_de_Registro = @Dt_Data_de_Registro
                                                                  Nm_Nome = @Nm_Nome
                                                         
                                                   
    
                                               WHERE id_FolhadePagamento = @id_FolhadePagamento";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_FolhadePagamento", dto.id_FolhadePagamento));
                parms.Add(new MySqlParameter("cr_cargo", dto.cr_cargo));
                parms.Add(new MySqlParameter("ds_diastrabalhados", dto.ds_diastrabalhados));
                parms.Add(new MySqlParameter("ds_horae", dto.ds_horae));
                parms.Add(new MySqlParameter("ds_horas", dto.ds_horas));
                parms.Add(new MySqlParameter("Data_de_Registro", dto.Dt_Data_de_Registro));
                parms.Add(new MySqlParameter("ob_observacao", dto.ob_observacao));
                parms.Add(new MySqlParameter("vl_salarioBruto", dto.vl_salarioBruto));
                parms.Add(new MySqlParameter("id_Funcionario", dto.id_Funcionario));
                parms.Add(new MySqlParameter("Nm_Nome", dto.Nm_Nome));

                Database db = new Database();
                return db.ExecuteInsertScriptWithPk(script, parms);
            }
            public int RemoverFolha(int idFolha)
            {
                string script = @"DELETE FROM Tb_Folhadepagamento WHERE id_FolhadePagamento = @id_FolhadePagamento";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("id_FolhadePagamento", idFolha));

                Database db = new Database();
                return db.ExecuteInsertScriptWithPk(script, parms);
            }
            public List<Folha_de_Pagamento_View_DTO> ConsultarPorNome(string Nome)
            {
                string Script = @"SELECT * FROM Tb_Folhadepagamento WHERE Nm_Nome = @Nm_Nome";
                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("Nm_Nome", Nome + "%"));
                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
                List<Folha_de_Pagamento_View_DTO> lista = new List<Folha_de_Pagamento_View_DTO>();
                while (reader.Read())
                {
                    Folha_de_Pagamento_View_DTO dto = new Folha_de_Pagamento_View_DTO();
                    dto.id_FolhadePagamento = reader.GetInt32("id_FolhadePagamento");
                    dto.id_Funcionario = reader.GetInt32("id_Funcionario");
                    dto.cr_cargo = reader.GetString("cr_cargo");
                    dto.ds_diastrabalhados = reader.GetDate("ds_diastrabalhados");
                    dto.ds_horae = reader.GetDate("ds_horae");
                    dto.ds_horas = reader.GetIDate("ds_horas");
                    dto.Dt_Data_de_Registro = reader.GetDate("Dt_Data_de_Registro");
                    dto.ob_observacao = reader.GetString("ob_observacao");
                    dto.vl_salarioBruto = reader.GetDecimal("vl_salarioBruto");


                }
            }
        }
    }
}
