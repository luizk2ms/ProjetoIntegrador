using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Fluxo_caixa
{
    public partial class Frm_fluxo_consulta : Form
    {
        public Frm_fluxo_consulta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FluxodecaixaBusiness Cliente = new FluxodecaixaBusiness();
            List<FluxodecaixaView> View = Cliente.ConsultarporNome(textBox2.Text);
            ClienteViewDTO dto = View[0];
            dataGridView1.DataSource = View;
        }
    }
}
