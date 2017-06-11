using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Perceptron
{
    [DataContract]
    class TrainingElement
    {
        public double C
        {
            get
            {
                return c;
            }
        }

        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public double Sigma
        {
            get
            {
                return sigma;
            }
        }

        [DataMember]
        double c, x, y;

        [DataMember]
        int sigma;

        public TrainingElement(double c, double x, double y, int sigma)
        {
            this.c = c;
            this.x = x;
            this.y = y;
            this.sigma = sigma;
        }
    }
}
