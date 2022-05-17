using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadJoiningAgain
{
    class Program
    {
        //In thread synchronization, join is a blocking mechanism that pauses the calling thread.
        static void Main(string[] args)
        {
           // Thread t1 = new Thread(Func1);
           // t1.Start();
           // Thread t2 = new Thread(Func2);
           // t2.Start();
           //t1.Join();
           //t2.Join();
           //Console.WriteLine("Main Here!");
            int ss = 0;
            Thread th = new Thread(() => { ss = sum(0, 10); });
            th.Start(); 
            th.Join();
            Console.WriteLine($"sum={ss}");
        }
        private static int sum(int start, int end)
        {
            int s = 0;
            for(int i=start; i<=end;i++)
            {
                s += i;
            }
            return s;
        }
        private static void Func2(object obj)
        {
            Console.WriteLine("Thread2 is executed");
        }
        private static void Func1(object obj)
        {
            Console.WriteLine("Thread1 is executed");
        }

    }
}
