using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void PrintNumbers(IEnumerable collection)
        {
            Console.WriteLine("The numbers you entered are:");
            foreach (int number in collection)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will your queue have?");
            bool success = int.TryParse(Console.ReadLine(), out int num);

            Queue<int> myQueue = new Queue<int>();

            if (success)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Enter the {i + 1} number");
                    bool success1 = int.TryParse(Console.ReadLine(), out int n);
                    myQueue.Enqueue(n);
                }

                PrintNumbers(myQueue);
            }
            Console.ReadLine();
        }
    }
}
