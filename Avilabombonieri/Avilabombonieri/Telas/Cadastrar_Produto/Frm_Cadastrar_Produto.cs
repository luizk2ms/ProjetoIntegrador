using Avilabombonieri.DB.Produto;
using Avilabombonieri.Tela_inicio;
using prototipos.DB.Estoque;
using prototipos.DB.Fornecedor;
using prototipos.DB.Funcionario;
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
    public partial class Frm_Cadastrar_Produto : Form
    {
        public Frm_Cadastrar_Produto()
        {
            InitializeComponent();
        }
        int pk;
        private void PegarIdFuncionario()
        {
            FuncionarioBusiness funcionario = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = funcionario.ConsultarporCPF(mktcpf.Text);
            FuncionarioDTO dto = lista[0];
            pk = dto.Id_Funcionario;
        }

        private void CarregarFornecedor()
        {
            FornecedorBusiness fornecedor = new FornecedorBusiness();
            cbofonecedor.ValueMember = nameof(FornecedorDTO.Id_Fornecedor);
            cbofonecedor.DisplayMember = nameof(FornecedorDTO.Nm_nome);

            cbofonecedor.DataSource = fornecedor.Listar();
        }
        private void SalvarProduto()
        {
            PegarIdFuncionario();
            FornecedorDTO dtofornecedor = cbofonecedor.SelectedItem as FornecedorDTO;
            ProdutoDTO dto = new ProdutoDTO();
            ProdutoBusiness business = new ProdutoBusiness();
            dto.Nm_Nome = textBox8.Text;
            dto.pç_preço = textBox2.Text;
            dto.Ql_Quantidade = textBox3.Text;
            dto.Tm_Tamanho = textBox1.Text;
            dto.FkFornecedor = dtofornecedor.Id_Fornecedor;
            dto.fk_id_funcionario_produto = pk;
            business.Salvar(dto);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
            Frm_Consultar_Produto consultarProduto = new Frm_Consultar_Produto();
            consultarProduto.Show();
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DatadeVal_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SalvarProduto();
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
