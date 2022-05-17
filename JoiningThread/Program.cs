using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JoiningThread
{
    public class ExThread
    {

        // Non-Static method 
        public void mythread()
        {
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(x);
                Thread.Sleep(2000);
            }
        }
        // Non-Static method 
        public void mythread1()
        {
            Console.WriteLine("2nd thread is Working..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instance for 
            // mythread() method 
            ExThread obj = new ExThread();

            // Creating and initializing threads  
            Thread thr1 = new Thread(new ThreadStart(obj.mythread));
            Thread thr2 = new Thread(new ThreadStart(obj.mythread1));
            thr1.Start();
            // Join thread 
            thr1.Join();
            thr2.Start();
        }
    }
}
