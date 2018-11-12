using Avilabombonieri.Controle_Cliente;
using Avilabombonieri.Controle_funcionarios;
using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Folha_Pagamento;
using Avilabombonieri.Telas.Cadastrar_Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Tela_inicio
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

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
            Cadastrar_Funcionario gerar = new Cadastrar_Funcionario();
            Hide();
            gerar.ShowDialog();
            Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente cliente = new Cadastrar_Cliente();
            Hide();
            cliente.ShowDialog();
            Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Produto gerar = new Frm_Cadastrar_Produto();
            Hide();
           gerar.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio gerar = new inicio();
            Hide();
            gerar.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
