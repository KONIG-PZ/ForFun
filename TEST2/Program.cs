using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        //TODO Height and Weight

        // Main Method
        public static void Main(string[] args)
        {
            (string FirstName, int AgeAsInt) = Name();
            PrintName(FirstName, AgeAsInt);
        }

        // Info Method
        static (string,int) Name()
        {
            Console.WriteLine("Enter your name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string Age = Console.ReadLine();
            int AgeAsInt = int.Parse(Age);

            return (FirstName, AgeAsInt);
        }

        // Weight Method
        static void Weight()
        {
            Console.WriteLine("Enter your weight in kg:");
            string Weight = Console.ReadLine();
            int WeightAsInt = int.Parse(Weight);    
        }

        // Height Method
        static void Height()
        {
            Console.WriteLine("Enter your height in cm:");
            string Height = Console.ReadLine();
            int HeightAsInt = int.Parse(Height);
        }

        // Print Method
        static void PrintName(string FirstName, int AgeAsInt)
        {
            Console.WriteLine($"Hello {FirstName}, you are {AgeAsInt} years old!");
        }
    }
}
