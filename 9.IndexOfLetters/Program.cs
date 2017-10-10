using System;

namespace _9.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{str[i]} -> {str[i] - 97}");
            }
        }
    }
}
