using Software.Digudao.Controle_Cliente;
using Software.Digudao.Controle_Estoque;
using Software.Digudao.Controle_Fornecedor;
using Software.Digudao.Controle_Funcionario;
using Software.Digudao.DB.db;
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastra_Produto = new CadastrarProduto();
            cadastra_Produto.Show();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            Frm_Cadastra_Funcionario cadastra_Funcionario = new Frm_Cadastra_Funcionario();
            cadastra_Funcionario.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Cliente cadastra_Cliente = new Frm_Cadastrar_Cliente();
            cadastra_Cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Fornecedor cadastra_Fornecedor = new Frm_Cadastrar_Fornecedor();
            cadastra_Fornecedor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Estoque cadastra_Fornecedor = new Frm_Cadastro_Estoque();
            cadastra_Fornecedor.Show();
        }
    }
}
