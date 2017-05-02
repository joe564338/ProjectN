using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectN2.Models.NeuralNetwork
{
    public class Network
    {
        public List<Layer> Layers { get; set; }
        public Network()
        {
            Layers = new List<Layer>();
        }
        public int GetLargestLayerSize()
        {
            int largestSize = 0;
            foreach (Layer l in Layers)
            {
                if (l.GetLayerSize() > largestSize)
                {
                    largestSize = l.GetLayerSize();
                }
            }
            return largestSize;
        }
        public int GetLargestSynapseCount()
        {
            int largestCount = 0;
            foreach (Layer l in Layers)
            {
                foreach (Neuron n in l.Neurons)
                {
                    if (n.InboundNeurons.Length > largestCount)
                    {
                        largestCount = n.InboundNeurons.Length;
                    }
                }
            }
            return largestCount;
        }
    }
}
