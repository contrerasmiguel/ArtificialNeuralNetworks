using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using Common;

namespace Adaline
{
    public partial class MainMenu : Form
    {
        Training trainingWindow;
        Test testWindow;
        Form tSelectionForm;

        public MainMenu(Form nts)
        {
            InitializeComponent();
            trainingWindow = new Training(this);
            tSelectionForm = nts;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            tSelectionForm.Show();
        }

        private List<TrainingElement> LoadTrainingSet()
        {
            var profilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var adalinePath = Path.Combine(profilePath, @"ANN");

            if (!Directory.Exists(adalinePath))
            {
                Directory.CreateDirectory(adalinePath);
            }

            var path = Path.Combine(adalinePath, @"Adaline.TrainingSet.json");

            if (File.Exists(path))
            {
                using (var fs = File.Open(path, FileMode.Open))
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<TrainingElement>));

                    try
                    {
                        return serializer.ReadObject(fs) as List<TrainingElement>;
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                    finally
                    {
                        fs.Flush();
                    }
                }
            }
            return null;
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            List<TrainingElement> trainingSet = LoadTrainingSet();

            if (trainingSet != null)
            {
                testWindow = new Test(this, trainingSet);
                btnTest.Enabled = true;
            }
            else
            {
                btnTest.Enabled = false;
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            tSelectionForm.Close();
        }
    }
}
