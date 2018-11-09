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
            return db.Cadastrar(dto);
        }

        public void Alterar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.RemoverFuncionario(dto);
        }
        public void Remover(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.RemoverFuncionario(ID);
        }

        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Listar();
        }

        public List<FuncionarioDTO> ConsultarporNome(string nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.co(nome);
        }

        public List<FuncionarioDTO> ConsultarpoId(int ID)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.co(ID);
        }
    }
}
