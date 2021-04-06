using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[] { 12, 6, -2, 8, 32, 90, 14, -45, 1, 9 };
            int min = arrayOfNumbers[0];
            int max = arrayOfNumbers[0];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if(arrayOfNumbers[i] < min)
                {
                    min = arrayOfNumbers[i]; 
                }
                if(arrayOfNumbers[i] > max)
                {
                    max = arrayOfNumbers[i];
                }

            }

            Console.WriteLine("The largest number is : " + max);
            Console.WriteLine("The smallest number is : " + min);

            Console.ReadLine();
        }
    }
}
