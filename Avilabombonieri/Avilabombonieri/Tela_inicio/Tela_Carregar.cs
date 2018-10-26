using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Tela_inicio
{
    public partial class Tela_Carregar : Form
    {
        public Tela_Carregar()
        {
            InitializeComponent();




            Task.Factory.StartNew(() =>
            {
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(4800);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    inicio frm = new inicio();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void Tela_Carregar_Load(object sender, EventArgs e)
        {

        }
    }
}
