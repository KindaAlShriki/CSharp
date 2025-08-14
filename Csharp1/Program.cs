using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine()); // Convert user input to a double

        // Check if the weight is greater than 50
        if (weight > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exits the program early
        }

        // Prompt the user to enter the package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum of dimensions to check if it exceeds the limit
        double dimensionTotal = width + height + length;

        // Check if total dimensions exceed 50
        if (dimensionTotal > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exits the program early
        }

        // Calculate the shipping quote:
        // Multiply height, width, and length together, then multiply by weight and divide by 100
        double quote = (width * height * length * weight) / 100;

        // Display the calculated shipping quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
