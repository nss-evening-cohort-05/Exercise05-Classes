using System;

namespace classes_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Company nss = new Company("Nashville Software School",DateTime.Parse("6/1/2012"));
            
            var martin = new Employee { 
                Name = "Martin", 
                JobTitle = "TA", 
                StartDate=DateTime.Parse("7/10/2017") 
            };
            var steve = new Employee { 
                Name = "Steve", 
                JobTitle = "Lead Instructor", 
                StartDate=DateTime.Parse("1/1/2015") 
            };
            var john = new Employee { 
                Name = "John", 
                JobTitle = "Bossman", 
                StartDate=DateTime.Parse("1/1/1900")
            };

            nss.AddEmployee(martin);
            nss.AddEmployee(steve);
            nss.AddEmployee(john);

            Console.WriteLine($"{nss.Name} was created on {nss.CreatedOn}");
            nss.ListEmployees();
        }
    }
}
