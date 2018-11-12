
using prototipos.DB.Fornecedor;
using prototipos.DB.Funcionario;
using Software.Digudao.DB.Produto;
using Software.Digudao.Telas.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.DB.db
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
            CarregarFornecedor();
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
        

        private void button7_Click(object sender, EventArgs e)
        {
            SalvarProduto();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultarProduto = new ConsultarProduto();
            consultarProduto.Show();
            this.Close();
        }
    }
}
