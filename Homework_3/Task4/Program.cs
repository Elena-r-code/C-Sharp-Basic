using System;

namespace Task4
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substarct(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Calculator(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + " + " + num2 + " = " + Sum(num1,num2));
                    break;
                case "-":
                    Console.WriteLine(num1 + " - " + num2 + " = " + Substarct(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(num1 + " * " + num2 + " = " + Multiplication(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(num1 + " / " + num2 + " = " + Division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            bool success1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second number: ");
            bool success2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            if(success1 && success2)
            {
                Calculator(operation, num1, num2);
            }
            else
            {
                Console.WriteLine("ERROR! Make sure you entered numbers and valid operation.");
            }

            Console.ReadLine();
        }
    }
}
