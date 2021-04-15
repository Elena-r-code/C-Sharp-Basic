using System;
using Task1.Classes;


namespace Task1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            while (true)
            {
                Car[] cars =
                 {
                    new Car("Hyundai", 120),
                    new Car("Mazda", 150),
                    new Car("Ferrari", 250),
                    new Car("Porsche", 300)
                };

                Driver[] drivers = {
                    new Driver("Bob", 7),
                    new Driver("Greg", 5),
                    new Driver("Jill", 10),
                    new Driver("Anne",8)
                };


                Console.WriteLine("Enter car model no.1\n 1.Hyundai\n 2.Mazda\n 3.Ferrari\n 4.Porsche");
                string firstCar = Console.ReadLine();
                Console.WriteLine("Enter driver no.1\n 1.Bob\n 2.Greg\n 3.Jill\n 4.Anne");
                string firstDriver = Console.ReadLine();

                Car[] firstCarObject = new Car[1];
                Car[] secondCarObject = new Car[1];

                for (int i = 0; i < cars.Length; i++)
                {
                    if (firstCar.ToLower() == cars[i].Model.ToLower())
                    {
                        firstCarObject[0] = cars[i];
                    }
                }
                int j = 0;

                while (j < drivers.Length)
                {
                    if (firstDriver.ToLower() == drivers[j].Name.ToLower())
                    {
                        firstCarObject[0].Driver = drivers[j];
                        break;
                    }
                    j++;
                }

                Console.WriteLine("Enter car model no.2\n 1.Hyundai\n 2.Mazda\n 3.Ferrari\n 4.Porsche");
                string secondCar = Console.ReadLine();
                Console.WriteLine("Enter driver no.2\n 1.Bob\n 2.Greg\n 3.Jill\n 4.Anne");
                string secondDriver = Console.ReadLine();

                for (int i = 0; i < cars.Length; i++)
                {
                    if (firstCarObject[0].Model.ToLower() == secondCar.ToLower())
                    {
                        throw new Exception("You chose the same car model. Please choose another!");
                    }
                    if (secondCar.ToLower() == cars[i].Model.ToLower())
                    {
                        secondCarObject[0] = cars[i];
                    }
                }

                j = 0;

                while (j < drivers.Length)
                {
                    if (firstCarObject[0].Driver.Name.ToLower() == secondDriver.ToLower())
                    {
                        throw new Exception("You chose the same driver. Please choose another one!");
                    }
                    if (secondDriver.ToLower() == drivers[j].Name.ToLower())
                    {
                        secondCarObject[0].Driver = drivers[j];
                        break;
                    }
                    j++;
                }

                RaceCars(firstCarObject[0], secondCarObject[0]);

                Console.WriteLine("Are you in for another race? (yes/no)");
                string raceAgain = Console.ReadLine();
                if (raceAgain.ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else if (raceAgain.ToLower() == "yes")
                {
                    Console.Clear();

                }
                else
                {
                    Console.Clear();
                    break;
                }

                static void RaceCars(Car carOne, Car carTwo)
                {
                    if (carOne.CalculateSpeed(carOne.Driver) > carTwo.CalculateSpeed(carTwo.Driver))
                    {
                        Console.WriteLine($"The winner is {carOne.Driver.Name} driving {carOne.Model} with speed of {carOne.Speed}.");

                    }
                    else if (carTwo.CalculateSpeed(carTwo.Driver) > carOne.CalculateSpeed(carOne.Driver))
                    {
                        Console.WriteLine($"The winner is {carTwo.Driver.Name} driving {carTwo.Model} with speed of {carTwo.Speed}.");

                    }
                    else
                    {
                        Console.WriteLine("Results are identical. It's a TIE!!");
                    }
                }

            }
                Console.ReadLine();           
        }
    }
}
