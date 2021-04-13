using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentance: ");
            string sentance = Console.ReadLine();

            string[] wordsInSentance = sentance.Split(" ");

            Console.WriteLine("The words in your sentance are :");

            foreach(string word in wordsInSentance)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
