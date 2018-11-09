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

namespace Software.Digudao.Fluxo_caixa
{
    public partial class Frm_fluxo_consulta : Form
    {
        private object dataGridView1;

        public Frm_fluxo_consulta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FluxodeCaixaBusiness Cliente = new FluxodeCaixaBusiness();
            List<FluxodeCaixaView> View = Cliente.ConsultarporNome(textBox2.Text);
            ClienteViewDTO dto = View[0];
            dataGridView1.DataSource = View;
        }

        private void Frm_fluxo_consulta_Load(object sender, EventArgs e)
        {

        }
    }
}
