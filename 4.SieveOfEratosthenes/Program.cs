using System;
using System.Collections.Generic;

namespace _4.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> primeDigits = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                primeDigits.Add(i);
            }
            for (int i = 0; i < primeDigits.Count; i++)
            {
                for (int k = primeDigits[i]; k <= primeDigits[primeDigits.Count - 1]; k += primeDigits[i])
                {
                    if (k > primeDigits[i])
                    {
                        primeDigits.Remove(k);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", primeDigits));
        }
    }
}
