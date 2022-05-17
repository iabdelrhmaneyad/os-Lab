using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace OSLAB3
{
    class Program
    {
        private static DateTime lastTime;
        private static TimeSpan lastTotalProcessorTime;
        private static DateTime curTime;
        private static TimeSpan curTotalProcessorTime;
        static void Main(string[] args)
        {
            string processName = "notepad";

            Console.WriteLine("Press any key to stop...\n");
            while (!Console.KeyAvailable)
            {
                Process[] pp = Process.GetProcessesByName(processName);
                
                if (pp.Length == 0)
                {
                    Console.WriteLine(processName + " does not exist");
                }
                else
                {
                    Process p = pp[0];
                    if (lastTime == DateTime.MinValue)//lastTime never be null it has the DateTime.MinValue
                    {
                        lastTime = DateTime.Now;
                        lastTotalProcessorTime = p.TotalProcessorTime;
                    }
                    else
                    {
                        curTime = DateTime.Now;
                        curTotalProcessorTime = p.TotalProcessorTime;
                        double CPUUsage = (curTotalProcessorTime.TotalMilliseconds - lastTotalProcessorTime.TotalMilliseconds) / curTime.Subtract(lastTime).TotalMilliseconds / Convert.ToDouble(Environment.ProcessorCount);
                        Console.WriteLine("{0} CPU: {1:0.0}%", processName, CPUUsage * 100);
                        lastTime = curTime;
                        lastTotalProcessorTime = curTotalProcessorTime;
                    }
                }
                Thread.Sleep(250);
            }
        }
    }
}
