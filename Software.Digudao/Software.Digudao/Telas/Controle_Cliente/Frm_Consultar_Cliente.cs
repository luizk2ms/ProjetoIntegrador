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
    public partial class Frm_Consultar_Cliente : Form
    {
        public Frm_Consultar_Cliente()
        {
            InitializeComponent();
        }
        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
        }
        private void CarregarDadosClientes()
        {
            ClienteBusiness Cliente = new ClienteBusiness();
            List<ClienteDTO> View = Cliente.ConsultarporNome(textBox2.Text);
            ClienteDTO dto = View[0];
            dataGridView1.DataSource = View;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CarregarDadosClientes();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Frm_Consultar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
