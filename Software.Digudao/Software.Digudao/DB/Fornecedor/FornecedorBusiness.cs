using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Remover(ID);
        }

        public List<FornecedorViewDTO> Listar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Listar();
        }

        public List<FornecedorViewDTO> ConsultarporNome(string nome)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<FornecedorDTO> ConsultarpoId(int ID)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarporId(ID);
        }
    }
}
