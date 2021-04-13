using System;

namespace Task5
{
    class Program
    {

        static int AgeCalculator(int date)
        {
            int age;
            DateTime currentDateTime = DateTime.Now;
            int year = currentDateTime.Year;
            age = year - date;
            return age;

            
             

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year");
            string input =  Console.ReadLine();
            int date;
            bool success = int.TryParse(input, out date);

            if (success)
            {
                Console.WriteLine(AgeCalculator(date));
            }

            Console.ReadLine();
        }
    }
}
