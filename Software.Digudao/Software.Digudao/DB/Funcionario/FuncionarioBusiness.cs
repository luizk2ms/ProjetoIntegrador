using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public FuncionarioDTO Cadastrar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Cadastrar(dto);
        }

        public void Alterar(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.AlterarFuncionario(dto);
        }
        public void Remover(int id)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            db.RemoverFuncionario(id);
        }

        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Listar();
        }

        public List<FuncionarioDTO> ConsultarporNome(string nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarFuncionariosFiltro(nome);
        }

        public List<FuncionarioDTO> ListarPorId(int id)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ListarPorId(id);
        }
    }
}
