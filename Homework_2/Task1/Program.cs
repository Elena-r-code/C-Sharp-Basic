using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int[] array= new int[6];
            for (int i = 0; i <=5; i++)
            {
                Console.WriteLine($"Enter integer no. {i+1}");
                int number = int.Parse(Console.ReadLine());         
                array[i] = number;
                if(array[i] % 2 == 0)
                {
                    sum += array[i];
                }

            }

            Console.WriteLine($"The result is {sum}");

            Console.ReadLine();



            
        }
    }
}
