using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class MainMenu : Form
    {
        Training trainingWindow;
        Test testWindow;

        public MainMenu()
        {
            InitializeComponent();
            trainingWindow = new Training(this);
            testWindow = new Test(this);
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Hide();
            trainingWindow.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Hide();
            testWindow.Show();
        }
    }
}
