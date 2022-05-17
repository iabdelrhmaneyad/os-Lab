 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace KillMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start notepad.
            Process process = Process.Start("notepad.exe");
            // Wait one second.
            Thread.Sleep(3000);
            // End notepad.
            process.Kill();
           // Console.WriteLine(process.ExitCode);
        }
    }
}
