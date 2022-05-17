using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LanuchWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine($"args[{i}] = {args[i]}");
            // ... Open specified Word file.
            //\"\"\"\"\"operating system\"\"\"\"\"
            // hello \"\"\"\"\"operating system\"\"\"\"\"
           // OpenMicrosoftWord(@"D:\OS\167.docx");
            OpenMicrosoftWord(@"hello """"""""""operating system""""""""""");
        } 
        static void OpenMicrosoftWord(string file)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            // startInfo.FileName = "WINWORD.EXE";
            startInfo.FileName = @"D:\Work\OS\LAB\OSLAB\TestArguments\bin\Debug\TestArguments.exe";
            startInfo.Arguments = file;
            Process.Start(startInfo);
            //Process.Start("WINWORD.EXE", file);
          //  Process.Start(@"D:\Work\OS\LAB\OSLAB\TestArguments\bin\Debug\TestArguments.exe", file);
        }
    }
}
