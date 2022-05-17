using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;


namespace OSLAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    /*  if UseShellExecute is true then the Process class will use the ShellExecute function, 
                     *  otherwise it will use CreateProcess.   
                     *  ShellExecute is roughly equivalent to typing the command to be executed into the run dialog 
                     *  and clicking OK, which means that it can be used to open .htm, .doc, … etc.*/
                    // myProcess.StartInfo.FileName = @"D:\Projects\OS_Sections\Section1\Section1\bin\Debug\Section1.exe";
                    myProcess.StartInfo.FileName = @"notepad.exe";
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.Start();
                    //myProcess.Dispose();
                    // This code assumes the process you are starting will terminate itself. 
                    // Given that is started without a window so you cannot terminate it 
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
