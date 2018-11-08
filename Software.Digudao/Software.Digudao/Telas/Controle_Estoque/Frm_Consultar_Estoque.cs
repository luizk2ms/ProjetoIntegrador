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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EstoqueBusiness Cliente = new EstoqueBusiness();
            List<EstoqueViewDTo> View = Cliente.ConsultarporNome(textBox2.Text);
            EstoqueViewDTo dto = View[0];
            dataGridView1.DataSource = View;
        }
    }
}
