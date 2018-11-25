using prototipos.DB.Estoque;
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

namespace Software.Digudao.Controle_Estoque
{
    public partial class Frm_Cadastro_Estoque : Form
    {
        public Frm_Cadastro_Estoque()
        {
            InitializeComponent();
            CarregarEstoque();
        }
        private void SalvarEstoque()
        {
            EstoqueDTO dto = new EstoqueDTO();
            //dto.Id_Estoque = int.Parse(textBox8.Text);
            dto.Qn_QuantidadeEmKg = textBox2.Text;
            dto.Pc_preco = textBox5.Text;
            dto.Qn_Quantidade = textBox3.Text;
            dto.Tm_tamanho = textBox6.Text;
            EstoqueBusiness business = new EstoqueBusiness();
            business.SalvarEstoque(dto);

        }

        private void CarregarEstoque()
        {
            ProdutoBusiness Estoque = new ProdutoBusiness();
            comboBox1.DisplayMember = nameof(ProdutoDTO.Nm_Nome);

            comboBox1.DataSource = Estoque.Listar();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SalvarEstoque();
            MessageBox.Show("Dados salvos com sucesso", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Estoque consultarEstoque = new Frm_Consultar_Estoque();
            consultarEstoque.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
