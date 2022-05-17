using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace UseGetProcessesByName
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Omit the exe part.
                 Process[] edges = Process.GetProcessesByName("MSEDGE");
                //Process[] edges = Process.GetProcessesByName("Teams");
                Console.WriteLine("{0} Edge processes", edges.Length);
                Thread.Sleep(5000);
            }
        }
    }
}
