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

namespace Software.Digudao.Telas.Controle_compra
{
    public partial class Frm_Cadastro_Compra : Form
    {
        public Frm_Cadastro_Compra()
        {
            InitializeComponent();
            CarregarEstoque();
            CarregarTamanho();

        }
        private void CarregarTamanho()
        {
            ProdutoBusiness Estoque = new ProdutoBusiness();
            comboBox1.DisplayMember = nameof(ProdutoDTO.Tm_Tamanho);

            comboBox1.DataSource = Estoque.Listar();
        }
        private void CarregarEstoque()
        {
            ProdutoBusiness Estoque = new ProdutoBusiness();
            cboProdutos.DisplayMember = nameof(ProdutoDTO.Nm_Nome);

            cboProdutos.DataSource = Estoque.Listar();
        }

        private void Frm_Cadastro_Compra_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
