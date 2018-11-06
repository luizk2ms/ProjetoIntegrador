using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.DB.Estoque;
using Avilabombonieri.Tela_inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Controle_Estoque
{
    public partial class Alterar_Estoque : Form
    {
        public Alterar_Estoque()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Compra_usuario comprausuario = new Compra_usuario();
            Hide();
            comprausuario.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio Inicio = new inicio();
            Hide();
            Inicio.ShowDialog();
            Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstoqueDTO dto = new EstoqueDTO();
            dto.Id_Estoque = int.Parse(IdProduto.Text);
            dto.nm_nome = NomeProd.Text;
            dto.Qn_Quantidade = Quantidade.Text;
            dto.Tm_tamanho = Tamanho.Text;
            dto.Qn_QuantidadeEmKg = QuantidadeEmKg.Text;
            dto.dt_data = DateTime.Parse(DatadeValidade.Text);
            dto.Pc_preco = decimal.Parse(Preco.Text);

            EstoqueBusiness bussines = new EstoqueBusiness();
            bussines.Alterar(dto);

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
