using Academia.Academia;
using MySql.Data.MySqlClient;//Importar os elementos do MySQL
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
    public partial class Página_Login : Form
    {

        DAO bd;

        public Página_Login()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void Página_Login_Load(object sender, EventArgs e)
        {

        }

        private void botão_login_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Navegacao.IrPara<Página_Inicial_1>(this);
=======

>>>>>>> 8c5d3b982d58c3584424456d65f986d9b1019839
        }

        private void botão_cadastro_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Cadastro1>(this);
        }
    }//fim da classe
}//fim do projeto
