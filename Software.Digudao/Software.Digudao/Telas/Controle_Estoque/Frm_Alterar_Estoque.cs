﻿using prototipos.DB.Estoque;
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
        private void AlterarEstoque()
        {
            EstoqueDTO dto = new EstoqueDTO();
            dto.Id_Estoque = int.Parse(textBox8.Text);
            dto.id_produto_id = int.Parse(textBox1.Text);
            dto.kl_kilo = decimal.Parse(textBox2.Text);
            dto.nm_nome = textBox4.Text;
            dto.pc_preçoporcaixa = decimal.Parse(textBox5.Text);
            dto.Qn_Quantidade = int.Parse(textBox3.Text);
            dto.Tm_tamanho = textBox6.Text;
            EstoqueBusiness business = new EstoqueBusiness();
            business.Alterar(dto);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AlterarEstoque();
            MessageBox.Show("Dados salvos com sucesso", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
