using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Ana", "Ivan", "Marta", "Filip", "Lara" };
            string[] studentsG2 = { "Elena", "Marija", "Viktor", "Aleksandar", "Mila" };
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            int groupNumber = int.Parse(Console.ReadLine());

            if(groupNumber == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                foreach(string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }

            else if(groupNumber == 2)
            {
                Console.WriteLine("The students in G2 are: ");
                foreach(string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }

            else
            {
                Console.WriteLine("Please enter the number of the available groups");
            }

            Console.ReadLine();
        }
    }
}
