﻿// <auto-generated />
using System;
using CoreComponents.Performance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreComponents.Migrations
{
    [DbContext(typeof(CPUMetricsContext))]
    partial class CPUMetricsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("CoreComponents.Performance.CPUMetrics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Average");

                    b.Property<Guid>("JGUID");

                    b.Property<float>("Maximum");

                    b.Property<float>("Minimum");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("cpuMetrics");
                });
#pragma warning restore 612, 618
        }
    }
}
