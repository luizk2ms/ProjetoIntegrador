using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int Salvar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.Remover(ID);
        }

        public List<FuncionarioViewDTO> Listar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Listar();
        }

        public List<FuncionarioViewDTO> ConsultarporNome(string nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<FuncionarioDTO> ConsultarpoId(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarporId(ID);
        }
    }
}
