using ClassLibrary1.Classes;
using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Abel", Color = "brown", Age = 5, Gender = GenderEnum.Male},
                new Animal(){Name = "Lily", Color = "white", Age = 6, Gender = GenderEnum.Female},
                new Animal(){Name = "Leo", Color = "black", Age = 2, Gender = GenderEnum.Male},
                new Animal(){Name = "Amy", Color = "grey", Age = 3, Gender = GenderEnum.Female},
                new Animal(){Name = "Jack", Color = "white", Age = 7, Gender = GenderEnum.Male},
                new Animal(){Name = "Bella", Color = "black", Age = 1, Gender = GenderEnum.Female},
                new Animal(){Name = "exampleForLongerName", Color = "brown", Age = 3, Gender = GenderEnum.Male},
                new Animal(){Name = "Coco", Color = "grey", Age = 5, Gender = GenderEnum.Female},
                new Animal(){Name = "Max", Color = "white", Age = 1, Gender = GenderEnum.Male},
                new Animal(){Name = "Albatross", Color = "brown", Age = 2, Gender = GenderEnum.Female}

        };
            List<string> OlderThanFive = animals.Where(animal => animal.Age >= 5).Select(animal => $"Animal : {animal.Name},  Age: {animal.Age}").ToList();
            Console.WriteLine("     ANIMALS AGED FIVE OR MORE \n");
            foreach(string animal in OlderThanFive)
            {
                Console.WriteLine(animal);
            }

            List<Animal> startingWithA = animals.Where(animal => animal.Name.StartsWith("A")).ToList();
            Console.WriteLine("\n     ANIMALS WHOSE NAMES STARTS WITH A: \n");
            foreach(Animal animalWithA in startingWithA)
            {
                Console.WriteLine(animalWithA.Name);
            }

            List<Animal> maleAndBrown = animals.Where(animal => animal.Gender == GenderEnum.Male && animal.Color == "brown").ToList();
            Console.WriteLine("\n     MALE ANIMALS THAT ARE BROWN \n");
            foreach(Animal maleBrown in maleAndBrown)
            {
                Console.WriteLine($" Name: {maleBrown.Name},  Color: {maleBrown.Color}, Gender:  {maleBrown.Gender}");

            }

            Animal longerNameThanTen = animals.FirstOrDefault(animal => animal.Name.Length > 10);
            Console.WriteLine("\n      ANIMALS WITH NAME LONGER THEN 10 LETTERS: \n ");
            Console.WriteLine($"Name: {longerNameThanTen.Name}");
            
            Console.ReadLine();
        }
    }
}
