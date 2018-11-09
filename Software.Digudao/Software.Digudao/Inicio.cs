using Software.Digudao.Controle_Estoque;
using Software.Digudao.Controle_Fornecedor;
using Software.Digudao.Controle_Funcionario;
using Software.Digudao.Folha_Pagamento;
using Software.Digudao.Telas.Controle_compra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Compra compra = new Frm_Cadastro_Compra();
            Hide();
           compra.ShowDialog();
            Show();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            Frm_Cadastra_Funcionario cadastrofuncionario = new Frm_Cadastra_Funcionario();
            Hide();
            cadastrofuncionario.ShowDialog();
            Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Fornecedor cadastrofornecedor = new Frm_Cadastrar_Fornecedor();
            Hide();
            cadastrofornecedor.ShowDialog();
            Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Estoque cadastrofornecedor = new Frm_Cadastro_Estoque();
            Hide();
            cadastrofornecedor.ShowDialog();
            Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Folha cadastrofolha = new Frm_Registrar_Folha();
            Hide();
            cadastrofolha.ShowDialog();
            Show();
            
        }
    }
}
