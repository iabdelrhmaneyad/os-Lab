using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OSLAB7
{
    public class ExThread
    {

        // Non-static method 
        public void mythread1()
        {
            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine("First Thread");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of ExThread class 
            ExThread obj = new ExThread();
            // Creating thread 
            // Using thread class
            ThreadStart st = new ThreadStart(obj.mythread1);
            Thread thr = new Thread(st);
            thr.Start();
        }
    }
}
