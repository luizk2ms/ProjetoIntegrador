using Avilabombonieri.Controle_funcionarios;
using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Folha_Pagamento;
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
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Gerar_Folha gerar = new Gerar_Folha();
            Hide();
           gerar.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
