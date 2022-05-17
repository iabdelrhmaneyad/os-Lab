using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TestArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine($"args[{i}] = {args[i]}");
            Process p = Process.GetProcessById(5816);
            Console.WriteLine($"process name {p.ProcessName}--- process Id {p.Id}");
            Console.ReadKey();
        }
    }
}
