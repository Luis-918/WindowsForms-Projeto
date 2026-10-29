using Academia.Academia;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Academia
{
    public partial class Administração_2 : Form
    {
        DAO bd;

        public Administração_2()
        {
            InitializeComponent();
            bd = new DAO();

            //"mãozinha" ao passar o mouse pelo menu
            botão_atualizar.Cursor = Cursors.Hand;
            botão_excluir.Cursor = Cursors.Hand;
            botão_voltar.Cursor = Cursors.Hand;

        }

        private void Adminstração_2_Load(object sender, EventArgs e)
        {
            Grid_consultar.AllowUserToAddRows = false;//sem linha vazia no fim
            Grid_consultar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarGrid();
        }

        // Busca os alunos no banco e mostra na tabela
        private void CarregarGrid()
        {
            try
            {
                Grid_consultar.DataSource = bd.Consultar();

                Grid_consultar.Columns["codigo"].ReadOnly = true;//o código não pode ser editado
                Grid_consultar.Columns["codigo"].HeaderText = "Código";
                Grid_consultar.Columns["nome"].HeaderText = "Nome";
                Grid_consultar.Columns["CPF"].HeaderText = "CPF";
                Grid_consultar.Columns["telefone"].HeaderText = "Telefone";
                Grid_consultar.Columns["data_nascimento"].HeaderText = "Nascimento";
                Grid_consultar.Columns["sexo"].HeaderText = "Sexo";
                Grid_consultar.Columns["peso"].HeaderText = "Peso";
                Grid_consultar.Columns["altura"].HeaderText = "Altura";
                Grid_consultar.Columns["objetivo"].HeaderText = "Objetivo";
                Grid_consultar.Columns["plano_codigo"].HeaderText = "Plano";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível consultar.\n\n" + erro.Message);
            }
        }//fim de CarregarGrid

        private void Grid_consultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void botão_atualizar_Click(object sender, EventArgs e)
        {
            Grid_consultar.EndEdit();   // confirma a célula que ainda está em edição

            if (Grid_consultar.CurrentRow == null)
            {
                MessageBox.Show("Selecione um aluno na tabela.");
                return;
            }

            DataGridViewRow linha = Grid_consultar.CurrentRow;
            int codigo = Convert.ToInt32(linha.Cells["codigo"].Value);

            string[] campos = { "nome", "CPF", "telefone", "data_nascimento",
                                "sexo", "peso", "altura", "objetivo", "plano_codigo" };

            try
            {
                foreach (string campo in campos)
                    bd.Atualizar(codigo, campo, Formatar(linha.Cells[campo].Value));

                MessageBox.Show("Aluno atualizado!");
                CarregarGrid();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível atualizar.\n\n" + erro.Message);
            }
        }//fim de botão_atualizar_Click

        private void botão_excluir_Click(object sender, EventArgs e)
        {
            if (Grid_consultar.CurrentRow == null)
            {
                MessageBox.Show("Selecione um aluno na tabela.");
                return;
            }

            DataGridViewRow linha = Grid_consultar.CurrentRow;
            int codigo = Convert.ToInt32(linha.Cells["codigo"].Value);
            string nome = Convert.ToString(linha.Cells["nome"].Value);

            DialogResult resposta = MessageBox.Show(
                $"Deseja excluir o aluno {nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            try
            {
                MessageBox.Show(bd.Excluir(codigo));
                CarregarGrid();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível excluir.\n\n" + erro.Message);
            }
        }//fim de botão_excluir_Click

        // Converte o valor da célula para um texto que o MySQL entende
        // (data como 2000-05-10 e decimal com ponto: 58.50)
        private string Formatar(object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return null;

            if (valor is DateTime)
                return ((DateTime)valor).ToString("yyyy-MM-dd");

            if (valor is IFormattable)
                return ((IFormattable)valor).ToString(null, CultureInfo.InvariantCulture);

            return valor.ToString();
        }//fim de Formatar

        private void botão_voltar_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Menu>(this);
        }
    }//fim da classe
}//fim do projeto