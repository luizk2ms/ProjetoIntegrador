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
    public partial class Frm_Cadastrar_Cliente : Form
    {
        public Frm_Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Cliente consultarCliente = new Frm_Consultar_Cliente();
            Hide();
            consultarCliente.ShowDialog();
            Show();
        }
        private void CadastrarDadosCliente()
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CadastrarDadosCliente();

            MessageBox.Show("Seu cliente foi cadastrado com sucesso.","digudão",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }

        private void Frm_Cadastrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
