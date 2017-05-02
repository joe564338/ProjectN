using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public class Neuron
    {
        public double[] DataValues { get; set; }
        public double[] InboundWeights { get; set; }
        public Neuron[] InboundNeurons { get; set; }
        public Neuron(Neuron[] InboundNeurons, double[] InboundWeights)
        {
            this.InboundNeurons = InboundNeurons;
            this.InboundWeights = InboundWeights;
        }
        public static double Sigmoid(double x, bool deriv)
        {
            if (deriv == true)
            {
                return (x * (1 - x));
            }
            else
            {
                return (1 / (1 + Math.Pow(Math.E, (-1 * x))));
            }
        }
        public void ForwardPropagate()
        {
            for (int h = 0; h < DataValues.Length; h++)
            {
                DataValues[h] = 0;
                for(int i = 0; i < InboundWeights.Length; i++)
                {
                    DataValues[h] = Sigmoid(InboundNeurons[i].DataValues[h] * InboundWeights[i], deriv: false);
                }
            }
        }
    }
}
