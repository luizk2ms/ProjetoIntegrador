using prototipos.DB.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_compra
{
    public partial class Frm_Consultar_Compra : Form
    {
        public Frm_Consultar_Compra()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            PedidoBusiness Pedido = new PedidoBusiness();
            List<PedidoDTO> View = Pedido.ConsultarpoID(textBox2.Text);
            dataGridView1.DataSource = View;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
