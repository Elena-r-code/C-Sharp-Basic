using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string firstInput = Console.ReadLine();
            int firstNumber;
            bool numberOne = int.TryParse(firstInput, out firstNumber);

            Console.WriteLine("Enter the second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber;
            bool numberTwo = int.TryParse(secondInput, out secondNumber);

            int result;

            if (numberOne && numberTwo && firstNumber >= 0 && secondNumber >= 0)
            {
                if(firstNumber % 2 == 0 && secondNumber % 2 == 0)
                {
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Both numbers are even. The operation and result are {firstNumber} + {secondNumber} = {result}");

                }
                
                
                else if (firstNumber % 2 != 0 && secondNumber % 2 !=0)
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Both of the numbers are odd. The operation and the result are {firstNumber} * {secondNumber} = {result}");

                }
                else 
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"One of the numbers is odd. The operation and the result are {firstNumber} - {secondNumber} = {result}");

                }

            }
            else
            {
                Console.WriteLine("Error!");
            }

            Console.ReadLine();

        }
    }
}
