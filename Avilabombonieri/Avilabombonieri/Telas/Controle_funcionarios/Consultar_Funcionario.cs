using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
using prototipos.DB.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Controle_funcionarios
{
    public partial class Consultar_Funcionario : Form
    {
        public Consultar_Funcionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button8_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness funcionario = new FuncionarioBusiness();
            List<FuncionarioDTO> View = funcionario.ConsultarporNome(textBox2.Text);
            //FuncionarioDTO dto = View[0];
            dgvfuncionario.DataSource = View;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
