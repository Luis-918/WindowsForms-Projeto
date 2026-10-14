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
    public partial class Cadastro_do_Aluno : Form
    {
        public Cadastro_do_Aluno()
        {
            InitializeComponent();
        }

        private void Cadastro_do_Aluno_Load(object sender, EventArgs e)
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
