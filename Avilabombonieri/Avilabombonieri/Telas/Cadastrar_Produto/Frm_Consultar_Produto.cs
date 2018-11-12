using Avilabombonieri.DB.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Telas.Cadastrar_Produto
{
    public partial class Frm_Consultar_Produto : Form
    {
        public Frm_Consultar_Produto()
        {
            InitializeComponent();
        }

        private void btnVisualisar_Click(object sender, EventArgs e)
        {
            ProdutoBusiness produto = new ProdutoBusiness();
            List<ViewConsultarProdutosDTO> view = produto.ConsultarporNomeView(textBox4.Text);
            dgvproduto.AutoGenerateColumns = false;
            dgvproduto.DataSource = view;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
   
        }
    }
}
