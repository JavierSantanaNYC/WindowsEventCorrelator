using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CoreComponents.Base;

namespace CoreComponents.Performance
{
    public class CPUMetricsContext : DbContext
    {
        public DbSet<CPUMetrics> cpuMetrics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }

    public class CPUMetrics : BaseObjects
    {
        public int Id { get; set; }
        public float Average { get; set; }
        public float Minimum { get; set; }
        public float Maximum { get; set; }
    }

    

}
