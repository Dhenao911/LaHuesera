using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loggeo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txUsuario.Text;
            string contrasenia=txContrasenia.Text;



            MessageBox.Show("Iniciando...");
        }
    }
}
