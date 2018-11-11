using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public void Cadastrar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
             db.Cadastrar(dto);
        }

        public void Alterar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.AlterarFuncionario(dto);
        }
        public void RemoverFuncionario(int id)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.RemoverFuncionario(id);
        }

        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Listar();
        }

        public List<FuncionarioDTO> ConsultarporNome(int nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarFuncionario(nome);
        }

        public List<FuncionarioDTO> ConsultarpoId(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ListarPorId(ID);
        }
    }
}
