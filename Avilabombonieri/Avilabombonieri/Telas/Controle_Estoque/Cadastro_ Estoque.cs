using Avilabombonieri.Controle_Estoque;
using Avilabombonieri.Tela_inicio;
using prototipos.DB.Estoque;
using System;
using System.Windows.Forms;

namespace Avilabombonieri.Telas.Controle_Estoque
{
    public partial class Cadastro__Estoque : Form
    {
        public Cadastro__Estoque()
        {
            InitializeComponent();
        }
        private void SalvarEstoque()
        {
            EstoqueDTO dto = new EstoqueDTO();
            //dto.Id_Estoque = int.Parse(textBox8.Text);
            dto.fk_id_produto_estoque = int.Parse(textBox1.Text);
            dto.Qn_QuantidadeEmKg = textBox2.Text;
            dto.Pc_preco = textBox5.Text;
            dto.Qn_Quantidade = textBox3.Text;
            dto.Tm_tamanho = textBox6.Text;
            EstoqueBusiness business = new EstoqueBusiness();
            business.SalvarEstoque(dto);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalvarEstoque();
            MessageBox.Show("Estoque criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            inicio gerar = new inicio();
            Hide();
            gerar.ShowDialog();
            Show();
        }
    }
}
