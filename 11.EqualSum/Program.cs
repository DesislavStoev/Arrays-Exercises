using System;
using System.Linq;

namespace _11.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEqual = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int[] left = nums.Take(i).ToArray();
                int[] right = nums.Skip(i + 1).ToArray();
                if (left.Sum() == right.Sum())
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
