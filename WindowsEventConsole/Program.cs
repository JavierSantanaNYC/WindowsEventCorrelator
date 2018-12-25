using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEventCorrelator.Performance;

namespace WindowsEventConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Perfmon _perf = new Perfmon();
            int counter = 0;

            // init to start capturing
            _perf.GetCpuTotal();
            do
            {
                Console.WriteLine(_perf.GetCpuTotal());
                counter++;
            } while (counter <= 25);
            
        }
    }
}
