using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            // practice creating variables
            int numberOfCupsOfCoffee = 0;
            string fullName = "Lauren McCall";
            var today = DateTime.Now;
            Console.WriteLine($"{fullName} has drank {numberOfCupsOfCoffee} cups of coffee as of {today}. ");

            // practice getting input from the user
            Console.Write("\n");
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}! Welcome to this! ");

            // practice getting different types of input from the user
            Console.Write("\n");
            Console.Write("Please input a number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Please input another number? ");
            var secondNumberAsString = Console.ReadLine();

            // converting string input into numbers
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            // doing math
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine("\n");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("\n");

        }
    }
}
