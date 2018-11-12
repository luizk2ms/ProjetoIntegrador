using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
using prototipos.DB.Cliente;
using System;
using System.Windows.Forms;

namespace Avilabombonieri.Controle_Cliente
{
    public partial class Alterar_Cliente : Form
    {
        public Alterar_Cliente()
        {
            InitializeComponent();
        }
        public void RemoverCliente()
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Compra_usuario comprausuario = new Compra_usuario();
            Hide();
            comprausuario.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio Inicio = new inicio();
            Hide();
           Inicio.ShowDialog();
            Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Id_Cliente = int.Parse(id_cliente.Text);
            dto.Nm_Nome = Nomecliente.Text;
            dto.CNPJ = Cnpj.Text;
            dto.CPF = Cpf.Text;
            dto.Em_Email = Email.Text;
            dto.Ed_endereco = Endereco.Text;
            dto.Nm_numero = Numero.Text;

            ClienteBusiness bussines = new ClienteBusiness();
            bussines.Alterar(dto);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           

        }
    }
}
