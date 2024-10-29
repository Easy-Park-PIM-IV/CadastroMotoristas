using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadastroUser_v2;

namespace cadastroUser_v2
{
    public partial class CadastroMotoristaView : Form
    {
        private MotoristaController motoristaController;
        public CadastroMotoristaView()
        {
            InitializeComponent();
            motoristaController = new MotoristaController(new MotoristaDao());
        }

        private void cadastrar_button_Click(object sender, EventArgs e)
        {
            string nome = nome_textbox.Text;
            string email = email_textbox.Text;
            string placa = placa_textbox.Text;

            motoristaController.AddMotorista(nome, email, placa);
            MessageBox.Show("Dados salvos com sucesso!");
        }
    }
 } 
