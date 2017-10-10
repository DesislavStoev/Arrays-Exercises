using System;
using System.Linq;

namespace _6.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 1;
            int maxCnt = 0;
            int digit = 0;
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] == number[i-1])
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                    digit = number[i];
                }
            }
            for (int i = 0; i < maxCnt; i++)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            
        }
    }
}
