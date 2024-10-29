using cadastroUser_v2.Controllers;
using cadastroUser_v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroUser_v2
{
    public partial class LoginView : Form
    {

        private readonly UsuarioController usuarioController;

        public LoginView()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            string usuario = userTxt.Text;
            string senha = senhaTxt.Text;

            UsuarioEntity usuarioEncontrado = usuarioController.Login(usuario, senha);

            if (usuarioEncontrado != null && usuarioEncontrado.Tipo == "ADMIN")
            {
                MessageBox.Show("Login bem sucedido! Bem-vindo, " + usuarioEncontrado.Nome);
                this.Hide();
                Form1 escolhaAcao = new Form1();
                escolhaAcao.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente. ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        
    }
}
