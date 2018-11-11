
using Software.Digudao.DB.Produto;
using Software.Digudao.Telas.Produto;
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
            dto.pç_preço = textBox2.Text;
            dto.Ql_Quantidade = textBox3.Text;
            dto.Tm_Tamanho = textBox1.Text;

            business.Salvar(dto);

        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            consultarProduto.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }
    }
}
