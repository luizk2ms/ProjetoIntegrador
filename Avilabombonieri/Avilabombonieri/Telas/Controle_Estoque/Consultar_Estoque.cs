using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
using prototipos.DB.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Controle_Estoque
{
    public partial class Consultar_Estoque : Form
    {
        public Consultar_Estoque()
        {
            InitializeComponent();
        }
        private void CarregarDadosEstoque()
        {
            EstoqueBusiness Estoque = new EstoqueBusiness();
            List<EstoqueDTO> view = Estoque.ConsultarporNome(textBox2.Text);
            EstoqueDTO dto = view[0];
            dataGridView1.DataSource = view;
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

        private void button6_Click(object sender, EventArgs e)
        {
            CarregarDadosEstoque();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
