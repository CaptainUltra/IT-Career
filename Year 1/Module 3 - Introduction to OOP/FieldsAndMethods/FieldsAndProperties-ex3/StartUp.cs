using System;
using System.Linq;
using System.Collections.Generic;

namespace FieldsAndProperties_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                double salary = double.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];
                Employee employee = new Employee(name, salary, position,department);
                if(inputArgs.Length == 5)
                {
                    if(inputArgs[4].Contains('@'))//Can be done with: int.TryPrse(inputArgs[4], out int result)
                    {
                        employee.Email = inputArgs[4];//employee.Age = result;
                    }
                    else
                    {
                        employee.Age = int.Parse(inputArgs[4]);//employee.Email = inputArgs[4];
                    }
                }
                else if(inputArgs.Length == 6)
                {
                    employee.Email = inputArgs[4];
                    employee.Age = int.Parse(inputArgs[5]);
                }
                employees.Add(employee);
            }
            var topDepartment = employees.GroupBy(x => x.Department)
            .ToDictionary(x => x.Key, y => y.Select(s => s))
            .OrderByDescending(x => x.Value.Average(s => s.Salary)).FirstOrDefault();
            System.Console.WriteLine($"Highest Average Salary:");
            foreach (var employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                System.Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
