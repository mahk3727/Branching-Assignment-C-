using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.Write("Please enter the package weight: ");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt user for package width, height, and length
            Console.Write("Please enter the package width: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            float length = float.Parse(Console.ReadLine());

            // Calculate total dimensions
            float totalDimensions = width + height + length;

            // Check if total dimensions are greater than 50
            if (totalDimensions > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate quote
            float quote = (width * height * length * weight) / 100;

            // Display quote to user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote.ToString("0.00")}");
            Console.WriteLine("Thank you!");
        }
    }
}
