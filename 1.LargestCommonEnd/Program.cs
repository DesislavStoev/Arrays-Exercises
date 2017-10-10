using System;

namespace _1.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int cnt1 = 0;
            int cnt2 = 0;
            
            for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    cnt1++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[firstArray.Length - 1- i] == secondArray[secondArray.Length - 1 - i])
                {
                    cnt2++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(cnt1,cnt2));
        }
    }
}
