using System;
using System.Collections.Generic;

namespace classes_exercise
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }
        List<Employee> Employees { get; set; } = new List<Employee>();

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee newEmployee) 
        {
            Employees.Add(newEmployee);
        }

        public void ListEmployees() {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name} has worked at {Name} as a {employee.JobTitle} since {employee.StartDate}.");
            }
        }
        
    }
}