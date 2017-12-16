using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Padaria.Administrador
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.FormClosed += (s, args) => Close();
            telaPrincipal.Show();
        }
    }
}
