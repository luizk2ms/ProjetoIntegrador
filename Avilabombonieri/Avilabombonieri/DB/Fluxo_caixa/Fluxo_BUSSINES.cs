using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avilabombonieri.DB.Fluxo_caixa
{
    class Fluxo_BUSSINES
    {
       
        public int Salvar(Fluxo_DTO dto)
        {
            Fluxo_DATABASE db = new Fluxo_DATABASE();
            return db.Salvar(dto);
        }

        public void Alterar(Fluxo_DTO dto)
        {
           Fluxo_DATABASE db = new Fluxo_DATABASE();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
           Fluxo_DATABASE db = new Fluxo_DATABASE();
            db.Deletar(ID);
        }

        public List<Fluxo_DTO> Listar()
        {
            Fluxo_DATABASE db = new Fluxo_DATABASE();
            return db.Listar();
        }

        public List<Fluxo_DTO> ConsultarporID(int id)
        {
           Fluxo_DATABASE db = new Fluxo_DATABASE();
            return db.ConsultarporID(id);
        }


        public List<Fluxo_View> FiltrarData(DateTime start, DateTime end)
        {
            Fluxo_DATABASE db = new Fluxo_DATABASE();
            return db.FiltrarData(start, end);
        }
    }
}
