using Avilabombonieri.Controle_funcionarios;
using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Folha_Pagamento
{
    public partial class Gerar_Folha : Form
    {
        public Gerar_Folha()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Consultar_Folha Consultar = new Consultar_Folha();
            Hide();
            Consultar.ShowDialog();
            Show();
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
    }
}
