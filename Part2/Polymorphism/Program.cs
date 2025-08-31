using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and assign properties
            Employee employee = new Employee
            {
                Id = 2025,
                FirstName = "Kinda",
                LastName = "AlShriki"
            };

            // Use polymorphism: declare a variable of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit() method via the IQuittable interface reference
            quittableEmployee.Quit();

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
