using prototipos.DB.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_Fornecedor
{
    public partial class Frm_Cadastrar_Fornecedor : Form
    {
        public Frm_Cadastrar_Fornecedor()
        {
            InitializeComponent();
        }
        private void SalvarFornecedor()
        {
            FornecedorBusiness business = new FornecedorBusiness();
            FornecedorDTO dto = new FornecedorDTO();

            dto.Id_Fornecedor = int.Parse(textBox11.Text);
            dto.id_produto = int.Parse(textBox12.Text);
            dto.Nm_nome = txtnome.Text;
            dto.Nm_numero = int.Parse(textBox8.Text);
            dto.tel_contem = int.Parse(maskedTextBox1.Text);
            dto.uf_uf = txtuf.Text;
            dto.cel_celular = int.Parse(maskedTextBox4.Text);
            dto.cnpj = int.Parse(maskedTextBox3.Text);
            dto.ds_descricao = textBox2.Text;
            dto.el_email = textBox3.Text;
            dto.en_endereço = textBox5.Text;

            business.Salvar(dto);


        }


        private void Frm_Cadastrar_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarFornecedor();
            MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
