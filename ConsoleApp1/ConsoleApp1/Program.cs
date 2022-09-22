using System;
using System.Collections.Generic;

namespace Lab_IPZ_1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter your N ");
            int n = int.Parse(Console.ReadLine());
            string s = " ";
            foreach (long fib in Fibonacci(n))
                Console.WriteLine(s += fib + " ");
            Console.ReadKey();
        }

        private static IEnumerable<long> Fibonacci(int n)
        {
            if (n <= 0)
                yield break;
            long fib_n_2 = 0, fib_n_1 = 1;
            for (int i = 1; i < n; i++)
            {
                var temp = fib_n_1;
                yield return fib_n_1 += fib_n_2;
                fib_n_2 = temp;
            }
        }
    }
}
