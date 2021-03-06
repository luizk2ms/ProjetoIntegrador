﻿using prototipos.DB.Estoque;
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
    public partial class Frm_Alterar_Estoque : Form
    {
        public Frm_Alterar_Estoque()
        {
            InitializeComponent();
        }
        private void CarregarEstoque()
        {
            ProdutoBusiness Estoque = new ProdutoBusiness();
            comboBox1.DisplayMember = nameof(ProdutoDTO.Nm_Nome);

            comboBox1.DataSource = Estoque.Listar();
        }
        private void AlterarEstoque()
        {
            EstoqueDTO dto = new EstoqueDTO();
            dto.dt_data = DateTime.Parse(mktnascimento.Text);
            dto.Qn_QuantidadeEmKg = textBox2.Text;
            dto.Pc_preco = textBox5.Text;
            dto.Qn_Quantidade = textBox3.Text;
            dto.Tm_tamanho = textBox6.Text;
            EstoqueBusiness business = new EstoqueBusiness();
            business.Alterar(dto);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AlterarEstoque();
            MessageBox.Show("Dados salvos com sucesso", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
