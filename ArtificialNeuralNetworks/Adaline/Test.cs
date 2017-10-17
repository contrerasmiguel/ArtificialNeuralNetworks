using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Common;

namespace Adaline
{
    public partial class Test : Form
    {
        MainMenu mainMenuWindow;
        Series chartSepLine, redPoints, bluePoints;
        List<TrainingElement> trainingSet;

        const double MAX_ERROR = 0.01;
        const double LEARNING_RATE = 0.01;
        long maxIterations = 5000;
        double wc, wy, wx;
        Timer timer;
        long iterations;

        public Test(MainMenu mainMenu, List<TrainingElement> ts)
        {
            InitializeComponent();
            mainMenuWindow = mainMenu;
            trainingSet = ts;

            chrtHypSeparator.Series.Clear();
            chrtHypSeparator.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrtHypSeparator.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chrtHypSeparator.ChartAreas[0].AxisX.Crossing = 0;
            chrtHypSeparator.ChartAreas[0].AxisY.Crossing = 0;

            chrtHypSeparator.ChartAreas[0].AxisX.Minimum = 0;
            chrtHypSeparator.ChartAreas[0].AxisX.Maximum = 10;
            chrtHypSeparator.ChartAreas[0].AxisY.Minimum = 0;
            chrtHypSeparator.ChartAreas[0].AxisY.Maximum = 10;

            chrtHypSeparator.ChartAreas[0].AxisX.Interval = 1;
            chrtHypSeparator.ChartAreas[0].AxisY.Interval = 1;

            chartSepLine = chrtHypSeparator.Series.Add("H. Separador");
            chartSepLine.ChartType = SeriesChartType.Line;
            chartSepLine.Color = Color.Black;
            chartSepLine.Points.Clear();

            redPoints = chrtHypSeparator.Series.Add("Clase Rojo");
            redPoints.ChartType = SeriesChartType.Point;
            redPoints.MarkerColor = Color.Red;

            bluePoints = chrtHypSeparator.Series.Add("Clase Azul");
            bluePoints.ChartType = SeriesChartType.Point;
            bluePoints.MarkerColor = Color.Blue;

            timer = new Timer();

            AssignRandomWeights();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            mainMenuWindow.Show();
        }

        private void Test_VisibleChanged(object sender, EventArgs e)
        {
            lblIterations.Text = "Iteraciones: " + iterations;
            tbMaxIterations.Text = maxIterations.ToString();
            LoadTrainingSet();
        }

        private void chrtHypSeparator_MouseUp(object sender, MouseEventArgs e)
        {
            double x = chrtHypSeparator.ChartAreas[0].AxisX.PixelPositionToValue((e.X < 0) ? 0 : e.X);
            double y = chrtHypSeparator.ChartAreas[0].AxisY.PixelPositionToValue((e.Y < 0) ? 0 : e.Y);

            ((Output(1, x, y) < 0) ? redPoints : bluePoints).Points.AddXY(x, y);
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            mainMenuWindow.Close();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            AssignRandomWeights();

            iterations = 0;
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool foundError = false;

            foreach (var te in trainingSet)
            {
                double error = te.Sigma - Output(te.C, te.X, te.Y);

                // Update rule
                wc += LEARNING_RATE * error * te.C;
                wx += LEARNING_RATE * error * te.X;
                wy += LEARNING_RATE * error * te.Y;

                if (Math.Abs(error) >= MAX_ERROR)
                {
                    foundError = true;
                }
            }

            iterations += 1;

            if (!foundError || iterations >= maxIterations)
            {
                timer.Stop();
            }

            DrawSeparatorLine();
            lblIterations.Text = "Iteraciones: " + iterations;
        }

        private void tbMaxIterations_TextChanged(object sender, EventArgs e)
        {
            maxIterations = int.Parse(tbMaxIterations.Text);
        }

        private void DrawSeparatorLine()
        {
            chartSepLine.Points.Clear();

            // xLeft should be the opposite of xRight.
            double xLeft = -100;
            double xRight = 100;

            // TO-DO: find out why yLeft depends on xRight.
            double yLeft = (wx * xRight - wc) / wy;

            // TO-DO: find out why yRight depends on xLeft.
            double yRight = (wx * xLeft - wc) / wy;

            chartSepLine.Points.AddXY(xLeft, yLeft);
            chartSepLine.Points.AddXY(xRight, yRight);
        }

        private void LoadTrainingSet()
        {
            redPoints.Points.Clear();
            bluePoints.Points.Clear();

            foreach (var te in trainingSet)
            {
                ((te.Sigma < 0) ? redPoints : bluePoints).Points.AddXY(te.X, te.Y);
            }
        }

        private double Output(double c, double x, double y)
        {
            return wc * c + wx * x + wy * y;
        }

        private void AssignRandomWeights()
        {
            Random r = new Random();
            wc = r.NextDouble();
            wx = r.NextDouble();
            wy = r.NextDouble();
        }
    }
}
