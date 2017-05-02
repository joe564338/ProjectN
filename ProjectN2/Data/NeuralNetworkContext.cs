using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectN2.Models
{
    public class NeuralNetworkContext : DbContext
    {
        public NeuralNetworkContext (DbContextOptions<NeuralNetworkContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectN2.Models.NeuralNetworks> NeuralNetworks { get; set; }
    }
}
