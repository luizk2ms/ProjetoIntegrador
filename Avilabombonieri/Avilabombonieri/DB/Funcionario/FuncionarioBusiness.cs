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

        public List<FuncionarioDTO> ConsultarporNome(string Nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarporNome(Nome);
        }

        public List<FuncionarioDTO> ConsultarpoId(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ListarPorId(ID);
        }

        public List<FuncionarioDTO> ConsultarporCPF(string CPF)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarporCPF(CPF);
        }
    }
}
