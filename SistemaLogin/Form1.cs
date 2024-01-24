using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formlogin f = new Formlogin();

            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();
                if (Formlogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }

            }
            Visible = true;
        }

        private void label1_BoasVindas(object sender, EventArgs e)
        {

        }
    }
}
