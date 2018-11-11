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

namespace Software.Digudao.Controle_Estoque
{
    public partial class Frm_Consultar_Estoque : Form
    {
        public Frm_Consultar_Estoque()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void CarregarDadosEstoque()
        {
            EstoqueBusiness Estoque = new EstoqueBusiness();
            List<EstoqueDTO> view = Estoque.ConsultarporNome(textBox2.Text);
            EstoqueDTO dto = view[0];
            dataGridView1.DataSource = view;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarregarDadosEstoque();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
