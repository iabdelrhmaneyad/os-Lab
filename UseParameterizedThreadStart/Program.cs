using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UseParameterizedThreadStart
{
    class Number
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            //ParameterizedThreadStart parameterizedThreadStart =
            //    new ParameterizedThreadStart(Number.PrintNumbers);
            //Thread T1 = new Thread(parameterizedThreadStart);
            //// Pass the traget number to the start function, which
            //// will then be passed automatically to PrintNumbers() function
            //T1.Start(target);

            // The code can also be written as shown below.
            /***/
            Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start(target);
            /***/
        }
    }
}
