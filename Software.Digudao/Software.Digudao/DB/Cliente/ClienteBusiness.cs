using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipos.DB.Cliente
{
    class ClienteBusiness
        {
            public int Salvar(ClienteDTO dto)
            {
                ClienteDatabase db = new ClienteDatabase();
                return db.Salvar(dto);
            }

            public void Alterar(ClienteDTO dto)
            {
                ClienteDatabase db = new ClienteDatabase();
                db.Alterar(dto);
            }
            public void Remover(int ID)
            {
                ClienteDatabase db = new ClienteDatabase();
                db.Remover(ID);
            }

            public List<ClienteDTO> Listar()
            {
                ClienteDatabase db = new ClienteDatabase();
                return db.Listar();
            }

            public List<ClienteDTO> ConsultarporNome(string nome)
            {
                ClienteDatabase db = new ClienteDatabase();
                return db.ConsultarporNome(nome);
            }

            public List<ClienteDTO> ConsultarpoId(int ID)
            {
                ClienteDatabase db = new ClienteDatabase();
                return db.ConsultarpoID(ID);
            }
        }
}
