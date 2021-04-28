using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {

        static void findSquere(List<int> numbers)
        {
            List<int> squeresOfNum = numbers.Select(n => n * n).ToList();
            foreach(int number in squeresOfNum)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {

            List<int> listOfNumbers = new List<int>()
            {
                {5},
                {8},
                {2},
                {10},
                {60},
                {9},
                {20},
                {11},
                {3},
                {45},
            };

            Console.WriteLine($"The numbers: ");

            foreach(int element in listOfNumbers)
            {
                Console.WriteLine($"{element}");
            }


            Console.WriteLine("The squeres of the numbers: ");

            findSquere(listOfNumbers);

            Console.ReadLine();
        }

    }
}
