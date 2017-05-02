using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public class TrainerReinforced
    {
        Network Network;
        double[][] InputTrainingData;
        double fitnessScore;
        public TrainerReinforced(Network Network, double[][] InputTrainingData)
        {
            this.Network = Network;
            this.InputTrainingData = InputTrainingData;
        }
    }
}
