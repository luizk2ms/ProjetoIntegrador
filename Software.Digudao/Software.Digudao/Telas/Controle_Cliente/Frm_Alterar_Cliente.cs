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
    public partial class Id_cliente : Form
    {
        public Id_cliente()
        {
            InitializeComponent();
        }
        private void CarregarCliente()
        {
            ClienteBusiness business = new ClienteBusiness();
            List<ClienteDTO> lista = business.ConsultarporNome(Name);
            ClienteDTO dto = lista[0];

        }
        private void AlterarClientes()
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nm_Nome = textBox14.Text;
            dto.Ed_endereco = textBox11.Text;
            dto.Em_Email = textBox15.Text;
            dto.Nm_numero = textBox17.Text;
            dto.CNPJ = textBox18.Text;
            dto.CPF = textBox10.Text;

            ClienteBusiness cliente = new ClienteBusiness();
            cliente.Alterar(dto);

        }

        private void button13_Click(object sender, EventArgs e)
        {
          
        }
        private void AlterarDadosCliente()
        {

        }

        private void Frm_Alterar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AlterarClientes();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
