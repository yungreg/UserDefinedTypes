using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // *Create an instance of a company. Name it whatever you like.
            Company DarktideInc = new Company("Tertium", "1/1/2000");

            // *Create 4 employees
            Employee Reggie = new Employee()
            {
                FirstName = "Reggie",
                LastName = "Williams",
                Title = "Zealot",
                StartDate = "1/18/2000"
            };
            Employee Jesier = new Employee()
            {
                FirstName = "Jesier",
                LastName = "Santiago",
                Title = "Veteran",
                StartDate = "1/18/2000"

            };
            Employee Josh = new Employee()
            {
                FirstName = "Josh",
                LastName = "Johns",
                Title = "Psyker",
                StartDate = "1/18/2000"

            };
            Employee Daniel = new Employee()
            {
                FirstName = "Daniel",
                LastName = "Ohrin",
                Title = "Zealot",
                StartDate = "1/18/2000"
            };

            // *Assign the employees to the company
            DarktideInc.Employees.Add(Jesier);
            DarktideInc.Employees.Add(Daniel);
            DarktideInc.Employees.Add(Josh);
            DarktideInc.Employees.Add(Reggie);



            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            DarktideInc.ListEmployees();

        }

    }
}