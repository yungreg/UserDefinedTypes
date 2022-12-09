using System;
using System.Collections.Generic;

namespace Classes
{
    class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public string CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string name, string CreateDate)
        {
            this.Name = name;
            this.CreatedOn = CreateDate;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (Employee heretic in Employees)
            {
                Console.WriteLine($"{heretic.FirstName} {heretic.LastName} works for {Name} as a {heretic.Title} since {heretic.StartDate}.");

            }

        }



    }
}