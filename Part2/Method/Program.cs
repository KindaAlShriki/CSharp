using System; // Importing the System namespace to use built-in functionalities like Console

namespace MathOperationApp // Defining the namespace for the application
{
    // This is a custom class named 'MathProcessor'
    class MathProcessor
    {
        // This is a void method named 'ProcessNumbers' that takes two integers as parameters
        public void ProcessNumbers(int number1, int number2)
        {
            // Perform a math operation on the first number. Let's double it.
            int result = number1 * 2;

            // Display the result of the operation on the first number
            Console.WriteLine("Result of operation on the first number (number1 * 2): " + result);

            // Display the second number
            Console.WriteLine("Second number is: " + number2);
        }
    }

    // This is the main class that runs the application
    class Program
    {
        // The Main method is the entry point of the application
        static void Main(string[] args)
        {
            // Instantiate the 'MathProcessor' class
            MathProcessor processor = new MathProcessor();

            // Call the method using positional arguments
            processor.ProcessNumbers(5, 10); // number1 = 5, number2 = 10

            // Call the method using named arguments
            processor.ProcessNumbers(number1: 7, number2: 3); // number1 = 7, number2 = 3

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
