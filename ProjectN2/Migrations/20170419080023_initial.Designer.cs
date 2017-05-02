using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectN2.Models;

namespace ProjectN2.Migrations
{
    [DbContext(typeof(NeuralNetworkContext))]
    [Migration("20170419080023_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectN2.Models.NeuralNetworks", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<int>("numOfLayers");

                    b.Property<int>("numOfNeurons");

                    b.HasKey("id");

                    b.ToTable("NeuralNetworks");
                });
        }
    }
}
