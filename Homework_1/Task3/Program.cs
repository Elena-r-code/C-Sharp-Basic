using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int secondNumber = int.Parse(Console.ReadLine());
            int forSwap;
            forSwap = firstNumber;
            firstNumber = secondNumber;
            secondNumber = forSwap;

            Console.WriteLine("After swapping:");

            Console.WriteLine($"First number : {firstNumber}");
            Console.WriteLine($"Second number: {secondNumber}");

            Console.ReadLine();
        }
    }
}
