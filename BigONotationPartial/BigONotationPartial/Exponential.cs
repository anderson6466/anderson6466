using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonaccix;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonaccix:
                    int n = 40; //8 40 80
                    for (int i = 1; i <= n; i++)
                    {
                        long   fibonacci = exponential.Fibonacci(i);
                        Console.WriteLine("fibonacci {0} = {1}", i, fibonacci);
                    }
                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        internal int Fibonacci(long n)
        {
           
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2)

                ;
        }
    }
}
