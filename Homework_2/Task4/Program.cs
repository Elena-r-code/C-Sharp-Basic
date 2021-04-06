using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements : ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfElements];

            int counterOfThrees = 0;

            for(int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Enter the {i + 1} element: ");
                array[i] = int.Parse(Console.ReadLine());

                
            }
            for (int j = 1; j < array.Length - 1; j++)
            {
                if (array[j] == 3 && array[j+1] == 3)
                {
                    counterOfThrees++;

                }
            }

            Console.WriteLine($"{counterOfThrees} times there are threes next to each other");

            Console.ReadLine();
        }
    }
}
