using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i; k < nums.Length; k++)
                {
                    if (Math.Abs(nums[i] - nums[k]) == diff)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
