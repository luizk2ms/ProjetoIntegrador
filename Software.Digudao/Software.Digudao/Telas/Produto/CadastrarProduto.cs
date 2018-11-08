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

namespace Software.Digudao.DB.db
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }
        private void SalvarProduto()
        {
            ProdutoDTO dto = new ProdutoDTO();
            ProdutoBusiness business = new ProdutoBusiness();
            dto.Nm_Nome = textBox8.Text;
            dto.Pc_Preco = decimal.Parse(textBox2.Text);
            dto.Ql_Quantidade = int.Parse(textBox3.Text);
            dto.Tm_Tamanho = textBox1.Text;

            business.Salvar(dto);

        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();
            dto.Nm_Nome = textBox8.Text;
            dto.Pc_Preco = decimal.Parse(textBox2.Text);
            dto.Ql_Quantidade = int.Parse(textBox3.Text);
            dto.Tm_Tamanho = textBox1.Text;

            ProdutoBusiness business = new ProdutoBusiness();
            business.Salvar(dto);

            
        }
    }
}
