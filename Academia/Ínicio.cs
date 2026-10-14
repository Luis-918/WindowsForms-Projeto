using System;
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
    public partial class tela_login : Form
    {

        DAO bd;

        public tela_login()
        {
            InitializeComponent();
            bd = new DAO();
        }
        private void tela_login_Load(object sender, EventArgs e)
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
            Login_do_Professor telaAluno = new Login_do_Professor();

            telaAluno.Show();
            this.Hide();
        }
    }
}
