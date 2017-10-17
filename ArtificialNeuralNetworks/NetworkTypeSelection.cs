using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtificialNeuralNetworks
{
    public partial class NetworkTypeSelection : Form
    {
        Perceptron.MainMenu perceptronMainMenu;
        Adaline.MainMenu adalineMainMenu;

        public NetworkTypeSelection()
        {
            InitializeComponent();
            perceptronMainMenu = new Perceptron.MainMenu(this);
            adalineMainMenu = new Adaline.MainMenu(this);
        }

        private void btnPerceptron_Click(object sender, EventArgs e)
        {
            Hide();
            perceptronMainMenu.Show();
        }

        private void btnAdaline_Click(object sender, EventArgs e)
        {
            Hide();
            adalineMainMenu.Show();
        }
    }
}
