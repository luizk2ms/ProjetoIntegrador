using Software.Digudao.DB.Controle_de_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Telas
{
    public partial class Frm_Usuario1 : Form
    {
        public Frm_Usuario1()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Usuario1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = new UsuarioDTO();
                user.nm_Usuario = txtSenha.Text;
                user.ds_Senha = txtUsuario.Text;
                user.ds_Situacao = true;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro não identificado.", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string cod()
        {


            //Cadastrar
            string clasC1 = chkCad1.Checked == true ? "B" : "0";
            string clasC2 = chkCad2.Checked == true ? "B" : "0";
            string clasC3 = chkCad3.Checked == true ? "B" : "0";
   
            string clasC5 = chkCad5.Checked == true ? "B" : "0";
            string clasC6 = chkCad6.Checked == true ? "B" : "0";
            string clasC7 = chkCad7.Checked == true ? "B" : "0";
            string clasC8 = chkCad8.Checked == true ? "B" : "0";
            string clasC9 = chkCad9.Checked == true ? "B" : "0";
            

            //Consultar
            string clasCo1 = chkCon1.Checked == true ? "C" : "0";
            string clasCo2 = chkCon2.Checked == true ? "C" : "0";
            string clasCo3 = chkCon3.Checked == true ? "C" : "0";
            string clasCo5 = chkCon5.Checked == true ? "C" : "0";
            string clasCo6 = chkCon6.Checked == true ? "C" : "0";
            string clasCo7 = chkCon7.Checked == true ? "C" : "0";
            string clasCo8 = chkCon8.Checked == true ? "C" : "0";
            string clasCo9 = chkCon9.Checked == true ? "C" : "0";
            

            //Alterar
            string clasAlt1 = chkAlt1.Checked == true ? "D" : "0";
            string clasAlt2 = chkAlt2.Checked == true ? "D" : "0";
            string clasAlt3 = chkAlt3.Checked == true ? "D" : "0";
            string clasAlt5 = chkAlt5.Checked == true ? "D" : "0";
            string clasAlt6 = chkAlt6.Checked == true ? "D" : "0";
            string clasAlt7 = chkAlt7.Checked == true ? "D" : "0";
            string clasAlt8 = chkAlt8.Checked == true ? "D" : "0";
            string clasAlt9 = chkAlt9.Checked == true ? "D" : "0";
            



            return cod();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
