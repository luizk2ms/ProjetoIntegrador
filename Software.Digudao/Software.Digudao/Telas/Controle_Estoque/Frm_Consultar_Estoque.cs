using prototipos.DB.Estoque;
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
    public partial class Frm_Consultar_Estoque : Form
    {
        public Frm_Consultar_Estoque()
        {
            InitializeComponent();
        }
        private void CarregarDadosEstoque()
        {
            EstoqueBusiness Estoque = new EstoqueBusiness();
            List<EstoqueViewDTo> view = Estoque.ConsultarporNome(textBox2.Text);
            EstoqueViewDTo dto = view[0];
            dataGridView1.DataSource = view;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                Frm_Cadastro_Estoque cadastrarEstoque = new Frm_Cadastro_Estoque();
                EstoqueViewDTo dto = dataGridView1.CurrentRow.DataBoundItem as EstoqueViewDTo;
                int Id_Estoque, id_produto_id;
                string nm_nome;
                Id_Estoque = dto.Id_Estoque;
                id_produto_id = dto.id_produto_id;
                nm_nome = dto.nm_nome;
                cadastrarEstoque.LoadScreen(id_produto_id, Id_Estoque, nm_nome);
                cadastrarEstoque.Show();
            }
            if (e.ColumnIndex == 8)
            {
                EstoqueBusiness Estoques = new EstoqueBusiness();
                EstoqueViewDTo dto = dataGridView1.CurrentRow.DataBoundItem as  EstoqueViewDTo;
                Estoques.Remover(dto.Id_Estoque);
                CarregarDadosEstoque();


            }

        }
    }
}
