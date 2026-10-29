using Academia.Academia;
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
    public partial class Cadastro_Professor_1 : Form
    {
        DAO bd;

        public Cadastro_Professor_1()
        {
            InitializeComponent();
            bd = new DAO();

            //"mãozinha" ao passar o mouse pelo menu
            botão_anterior.Cursor = Cursors.Hand;

        }

        private void Cadastro_Professor_1_Load(object sender, EventArgs e)
        {

        }

        private void botão_cadastro1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nome.Text))
            {
                MessageBox.Show("Informe o nome do aluno.");
                textBox_nome.Focus();
                return;
            }

            string cpf = new string(maskedTextBox_CPF.Text.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve ter 11 dígitos.");
                maskedTextBox_CPF.Focus();
                return;
            }

            Aluno aluno = new Aluno
            {
                Nome = textBox_nome.Text.Trim(),
                Cpf = cpf
            };

            this.Hide();
            using (Página_Cadastro2 pagina2 = new Página_Cadastro2(aluno, bd))
            {
                DialogResult resultado = pagina2.ShowDialog();

                if (resultado == DialogResult.OK)
                    LimparCampos();
            }
            this.Show();
        }//fim de botão_cadastro_Click

        private void LimparCampos()
        {
            textBox_nome.Clear();
            maskedTextBox_CPF.Clear();
            textBox_nome.Focus();
        }//fim de LimparCampos

        private void botão_anterior_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Administração_1>(this);
        }
    }//fim da classe
}//fim do projeto
