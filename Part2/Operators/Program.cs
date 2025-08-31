using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Instantiate the second Employee object and assign values
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare the two employee objects using the overloaded '==' operator
            bool areEqual = emp1 == emp2;

            // Output the result of the comparison
            Console.WriteLine("Are emp1 and emp2 equal? " + areEqual);

            // Another comparison with same Ids
            emp2.Id = 101; // Set the same ID as emp1

            // Now compare again
            areEqual = emp1 == emp2;
            Console.WriteLine("After changing emp2's ID to match emp1:");
            Console.WriteLine("Are emp1 and emp2 equal? " + areEqual);

            // Keep the console window open
            Console.ReadKey();
        }
    }
}
