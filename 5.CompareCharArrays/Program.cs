using System;
using System.Linq;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool firstIsBigger = false;
           
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    if (firstArray.Length < secondArray.Length)
                    {
                        firstIsBigger = true;
                    }
                    continue;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    firstIsBigger = true;
                    break;
                }
                else if(firstArray[i] > secondArray[i])
                {
                    firstIsBigger = false;
                    break;
                }
            }
           
            if (firstIsBigger)
            {
                foreach (var ch in firstArray)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
                foreach (var ch in secondArray)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var ch in secondArray)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
                foreach (var ch in firstArray)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
    }
}
