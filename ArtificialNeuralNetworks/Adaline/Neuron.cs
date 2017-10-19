using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adaline
{
    public class Neuron
    {
        double wc;
        public double Wc
        {
            get { return wc; }
            set { wc = value; }
        }

        double wx;
        public double Wx
        {
            get { return wx; }
            set { wx = value; }
        }

        double wy;
        public double Wy
        {
            get { return wy; }
            set { wy = value; }
        }

        public Neuron()
        {
            AssignRandomWeights();
        }

        public Neuron(double wc, double wx, double wy)
        {
            this.wc = wc;
            this.wx = wx;
            this.wy = wy;
        }

        public void AssignRandomWeights()
        {
            Random r = new Random();

            wc = r.NextDouble();
            wx = r.NextDouble();
            wy = r.NextDouble();
        }

        public double Output(double c, double x, double y)
        {
            return Math.Tanh(wc * c + wx * x + wy * y);
        }

        public double OutputDerivative(double c, double x, double y)
        {
            return 1 - Math.Pow(Output(c, x, y), 2);
        }
    }
}
