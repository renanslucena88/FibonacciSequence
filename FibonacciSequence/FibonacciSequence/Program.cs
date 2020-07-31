using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("======================");
                int.TryParse(Console.ReadLine(), out int n);

                //Sol 1
                //Console.WriteLine("SOLUTION 1");
                //var date = DateTime.Now;
                //Console.WriteLine(date);
                //var resultSol1 = Fibonacci2(n);
                //Console.WriteLine(string.Format("Fibonacci of {0} is {1}", n, resultSol1));
                //var resultdate1 = (DateTime.Now - date).TotalMilliseconds;
                //Console.WriteLine("Executed in: " + resultdate1 + " Milliseconds");
                //Console.WriteLine();



                //Sol 2 WINNER!!!       
                Console.WriteLine("SOLUTION 2");
                var date2 = DateTime.Now;
                Console.WriteLine(date2);
                var resultSol2 = GetFibonacci(n);
                Console.WriteLine(string.Format("Fibonacci of {0} is {1}", n, resultSol2));
                var resultdate2 = (DateTime.Now - date2).TotalMilliseconds;
                Console.WriteLine("Executed in: " + resultdate2 + " Milliseconds");
                Console.WriteLine();

            }
        }


        #region SOLUTION 1 USING RECURSIVE
        public static double Fibonacci2(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            double[] fibo = new double[n + 1];
            return Fibonacci2(fibo, n);
        }
        public static double Fibonacci2(double[] fibo, int n)
        {
            if (n <= 1)
            {
                return n;
            }

            if (fibo[n] > 0)
            {
                return fibo[n];
            }

            double result = Fibonacci2(fibo, n - 1) + Fibonacci2(fibo, n - 2);

            fibo[n] = result;

            return result;

        }
        #endregion

        #region SOLUTION 2 WITH BETTER PERFORMANCE USING ONLY A SIMPLE LOOP
        public static BigInteger GetFibonacci(int n)
        {
            int a = 1;
            if (n == 1 || n == 2)
            {
                return 1;
            }

            BigInteger result = 0;
            BigInteger previous1 = 0;
            BigInteger previous2 = 1;

            while (a <= n)
            {
                if (a == 1 || a == 2)
                {
                    previous1 = 1;
                    previous2 = 1;
                }
                else
                {
                    var temp = previous1;
                    result = previous1 + previous2;
                    previous2 = temp;
                    previous1 = result;
                }
                a++;
            }
            return result;
        }
        #endregion
    }
}
