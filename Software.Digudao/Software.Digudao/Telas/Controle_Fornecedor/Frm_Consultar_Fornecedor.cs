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
    public partial class Frm_Consultar_Fornecedor : Form
    {
        public Frm_Consultar_Fornecedor()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorBusiness Cliente = new FornecedorBusiness();
            List<FornecedorDTO> View = Cliente.ConsultarporNome(txtfornecedor.Text);
            FornecedorViewDTO dto = View[0];
            dgvfornecedor.DataSource = View;
        }


        private void dgvfornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Frm_Alterar_Fornecedor alterarFornecedor = new Frm_Alterar_Fornecedor();
                FornecedorViewDTO dto = dgvfornecedor.CurrentRow.DataBoundItem as FornecedorViewDTO;
                int Id_Fornecedor = dto.Id_Fornecedor;
                string Nm_Nome;
                Id_Fornecedor = dto.Id_Fornecedor;
                Nm_Nome = dto.Nm_nome;
                alterarFornecedor.LoadScreen(Id_Fornecedor, Nm_Nome);
                alterarFornecedor.Show();

            }
            if (e.ColumnIndex == 8)
            {
                FornecedorBusiness Fornecedor = new FornecedorViewDTO();
                FornecedorViewDTO dto = dgvfornecedor.CurrentRow.DataBoundItem as FornecedorViewDTO;
                Fornecedor.Remover(dto.Id_Fornecedor);
                ();


            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
