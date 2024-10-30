using cadastroUser_v2.Controllers;
using cadastroUser_v2.DAO;
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
    public partial class CadastroVeiculo : Form
    {
        private readonly MotoristaController motoristaController;

        private readonly VeiculoController veiculoController;
        public CadastroVeiculo()
        {
            InitializeComponent();
            motoristaController = new MotoristaController(new MotoristaDao());
            veiculoController = new VeiculoController(new VeiculoDao());
            CarregarMotoristasComboBox();
        }

        private void CarregarMotoristasComboBox()
        {
            var motoristas = motoristaController.GetMotoristas();

            comboBox_motoristas.DataSource = motoristas;    
            comboBox_motoristas.DisplayMember = "Nome";
            comboBox_motoristas.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = placa_txt.Text;
            string modelo = modelo_txt.Text;
            string cor = cor_txt.Text;
            int id_motorista = (int)comboBox_motoristas.SelectedValue;

            veiculoController.addVeiculo(id_motorista, placa, modelo, cor);
            MessageBox.Show("Dados salvos com sucesso!");
        }
    }
}
