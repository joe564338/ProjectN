using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }
        public Layer()
        {
            Neurons = new List<Neuron>();
        }
        public void AddNeuronToLayer(Neuron neuron)
        {
            Neurons.Add(neuron);
        }
        public int GetLayerSize()
        {
            return Neurons.Count();
        }
    }
}
