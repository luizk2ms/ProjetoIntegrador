using Avilabombonieri.Controle_funcionarios;
using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
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

namespace Avilabombonieri.Controle_Cliente
{
    public partial class Cadastrar_Cliente : Form
    {
        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        private void Cadastrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Compra_usuario comprausuario = new Compra_usuario();
            Hide();
            comprausuario.ShowDialog();
            Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio Inicio = new inicio();
            Hide();
            Inicio.ShowDialog();
            Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nm_Nome = textBox5.Text;
            dto.Ed_endereco = textBox8.Text;
            dto.Em_Email = textBox3.Text;
            dto.Nm_numero = textBox2.Text;
            dto.CNPJ = textBox7.Text;
            dto.CPF = textBox9.Text;

            ClienteBusiness cliente = new ClienteBusiness();
            cliente.Salvar(dto);
            MessageBox.Show("Seu cliente foi cadastrado com sucesso.", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Consultar_Cliente consultarCliente = new Consultar_Cliente();
            Hide();
            consultarCliente.ShowDialog();
            Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Alterar_Cliente alterarcliente = new Alterar_Cliente();
            Hide();
            alterarcliente.ShowDialog();
            Show();
        }
    }
}
