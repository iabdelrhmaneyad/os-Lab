using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ForegroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing thread 
            Thread thr = new Thread(mythread);
            thr.IsBackground = true;
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");
        }
        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("mythread ends!!");
        }
    }
}
