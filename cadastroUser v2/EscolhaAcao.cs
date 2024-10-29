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
    public partial class Form1 : Form
    {
        private MotoristaController motoristaController;
        public Form1()
        {
            InitializeComponent();
        }

        private void VisuMotoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarMotoristas visualizarMotoristas = new VisualizarMotoristas();
            visualizarMotoristas.Show();

        }

        private void CadMotoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroMotoristaView casdastroForm = new CadastroMotoristaView();
            casdastroForm.Show();
        }
    }
}
