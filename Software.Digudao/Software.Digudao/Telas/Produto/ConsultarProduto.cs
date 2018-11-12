using Software.Digudao.DB.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Telas.Produto
{
    public partial class ConsultarProduto : Form
    {
        public ConsultarProduto()
        {
            InitializeComponent();
            dgvproduto.AutoGenerateColumns = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProdutoBusiness produto = new ProdutoBusiness();
            List<ViewConsultarProdutosDTO> view =produto.ConsultarporNomeView(txtnome.Text);
            dgvproduto.AutoGenerateColumns = false;
            dgvproduto.DataSource = view;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
