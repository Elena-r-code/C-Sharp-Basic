using ClassLibrary1.Classes;
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager[] managers = new Manager[]
            {
                new Manager("Ana", "Jovanova"),
                new Manager("Jovan", "Dimov")
            };

            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Angela", "Stojanova", 9, 30, managers[0]),
                new Contractor("Filip", "Ivanov", 7, 40, managers[1]),
            };

            SalesPerson[] salesPerson = new SalesPerson[]
            {
                new SalesPerson("Petar", "Serafimov")
            };

            Employee[] company = new Employee[]
            {
                managers[0],
                managers[1],
                contractors[0],
                contractors[1],
                salesPerson[0]
            };

            CEO firstCEO = new CEO("Elena", "Betinska", 10, company);

            Console.WriteLine("CEO:");
            Console.WriteLine(firstCEO.PrintInfo());
            Console.WriteLine($"Salary of CEO is: {firstCEO.GetSalary()}");
            Console.WriteLine("Employees: ");
            firstCEO.PrintEmployees(company);


            Console.ReadLine();
        }
    }
}
