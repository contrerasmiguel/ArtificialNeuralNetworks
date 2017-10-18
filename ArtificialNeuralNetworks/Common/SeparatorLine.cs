using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Common
{
    class SeparatorLine
    {
        private DataPoint p1, p2;

        public DataPoint P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
                CalculateLineEdges();
            }
        }

        public DataPoint P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
                CalculateLineEdges();
            }
        }

        public SeparatorLine()
        {
            p1 = new DataPoint(0, 5);
            p2 = new DataPoint(1, 5);
            CalculateLineEdges();
        }

        private void CalculateLineEdges()
        {
            DataPoint leftPoint, rightPoint;
            double m;

            // Ordered by X
            if (p1.XValue < p2.XValue)
            {
                leftPoint = p1;
                rightPoint = p2;
            }
            else
            {
                leftPoint = p2;
                rightPoint = p1;
            }

            // Line slope
            m = (rightPoint.YValues[0] - leftPoint.YValues[0]) / (rightPoint.XValue - leftPoint.XValue);

            // Left edge
            p1.YValues[0] = m * (0 - leftPoint.XValue) + leftPoint.YValues[0];
            p1.XValue = 0;

            // Right edge
            p2.YValues[0] = m * (10 - leftPoint.XValue) + leftPoint.YValues[0];
            p2.XValue = 10;
        }

        public double ActivationF(DataPoint dp)
        {
            // Ecuación de la recta que pasa por dos puntos igualada a cero.
            return (dp.XValue - p1.XValue) * (p2.YValues[0] - p1.YValues[0]) / (p2.XValue - p1.XValue) + p1.YValues[0] - dp.YValues[0];
        }
    }
}
