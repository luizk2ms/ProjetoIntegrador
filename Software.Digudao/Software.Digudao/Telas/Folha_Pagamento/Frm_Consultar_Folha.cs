using Software.Digudao.Folha_Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Telas.Folha_Pagamento
{
    public partial class Frm_Consultar_Folha : Form
    {
        public Frm_Consultar_Folha()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FolhaPgmtBusiness business = new FolhaPgmtBusiness();
                List<view_func_folha> funcionarios = new List<view_func_folha>();

                if (txtCPF.Text == string.Empty)
                {
                    funcionarios = business.Consultar();
                }
                else
                    funcionarios.Add(business.ConsultarPorCPF(txtCPF.Text));


                dgvFolha.AutoGenerateColumns = false;
                dgvFolha.DataSource = funcionarios;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro não identificado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                  = dgvFolha.CurrentRow.DataBoundItem as ;

                Frm_Registrar_Folha frm = new Frm_Registrar_Folha();
                Hide();
                frm.(data.id_Folha_Pgmt.ToString());
                frm.ShowDialog();
                Show();
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro não identificado.", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
