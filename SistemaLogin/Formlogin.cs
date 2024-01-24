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
    public partial class Formlogin : Form
    {
        public static bool Cancelar = false;

        public Formlogin()
        {
            InitializeComponent();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = textUsuario.Text;
            string senha = textSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
