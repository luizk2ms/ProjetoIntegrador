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
    public partial class Consultar_Cliente : Form
    {
        public Consultar_Cliente()
        {
            InitializeComponent();
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
            ClienteBusiness Cliente = new ClienteBusiness();
            List<ClienteDTO> View = Cliente.Listar();
            dataGridView1.DataSource = View;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
