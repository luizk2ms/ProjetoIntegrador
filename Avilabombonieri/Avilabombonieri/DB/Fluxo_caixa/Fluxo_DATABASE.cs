using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Fluxo_caixa
{
    class Fluxo_DATABASE
    {
        {
        public int Salvar(Fluxo_DTO dto)
        {
            string script = @"insert into tb_fluxo_de_caixa (vl_total_recebido,fluxo_de_caixa_diario,fluxo_de_caixa_mensal,fk_id_funcionario_para_fc)
                           values     (@vl_total_recebido,@fluxo_de_caixa_diario,@fluxo_de_caixa_mensal,@fk_id_funcionario_para_fc)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            
            parms.Add(new MySqlParameter("vl_total_recebido", dto.vl_total_recebido));
            parms.Add(new MySqlParameter("fluxo_de_caixa_diario", dto.fluxo_caixa_diario));
            parms.Add(new MySqlParameter("fluxo_de_caixa_mensal", dto.fluxo_caixa_mensal));
            parms.Add(new MySqlParameter("fk_id_funcionario_para_fc", dto.FKIDfuncionarios));

            DataBase db = new DataBase();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Alterar(Fluxo_DTO dto)
        {
            string script = @"update tb_fluxo_de_caixa set   vl_total_recebido=@vl_total_recebido,
                                                            fluxo_de_caixa_diario=@fluxo_de_caixa_diario,
                                                            fluxo_de_caixa_mensal=@fluxo_de_caixa_mensal,
                                                            fk_id_funcionario_para_fc=@fk_id_funcionario_para_fc
                                            where           id_fluxo_de_caixa = @id_fluxo_de_caixa";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fluxo_de_caixa", dto.Id_fluxo_de_caixa));
            parms.Add(new MySqlParameter("vl_total_recebido", dto.vl_total_recebido));
            parms.Add(new MySqlParameter("fluxo_de_caixa_diario", dto.fluxo_caixa_diario));
            parms.Add(new MySqlParameter("fluxo_de_caixa_mensal", dto.fluxo_caixa_mensal));
            parms.Add(new MySqlParameter("fk_id_funcionario_para_fc", dto.FKIDfuncionarios));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }

        public void Deletar(int Id)
        {
            string script = @"delete from tb_fluxo_de_caixa where id_fluxo_de_caixa = @id_fluxo_de_caixa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fluxo_de_caixa", Id));

            DataBase db = new DataBase();
            db.ExecuteInsertScript(script, parms);
        }


        public List<Fluxo_DTO> Listar()
        {
            string script = @"select * from tb_fluxo_de_caixa";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<Fluxo_DTO> lista = new List<Fluxo_DTO>();
            while (reader.Read())
            {
                Fluxo_DTO dto = new Fluxo_DTO();
                dto.Id_fluxo_de_caixa = reader.GetInt32("id_fluxo_de_caixa");
               
                dto.vl_total_recebido = reader.GetDecimal("vl_total_recebido");
                dto.fluxo_caixa_diario = reader.GetBoolean("fluxo_de_caixa_diario");
                dto.fluxo_caixa_mensal = reader.GetBoolean("fluxo_de_caixa_mensal");
                dto.FKIDfuncionarios = reader.GetInt32("fk_id_funcionario_para_fc");
                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }



        public List<Fluxo_DTO> ConsultarporID(int ID)
        {
            string script = @"select * from tb_fluxo_de_caixa where id_fluxo_de_caixa like @id_fluxo_de_caixa";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fluxo_de_caixa", ID + "%"));
            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<Fluxo_DTO> lista = new List<Fluxo_DTO>();
            while (reader.Read())
            {
                Fluxo_DTO dto = new Fluxo_DTO();
                dto.Id_fluxo_de_caixa = reader.GetInt32("id_fluxo_de_caixa");
                dto.vl_total_recebido = reader.GetDecimal("vl_total_recebido");
                dto.fluxo_caixa_diario = reader.GetBoolean("fluxo_de_caixa_diario");
                dto.fluxo_caixa_mensal = reader.GetBoolean("fluxo_de_caixa_mensal");
                dto.FKIDfuncionarios = reader.GetInt32("fk_id_funcionario_para_fc");
                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<Fluxo_View> FiltrarData(DateTime start, DateTime end)
        {
            string script = @"select *
                                from vw_fluxo_caixa
                                where dt_operacao >= @start
                                   and dt_operacao <= @end
                                 order
                                by dt_operacao, tp_operacao";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));

            DataBase db = new DataBase();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<Fluxo_View> fluxodeCaixas = new List<Fluxo_View>();
            while (reader.Read() == true)
            {
                Fluxo_View dto = new Fluxo_View();
                dto.dt_operacao = reader.GetDateTime("dt_operacao");
                dto.vl_total = reader.GetDecimal("vl_total");
                dto.to_operacao = reader.GetString("tp_operacao");

                fluxodeCaixas.Add(dto);
            }
            reader.Close();
            return fluxodeCaixas;

        }
    }
}
