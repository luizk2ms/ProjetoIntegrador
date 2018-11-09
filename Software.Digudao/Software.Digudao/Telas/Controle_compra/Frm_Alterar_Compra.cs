using prototipos.DB.Pedido;
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

namespace Software.Digudao.Controle_compra
{
    public partial class Frm_Alterar_Compra : Form
    {
        public Frm_Alterar_Compra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProdutoViewDTO dto = cboProdutos.SelectedItem as ProdutoViewDTO;
            ProdutoDTO produto = new ProdutoDTO();

            produto.Ql_Quantidade = Convert.ToInt32(textBox7.Text);
            produto.Nm_Nome = dto.Nm_Nome;
            produto.Id_Produto = dto.Id_Produto;

            ProdutoBusiness business = new ProdutoBusiness();
            business.Altera(produto);
            
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoBusiness business = new ProdutoBusiness();
            ProdutoViewDTO produto = business.Consultarporid(Convert.ToInt32(cboProdutos.SelectedValue));

            textBox9.Text = produto.Pc_Preco.ToString();







            

        }
    }
}
