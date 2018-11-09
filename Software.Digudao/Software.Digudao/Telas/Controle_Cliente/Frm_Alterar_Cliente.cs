using prototipos.DB.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_Cliente
{
    public partial class Frm_Alterar_Cliente : Form
    {
        public Frm_Alterar_Cliente()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void CarregarCliente()
        {
            ClienteBusiness business = new ClienteBusiness();
            List<ClienteDTO> lista = business.ConsultarpoId(ID);
            ClienteDTO dto = lista[0];

        }

        private void button13_Click(object sender, EventArgs e)
        {
            AlterarDadosCliente();
        }
        private void AlterarDadosCliente()
        {
            ClienteBusiness cliente = new ClienteBusiness();
            ClienteDTO dto = new ClienteDTO();
            dto.Id_Cliente = int.Parse(textBox1.Text);
            dto.Nm_Nome = textBox5.Text;
            dto.tl_empresa = int.Parse(textBox4.Text);
            dto.cp_cep = int.Parse(textBox6.Text);
            dto.ds_endereço = textBox8.Text;
            dto.em_email = textBox3.Text;
            dto.cpf_cpf = int.Parse(textBox9.Text);
            dto.cel_celular = int.Parse(textBox2.Text);

            cliente.Alterar(dto);

        }

        private void Frm_Alterar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

         Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
