using System;
using System.Linq;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;
            int maxCnt = 0;
            int digit = 0;
           
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        cnt++;
                        if (cnt > maxCnt)
                        {
                            maxCnt = cnt;
                            digit = nums[i];
                        }
                    }
                   
                }
                  cnt = 0;
            }
            Console.WriteLine(digit);
        }
    }
}
