using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int  spaceBetween, startNum = 1;

            int rowsOfPyramid = 5;
            
            int fullTakenSpace = rowsOfPyramid + 4 - 1;

            for (int i = 1; i <= rowsOfPyramid; i++)
            {
                for (spaceBetween = fullTakenSpace; spaceBetween >= 1; spaceBetween--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                    Console.Write("{0} ", startNum++);
                Console.Write("\n");
                fullTakenSpace--;
                
                
            }
            Console.ReadLine();
        }
    }
}
