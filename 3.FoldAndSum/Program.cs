using System;
using System.Linq;

namespace _3.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] firstRow = new int[num.Length / 2];
            int[] secondRow = new int[num.Length / 2];
            int[] sum = new int[num.Length / 2];
            int k = num.Length / 4;
            
            for (int i = 0; i < k; i++)
            {
                firstRow[i] = num[k - 1 - i];
            }
            for (int i = 0; i < k; i++)
            {
                firstRow[firstRow.Length - 1 - i] = num[num.Length - k + i];
            }
            for (int i = 0; i < k * 2; i++)
            {
                secondRow[i] = num[i + k];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
