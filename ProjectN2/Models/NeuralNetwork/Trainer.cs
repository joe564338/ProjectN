using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public abstract class Trainer
    {
        public Network Network { get; set; }

        public double[][] InputTrainingData { get; set; }

        //<Layer,Neuron,Synapse>
        List<List<List<double>>> deltaAdjustments = new List<List<List<double>>>();
        public Trainer(Network Network, double[][] InputTrainingData)
        {
            this.Network = Network;
            this.InputTrainingData = InputTrainingData;
        }
        public bool SaveNeuralNetworkState()
        {
            return true;
        }
        public abstract void Train();
        public abstract void BackPropagate();
    }
}
