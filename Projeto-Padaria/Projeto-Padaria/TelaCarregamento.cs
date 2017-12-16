using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Padaria
{
    public partial class TelaCarregamento : Form
    {
        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                load.Width += 5;

                if (load.Width >= 607)
                {
                    timer1.Stop();
                    Administrador.LoginAdministrador form = new Administrador.LoginAdministrador();
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
