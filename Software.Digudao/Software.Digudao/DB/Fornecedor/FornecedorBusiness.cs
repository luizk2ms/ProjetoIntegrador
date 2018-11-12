using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Fornecedor
{
    class FornecedorBusiness
    {
        public void Salvar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
              db.Salvar(dto);
        }

        public void Alterar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Alterar(dto);
        }
        public int RemoverFornecedor(int id)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.RemoverFornecedor(id);
        }

        public List<FornecedorDTO> ConsultarporNome(string Nome)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarporNome(Nome);
        }

        public List<FornecedorDTO> ConsultarFornecedor(int id)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarFornecedor(id);
        }

        public List<FornecedorDTO> Listar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Listar();
        }
    }
}
