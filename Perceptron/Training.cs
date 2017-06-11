using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Perceptron
{
    public partial class Training : Form
    {
        MainMenu mainMenuWindow;
        SeparatorLine sl;
        Series chartSepLine, redPoints, bluePoints;
        List<DataPoint> dps;
        bool dragging;

        public Training(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuWindow = mainMenu;

            sl = new SeparatorLine();
            dps = new List<DataPoint>();

            chrtHypSeparator.Series.Clear();
            chrtHypSeparator.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrtHypSeparator.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrtHypSeparator.ChartAreas[0].AxisX.Minimum = 0;
            chrtHypSeparator.ChartAreas[0].AxisX.Maximum = 10;
            chrtHypSeparator.ChartAreas[0].AxisY.Minimum = 0;
            chrtHypSeparator.ChartAreas[0].AxisY.Maximum = 10;

            chrtHypSeparator.ChartAreas[0].AxisX.Interval = 1;
            chrtHypSeparator.ChartAreas[0].AxisY.Interval = 1;

            chartSepLine = chrtHypSeparator.Series.Add("H. Separador");
            chartSepLine.ChartType = SeriesChartType.Line;
            chartSepLine.Points.Clear();
            chartSepLine.Points.AddXY(sl.P1.XValue, sl.P1.YValues[0]);
            chartSepLine.Points.AddXY(sl.P2.XValue, sl.P2.YValues[0]);

            redPoints = chrtHypSeparator.Series.Add("Clase Rojo");
            redPoints.ChartType = SeriesChartType.Point;
            redPoints.MarkerColor = Color.Red;

            bluePoints = chrtHypSeparator.Series.Add("Clase Azul");
            bluePoints.ChartType = SeriesChartType.Point;
            bluePoints.MarkerColor = Color.Blue;

            dragging = false;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            mainMenuWindow.Show();
        }

        private void Training_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenuWindow.Close();
        }

        private void chrtHypSeparator_MouseDown(object sender, MouseEventArgs e)
        {
            double x = chrtHypSeparator.ChartAreas[0].AxisX.PixelPositionToValue((e.X < 0) ? 0 : e.X);
            double y = chrtHypSeparator.ChartAreas[0].AxisY.PixelPositionToValue((e.Y < 0) ? 0 : e.Y);

            if (rbDrawLine.Checked)
            {
                sl.P1 = new DataPoint(x, y);
            }

            dragging = true;
        }

        private void chrtHypSeparator_MouseUp(object sender, MouseEventArgs e)
        {
            double x = chrtHypSeparator.ChartAreas[0].AxisX.PixelPositionToValue((e.X < 0) ? 0 : e.X);
            double y = chrtHypSeparator.ChartAreas[0].AxisY.PixelPositionToValue((e.Y < 0) ? 0 : e.Y);

            if (rbDrawLine.Checked)
            {
                sl.P2 = new DataPoint(x, y);

                chartSepLine.Points.Clear();
                chartSepLine.Points.AddXY(sl.P1.XValue, sl.P1.YValues[0]);
                chartSepLine.Points.AddXY(sl.P2.XValue, sl.P2.YValues[0]);

                ClassifyPoints();
            }
            else
            {
                var dp = new DataPoint(x, y);
                dps.Add(dp);

                ((sl.TestPoint(dp) == 1) ? redPoints : bluePoints).Points.Add(dp);
            }

            StoreTrainingSet();
            dragging = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sl = new SeparatorLine();
            dps.Clear();

            chartSepLine.Points.Clear();
            chartSepLine.Points.AddXY(sl.P1.XValue, sl.P1.YValues[0]);
            chartSepLine.Points.AddXY(sl.P2.XValue, sl.P2.YValues[0]);

            redPoints.Points.Clear();
            bluePoints.Points.Clear();

            StoreTrainingSet();
        }

        private void chrtHypSeparator_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && rbDrawLine.Checked)
            {
                double x = chrtHypSeparator.ChartAreas[0].AxisX.PixelPositionToValue((e.X < 0) ? 0 : e.X);
                double y = chrtHypSeparator.ChartAreas[0].AxisY.PixelPositionToValue((e.Y < 0) ? 0 : e.Y);

                sl.P2 = new DataPoint(x, y);

                chartSepLine.Points.Clear();
                chartSepLine.Points.AddXY(sl.P1.XValue, sl.P1.YValues[0]);
                chartSepLine.Points.AddXY(sl.P2.XValue, sl.P2.YValues[0]);

                ClassifyPoints();
            }
        }

        private void ClassifyPoints()
        {
            redPoints.Points.Clear();
            bluePoints.Points.Clear();

            foreach (var dp in dps)
            {
                ((sl.TestPoint(dp) == 1) ? redPoints : bluePoints).Points.Add(dp);
            }
        }

        private void StoreTrainingSet()
        {
            var profilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var perceptronPath = Path.Combine(profilePath, @"Perceptron");

            if (!Directory.Exists(perceptronPath))
            {
                Directory.CreateDirectory(perceptronPath);
            }

            var path = Path.Combine(perceptronPath, @"TrainingSet.json");

            using (var fs = File.Open(path, FileMode.Create))
            {
                var serializer = new DataContractJsonSerializer(typeof(List<TrainingElement>));
                var trainingSet = dps.Select(dp => new TrainingElement(1, dp.XValue, dp.YValues[0], sl.TestPoint(dp)));

                serializer.WriteObject(fs, trainingSet);
                fs.Flush();
            }
        }
    }
}
