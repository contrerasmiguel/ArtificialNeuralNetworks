using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Threading;

namespace Adaline
{
    class BackgroundTraining
    {
        Neuron neuron;

        List<TrainingElement> trainingSet;

        volatile bool isTraining;
        public bool IsTraining
        {
            get { return isTraining; }
        }

        double speed;
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        const double MAX_ERROR = 0.000005;
        const double LEARNING_RATE = 0.01;

        public BackgroundTraining(Neuron neuron, List<TrainingElement> trainingSet, double speed)
        {
            this.neuron = neuron;
            this.trainingSet = trainingSet;
            this.speed = speed;
            isTraining = false;
        }

        public double CalculateMeanSquaredError()
        {
            return trainingSet.Sum(trainingElement => Math.Pow(trainingElement.Sigma
                - neuron.Output(trainingElement.C, trainingElement.X, trainingElement.Y), 2)) / trainingSet.Count;
        }

        public void Train()
        {
            new Thread(delegate() 
            {
                while (CalculateMeanSquaredError() > MAX_ERROR)
                {
                    trainingSet.ForEach(trainingElement =>
                    {
                        neuron.Wc += LEARNING_RATE
                            * (trainingElement.Sigma - neuron.Output(trainingElement.C, trainingElement.X, trainingElement.Y))
                            * neuron.OutputDerivative(trainingElement.C, trainingElement.X, trainingElement.Y)
                            * trainingElement.C;

                        neuron.Wx += LEARNING_RATE
                            * (trainingElement.Sigma - neuron.Output(trainingElement.C, trainingElement.X, trainingElement.Y))
                            * neuron.OutputDerivative(trainingElement.C, trainingElement.X, trainingElement.Y)
                            * trainingElement.X;

                        neuron.Wy += LEARNING_RATE
                            * (trainingElement.Sigma - neuron.Output(trainingElement.C, trainingElement.X, trainingElement.Y))
                            * neuron.OutputDerivative(trainingElement.C, trainingElement.X, trainingElement.Y)
                            * trainingElement.Y;
                    });
                    Thread.Sleep(1);
                }
                isTraining = false;
            }).Start();
        }
    }
}
