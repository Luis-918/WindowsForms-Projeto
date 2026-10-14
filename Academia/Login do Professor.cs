using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Login_do_Professor : Form
    {
        public Login_do_Professor()
        {
            InitializeComponent();
        }

        private void Login_do_Professor_Load(object sender, EventArgs e)
        {

        }

        private void caixa_email_CPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_área_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void botão_confirmar_Click(object sender, EventArgs e)
        {

        }

        private void botão_voltar_Click(object sender, EventArgs e)
        {
            tela_login telaLogin = new tela_login();

            telaLogin.Show();
            this.Hide();
        }
    }
}
