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
    public partial class tela_cadastro : Form
    {
        public tela_cadastro()
        {
            InitializeComponent();
        }

        private void tela_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void botão_aluno_Click(object sender, EventArgs e)
        {
            Login_Aluno telaAluno = new Login_Aluno();

            telaAluno.Show();
            this.Hide();
        }

        private void botão_professor_Click(object sender, EventArgs e)
        {

        }
    }
}
