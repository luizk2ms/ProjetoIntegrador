using prototipos.DB.Produto;
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
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();
            ProdutoBusiness business = new ProdutoBusiness();
            dto.Nm_Nome = textBox8.Text;
            dto.Pc_Preco = decimal.Parse(textBox2.Text);
            dto.Ql_Quantidade = int.Parse(textBox3.Text);
            dto.Tm_Tamanho = textBox1.Text;

            business.Alterar(dto);
        }
    }
}
