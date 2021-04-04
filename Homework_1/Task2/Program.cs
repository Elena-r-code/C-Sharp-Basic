using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number :");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the forth number :");
            double forthNumber = double.Parse(Console.ReadLine());

            double average = (firstNumber + secondNumber + thirdNumber + forthNumber) / 4;

            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {forthNumber} is {average}");


            Console.ReadLine();
        }
    }
}
