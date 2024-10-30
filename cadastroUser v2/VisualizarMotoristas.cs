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
    public partial class VisualizarMotoristas : Form
    {
        private MotoristaController motoristaController;


        public VisualizarMotoristas()
        {
            InitializeComponent();
            motoristaController = new MotoristaController(new MotoristaDao());
            ConfigurarListView();
        }

        private void ConfigurarListView()
        {
            listaMotoristas.View = View.Details;
            listaMotoristas.FullRowSelect = true;
            listaMotoristas.GridLines = true;

            listaMotoristas.Columns.Add("ID", 50); 
            listaMotoristas.Columns.Add("Nome", 150);
            listaMotoristas.Columns.Add("Email", 200);
            listaMotoristas.Columns.Add("Telefone", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Motorista> motoristas = motoristaController.GetMotoristas();
            listaMotoristas.Items.Clear(); 

            foreach (var motorista in motoristas)
            {
                ListViewItem item = new ListViewItem(motorista.Id.ToString());
                item.SubItems.Add(motorista.Nome);
                item.SubItems.Add(motorista.Email);
                item.SubItems.Add(motorista.Telefone);

                listaMotoristas.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listaMotoristas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaMotoristas.SelectedItems[0];
                int motoristaId = int.Parse(selectedItem.Text); 
                motoristaController.DeleteMotorista(motoristaId);

                button1_Click(sender, e);

                MessageBox.Show("Motorista excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um motorista para excluir.");
            }
        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 escolhaAcao = new Form1();
            escolhaAcao.Show();
        }
    }

}
