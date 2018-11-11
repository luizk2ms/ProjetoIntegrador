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
            dgvFolha.AutoGenerateColumns = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProdutoBusiness Estoque = new ProdutoBusiness();
            List<ProdutoDTO> view = Estoque.ConsultarporNome(txtCPF.Text);
            ProdutoDTO dto = view[0];
            dgvFolha.DataSource = view;
        }
    }
}
