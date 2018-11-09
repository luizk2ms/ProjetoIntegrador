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

namespace Software.Digudao.Telas.Controle_compra
{
    public partial class Cadastrar_Compra : Form
    {
        public Cadastrar_Compra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Produto_Compra_DTO dto = new Produto_Compra_DTO();
            dto.Tm_Tamanho = comboBox1.Text;
            dto.Ql_Quantidade = Convert.ToInt32(textBox7.Text);
            dto.Pc_Preco = Convert.ToDecimal(textBox9.Text);

        }

        private void Cadastrar_Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
