using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            string operation = Console.ReadLine();
            double result;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine("The result is " + result);
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine("The result is " + result);
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("The result is " + result);
            }
            if (operation == "/")
            {
                result = firstNumber / secondNumber;
                Console.WriteLine("The result is " + result);
            }

            Console.ReadLine();



        }
    }
}
