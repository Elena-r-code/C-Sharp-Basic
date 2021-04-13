using System;

namespace Task3
{
    class Program
    {
        static void Sum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;

            }
            
            Console.WriteLine("The sum of the digits of the number you entered is : " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);

            if (success)
            {
                Sum(number);
            }
            else
            {
                Console.WriteLine("Please enter a number that can be parsed.");
            }

            Console.ReadLine();
            
        }
    }
}
