using System;
using System.Linq;

namespace _7.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 1;
            int maxCnt = 1;
            int indexStart = 0;
            int indexCnt = 0;
            int helper = 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= number[helper])
                {
                    cnt++;
                    helper++; 
                    if (cnt > maxCnt)
                    {
                        maxCnt = cnt;
                        indexStart = indexCnt;
                    }
                }
                else
                {
                    cnt = 1;
                    indexCnt = i;
                    helper = i;
                }
                
            }
            
            for (int i = indexStart; i < maxCnt + indexStart; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
