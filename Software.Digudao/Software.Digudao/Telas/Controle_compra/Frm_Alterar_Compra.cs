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
            Carregarcampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Produto_Compra_DTO produto = new Produto_Compra_DTO();
            produto.Nm_Nome
            
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        void Carregarcampos()
        {
            ProdutoBusiness business = new ProdutoBusiness();
            List<Produto_Compra_DTO> produto = business.listar;

            cboProdutos.DataSource = produto;
            cboProdutos.DisplayMember = "Tm_Tamanho";

        }
    }
}
