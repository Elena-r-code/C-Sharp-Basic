using ClassLibrary1.Classes;
using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Oliver", LastName = "Baker", Age = 30},
                new Employee(){FirstName = "Amelia", LastName = "Dyer", Age = 30},
                new Employee(){FirstName = "Harry", LastName = "Slater", Age = 22 },
                new Employee(){FirstName = "Isla", LastName = "Potter", Age = 28},
                new Employee(){FirstName = "James", LastName = "Smith", Age = 26},
                new Employee(){FirstName = "Emma", LastName = "Wright", Age = 22},
                new Employee(){FirstName = "Robeert", LastName = "Jones", Age = 30},
                new Employee(){FirstName = "Sophia", LastName = "Brown", Age = 33},
                new Employee(){FirstName = "Jacob", LastName = "Davies", Age = 28},
                new Employee(){FirstName = "Isabella", LastName = "Wilson", Age = 28},
            };

            Dictionary<int, List<string>> employeeDictionary = new Dictionary<int, List<string>>();

            foreach(var employee in employees)
            {
                if (employeeDictionary.ContainsKey(employee.Age))
                {
                    List<string> names = employeeDictionary[employee.Age];
                    names.Add($"{employee.FirstName} {employee.LastName}");
                }
                else
                {
                    employeeDictionary.Add(employee.Age, new List<string> { $"{employee.FirstName} {employee.LastName}" });
                }
            }

            foreach(var employee in employeeDictionary)
            {
                Console.WriteLine($"\n          Employees with age  {employee.Key} : \n");
                
                foreach(var name in employee.Value)
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadLine();
        }
    }
}
