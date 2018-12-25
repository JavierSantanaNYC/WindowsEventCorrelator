using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsEventCorrelator.Performance
{
    public class Perfmon
    {
        private static PerformanceCounter cpuTotal;
        private static PerformanceCounter memoryTotal;
        private static PerformanceCounter diskTime;

        public Perfmon()
        {
            CreateCounters();
        }
        // example : https://www.andygup.net/a-better-way-to-measure-cpu-using-windows-performancecounter-and-c/
        public float GetCpuTotal()
        {
            CounterSample c1 = cpuTotal.NextSample();
            System.Threading.Thread.Sleep(1000);
            CounterSample c2 = cpuTotal.NextSample();
            return CounterSample.Calculate(c1, c2);
        }
        public float GetMemoryTotal()
        {
            CounterSample m1 = memoryTotal.NextSample();
            System.Threading.Thread.Sleep(1000);
            CounterSample m2 = memoryTotal.NextSample();
            return CounterSample.Calculate(m1, m2);
        }
        public float GetDiskTime()
        {
            CounterSample d1 = diskTime.NextSample();
            System.Threading.Thread.Sleep(1000);
            CounterSample d2 = diskTime.NextSample();
            return CounterSample.Calculate(d1, d2);
        }
        private static void CreateCounters()
        {
            // Create the counters.
            cpuTotal = new PerformanceCounter(
                    "Processor Information", 
                    "% Processor Time",
                    "_Total",
                    true);
            memoryTotal = new PerformanceCounter(
                "Memory",
                "Available MBytes"
                );
            // TODO: Enumerate volumes
            diskTime = new PerformanceCounter(
                "LogicalDisk",
                "% Disk Time"
                );
            
        }

        

    }
}
