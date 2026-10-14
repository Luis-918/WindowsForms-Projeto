using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academia
{
    public partial class Login_Aluno : Form
    {
        DAO bd;

        public Login_Aluno()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void Login_do_Aluno_Load(object sender, EventArgs e)
        {

        }

        private void caixa_email_CPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void esqueci_senha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Entre em contato com a academia para recuperar sua senha.",
                "Recuperação de senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
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
