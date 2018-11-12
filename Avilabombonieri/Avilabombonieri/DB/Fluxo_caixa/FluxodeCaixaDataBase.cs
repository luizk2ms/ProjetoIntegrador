//using Software.Digudao.DB.db;
//using System;
//using System.Collections.Generic;

//namespace Software
//{
////    class FluxodeCaixaDataBase
////    {
////        public int Salvar (FluxodeCaixaDTO dto)
////        {
////            string script = @"insert into tb_fluxo_de_caixa (qnt_de_venda_avista,qnt_de_venda_cartao,vl_total_recebido,fluxo_de_caixa_diario,fluxo_de_caixa_mensal,fk_id_funcionario_para_fc)
////                           values     (@qnt_de_venda_avista,@qnt_de_venda_cartao,@vl_total_recebido,@fluxo_de_caixa_diario,@fluxo_de_caixa_mensal,@fk_id_funcionario_para_fc)";

////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            parms.Add(new MySqlParameter("qnt_de_venda_avista", dto.qnt_venda_avista));
////            parms.Add(new MySqlParameter("qnt_de_venda_cartao", dto.qnt_venda_cartao));
////            parms.Add(new MySqlParameter("vl_total_recebido", dto.vl_total_recebido));
////            parms.Add(new MySqlParameter("fluxo_de_caixa_diario", dto.fluxo_caixa_diario));
////            parms.Add(new MySqlParameter("fluxo_de_caixa_mensal", dto.fluxo_caixa_mensal));
////            parms.Add(new MySqlParameter("fk_id_funcionario_para_fc", dto.FKIDfuncionarios));

////            Database db = new Database();
////            return db.ExecuteInsertScriptWithPk(script, parms);
////        }

////        public void Alterar(FluxodeCaixaDTO dto)
////        {
////            string script = @"update tb_fluxo_de_caixa set   qnt_de_venda_avista=@qnt_de_venda_avista,
////                                                            qnt_de_venda_cartao=@qnt_de_venda_cartao,
////                                                            vl_total_recebido=@vl_total_recebido,
////                                                            fluxo_de_caixa_diario=@fluxo_de_caixa_diario,
////                                                            fluxo_de_caixa_mensal=@fluxo_de_caixa_mensal,
////                                                            fk_id_funcionario_para_fc=@fk_id_funcionario_para_fc
////                                            where           id_fluxo_de_caixa = @id_fluxo_de_caixa";

////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            parms.Add(new MySqlParameter("id_fluxo_de_caixa", dto.Id_fluxo_de_caixa));
////            parms.Add(new MySqlParameter("qnt_de_venda_avista", dto.qnt_venda_avista));
////            parms.Add(new MySqlParameter("qnt_de_venda_cartao", dto.qnt_venda_cartao));
////            parms.Add(new MySqlParameter("vl_total_recebido", dto.vl_total_recebido));
////            parms.Add(new MySqlParameter("fluxo_de_caixa_diario", dto.fluxo_caixa_diario));
////            parms.Add(new MySqlParameter("fluxo_de_caixa_mensal", dto.fluxo_caixa_mensal));
////            parms.Add(new MySqlParameter("fk_id_funcionario_para_fc", dto.FKIDfuncionarios));

////            Database db = new Database();
////            db.ExecuteInsertScript(script, parms);
////        }

////        public void Deletar(int Id)
////        {
////            string script = @"delete from tb_fluxo_de_caixa where id_fluxo_de_caixa = @id_fluxo_de_caixa";

////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            parms.Add(new MySqlParameter("id_fluxo_de_caixa", Id));

////            Database db = new Database();
////            db.ExecuteInsertScript(script, parms);
////        }


////        public List<FluxodeCaixaDTO> Listar()
////        {
////            string script = @"select * from tb_fluxo_de_caixa";
////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            Database db = new Database();
////            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
////            List<FluxodeCaixaDTO> lista = new List<FluxodeCaixaDTO>();
////            while(reader.Read())
////            {
////                FluxodeCaixaDTO dto = new FluxodeCaixaDTO();
////                dto.Id_fluxo_de_caixa = reader.GetInt32("id_fluxo_de_caixa");
////                dto.qnt_venda_avista = reader.GetInt32("qnt_de_venda_avista");
////                dto.qnt_venda_cartao= reader.GetInt32("qnt_de_venda_cartao");
////                dto.vl_total_recebido = reader.GetDecimal("vl_total_recebido");
////                dto.fluxo_caixa_diario = reader.GetBoolean("fluxo_de_caixa_diario");
////                dto.fluxo_caixa_mensal = reader.GetBoolean("fluxo_de_caixa_mensal");
////                dto.FKIDfuncionarios = reader.GetInt32("fk_id_funcionario_para_fc");
////                lista.Add(dto);
////            }
////            reader.Close();
////            return lista;
////        }

        

////        public List<FluxodeCaixaDTO> ConsultarporID(int ID)
////        {
////            string script = @"select * from tb_fluxo_de_caixa where id_fluxo_de_caixa like @id_fluxo_de_caixa";
////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            parms.Add(new MySqlParameter("id_fluxo_de_caixa", ID + "%"));
////            Database db = new Database();
////            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
////            List<FluxodeCaixaDTO> lista = new List<FluxodeCaixaDTO>();
////            while (reader.Read())
////            {
////                FluxodeCaixaDTO dto = new FluxodeCaixaDTO();
////                dto.Id_fluxo_de_caixa = reader.GetInt32("id_fluxo_de_caixa");
////                dto.qnt_venda_avista = reader.GetInt32("qnt_de_venda_avista");
////                dto.qnt_venda_cartao = reader.GetInt32("qnt_de_venda_cartao");
////                dto.vl_total_recebido = reader.GetDecimal("vl_total_recebido");
////                dto.fluxo_caixa_diario = reader.GetBoolean("fluxo_de_caixa_diario");
////                dto.fluxo_caixa_mensal = reader.GetBoolean("fluxo_de_caixa_mensal");
////                dto.FKIDfuncionarios = reader.GetInt32("fk_id_funcionario_para_fc");
////                lista.Add(dto);
////            }
////            reader.Close();
////            return lista;
////        }

////        public List<FluxodeCaixaDTO> FiltrarData (DateTime start, DateTime end)
////        {   
////            string script = @"select *
////                                from vw_fluxo_caixa
////                                where dt_operacao >= @start
////                                   and dt_operacao <= @end
////                                 order
////                                by dt_operacao, tp_operacao";
////            List<MySqlParameter> parms = new List<MySqlParameter>();
////            parms.Add(new MySqlParameter("start", start));
////            parms.Add(new MySqlParameter("end", end));

////            Database db = new Database();
////            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

////            List<FluxodeCaixaDTO> fluxodeCaixas = new List<FluxodeCaixaDTO>();
////            while(reader.Read() == true)
////            {
////                FluxodeCaixaDTO dto = new FluxodeCaixaDTO();
////                dto.dt_operacao = reader.GetDateTime("dt_operacao");
////                dto.vl_total = reader.GetDecimal("vl_total");
////                dto.to_operacao = reader.GetString("tp_operacao");

////                fluxodeCaixas.Add(dto);
////            }
////            reader.Close();
////            return fluxodeCaixas;

////        }
////    }
////}
