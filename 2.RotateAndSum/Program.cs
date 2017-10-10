using System;
using System.Linq;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] rotate = new int[number.Length];
            int[] sum = new int[number.Length];
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < number.Length; j++)     
                {
                    rotate[j] = number[j - 1];
                }
                rotate[0] = number[number.Length - 1];
                for (int k = 0; k < number.Length; k++)    
                {
                    sum[k] += rotate[k];
                }
                rotate.CopyTo(number, 0);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
