using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Academia
{
    public partial class Cadastro_Professor_2 : Form
    {
        private Professor professor;
        private DAO bd;

        // Recebe os dados da página 1 e o DAO
        public Cadastro_Professor_2(Professor professor, DAO bd)
        {
            InitializeComponent();
            this.professor = professor;
            this.bd = bd;
        }

        private void Cadastro_Professor_2_Load(object sender, EventArgs e)
        {
        }

        private void botão_cadastro2_Click(object sender, EventArgs e)
        {
            if (comboBox_sexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo.");
                return;
            }//fim do if

            decimal peso;
            if (!decimal.TryParse(textBox_peso.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out peso))
            {
                MessageBox.Show("Peso inválido. Exemplo: 70,5");
                textBox_peso.Focus();
                return;
            }//fim do if

            decimal altura;
            if (!decimal.TryParse(textBox_altura.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out altura))
            {
                MessageBox.Show("Altura inválida. Exemplo: 1,75");
                textBox_altura.Focus();
                return;
            }//fim do if

            //Completa o professor com os dados desta página
            professor.Telefone = maskedTextBox_telefone.Text.Trim();
            professor.DataNascimento = dateTimePicker1.Value.Date;
            professor.Sexo = comboBox_sexo.Text;
            professor.Peso = peso;
            professor.Altura = altura;

            try
            {
                string resultado = bd.CadastrarProfessor(professor.Nome, professor.Cpf,
                                                         professor.Telefone, professor.DataNascimento,
                                                         professor.Sexo, professor.Peso, professor.Altura);
                MessageBox.Show(resultado);
                this.DialogResult = DialogResult.OK;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível cadastrar.\n\n" + erro.Message);
            }
        }//fim de botão_cadastro2_Click

        private void botão_voltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }//fim de botão_voltar_Click
    }//fim da classe
}//fim do projeto