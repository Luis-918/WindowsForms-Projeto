using Academia.Academia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academia
{
    public partial class Administração_1 : Form
    {
        public Administração_1()
        {
            InitializeComponent();

            Navegacao.Registrar(this);//só nesta página, que é a primeira a abrir

            //"mãozinha" ao passar o mouse pelo menu
            botão_aluno.Cursor = Cursors.Hand;
            botão_professor.Cursor = Cursors.Hand;

        }

        private void Administração_1_Load(object sender, EventArgs e)
        {

        }

        private void botão_aluno_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Cadastro1>(this);
        }

        private void botão_professor_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Cadastro_Professor_1>(this);
        }
    }//fim da classe
}//fim do projeto
