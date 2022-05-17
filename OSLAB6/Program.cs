using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace OSLAB6
{
    public class ExThread
    {

        // Static method for thread a 
        public static void thread1()
        {
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(z);
            }
        }
        // static method for thread b 
        public static void thread2()
        {
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(z);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing threads 
            Thread a = new Thread(ExThread.thread1);
            Thread b = new Thread(ExThread.thread2);
            a.Start();
            b.Start();
        }
    }
}
 