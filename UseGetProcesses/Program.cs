using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace UseGetProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show all processes on the local computer.
            Process[] processes = Process.GetProcesses();
            // Display count.
            Console.WriteLine("Count: {0}", processes.Length);
            // Loop over processes.
            foreach (Process process in processes)
            {
                Console.WriteLine(process.TotalProcessorTime);
            }
        }
    }
}
