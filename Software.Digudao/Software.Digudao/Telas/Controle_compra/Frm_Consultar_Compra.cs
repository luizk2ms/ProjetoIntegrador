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
        }


        private void button10_Click(object sender, EventArgs e)
        {
            PedidoBusiness Pedido = new PedidoBusiness();
            List<PedidoViewDTO> View = Pedido.ConsultarporNome(textBox2.Text);
            PedidoViewDTO dto = View[0];
            dataGridView1.DataSource = View;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
