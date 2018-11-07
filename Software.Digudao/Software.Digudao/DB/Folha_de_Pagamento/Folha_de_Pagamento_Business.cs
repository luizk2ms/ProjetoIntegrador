﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Digudao.DB.Folha_de_Pagamento
{
    class Folha_de_Pagamento_Business
    {
        public int SalvarFolha(Folha_de_Pagamento_DTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarSalario(dto.vl_salarioBruto.ToString());

            if (dto.ds_Cargo == string.Empty)
                throw new ArgumentException("O cargo não pode ser nulo.");

            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            return db.SalvarFolha(dto);
        }

        public int AlterarFolha(Folha_de_Pagamento_DTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarSalario(dto.vl_salarioBruto.ToString());

            if (dto.ds_Cargo == string.Empty)
                throw new ArgumentException("O cargo não pode ser nulo.");

            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            return db.AlterarFolha(dto);
        }

        public int RemoverFolha(int idFolha)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            return db.RemoverFolha(idFolha);
        }

        public List<Folha_de_Pagamento_View_DTO> Consultar()
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            return db.Consultar();
        }

        public Folha_de_Pagamento_View_DTO ConsultarPorId(string id)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            return db.ConsultarPorId(id);
        }
    }
}