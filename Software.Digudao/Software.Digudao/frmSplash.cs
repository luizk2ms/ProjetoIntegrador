using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();



            Task.Factory.StartNew(() =>
            {
            
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(4800);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    Inicio frm = new Inicio();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
