using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public class TrainerSupervised : Trainer
    {
        
        
        double[][] OutputTrainingData { get; set; }
        public TrainerSupervised(Network Network, double[][] InputTrainingData, double[][] OutputTrainingData) : base(Network, InputTrainingData)
        {
            this.OutputTrainingData = OutputTrainingData;
        }

        
        
        override
        public void BackPropagate()
        {
            List<List<double>> outputError = new List<List<double>>();
            foreach(Neuron n in Network.Layers[Network.Layers.Count - 1].Neurons)
            {
                //list for each individual output neuron errors 
                List<double> temp = new List<double>();
                foreach(double d in n.DataValues)
                {
                    
                }
            }
            List<List<double>> outputSynapsesAdjustments = new List<List<double>>();

        }
        public void BackPropagateRecurse()
        {

        }
        override
        public void Train()
        {

        }

    }
}
