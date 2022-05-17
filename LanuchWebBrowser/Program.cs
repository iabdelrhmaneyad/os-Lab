using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LanuchWebBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method.
            Search1("Operating System");
        }
        static void Search1(string term)
        {
            // Search this term.
            Process.Start("https://www.google.com/search?q=" + term);
        }
    }
}
