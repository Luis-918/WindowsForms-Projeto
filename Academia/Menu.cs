using Academia.Academia;
using System;
using System.Windows.Forms;

namespace Academia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Navegacao.Registrar(this);//permite voltar ao menu de qualquer página

            // "mãozinha" ao passar o mouse pelo menu
            Página_Cadastro.Cursor = Cursors.Hand;
            Página_Consultar.Cursor = Cursors.Hand;
            Página_Login_Professor.Cursor = Cursors.Hand;
            Página_Login_Aluno.Cursor = Cursors.Hand;
            Página_Site.Cursor = Cursors.Hand;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Página_Cadastro_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show(
                "Quem você quer cadastrar?\n\nSim = Aluno\nNão = Professor",
                "Cadastro",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
                Navegacao.IrPara<Página_Cadastro1>(this);
            else if (escolha == DialogResult.No)
                Navegacao.IrPara<Cadastro_Professor_1>(this);   // confira o nome da 1ª página de professor
        }

        private void Página_Consultar_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Administração_2>(this);
        }

        private void Página_Site_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_1>(this);
        }

        private void Página_Login_Aluno_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Login>(this);   // troque pelo nome real da sua tela de login
        }

        private void Página_Login_Professor_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Login>(this);   // troque pelo nome real da sua tela de login
        }
    }//fim da classe
}//fim do projeto