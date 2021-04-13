using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            string result = "";
            int i = input.Length - 1;
            while(i >= 0)
            {
                result += input[i];
                i--;
            }

            Console.WriteLine("The result is : " + result);
            Console.ReadLine();
        }
    }
}
