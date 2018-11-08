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
            try
            {
                ProdutoDTO dto = cboProdutos.SelectedItem as ProdutoDTO;
                int qnt = Convert.ToInt32(textBox7.Text);
                for (int i = 0; i < qnt; i++)
                {

                }
            }
        }
        
        
    }
}
