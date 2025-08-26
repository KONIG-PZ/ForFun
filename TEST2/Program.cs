using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        //TODO DO BMI calculation

        // Main Method
        public static void Main(string[] args)
        {
            (string FirstName, int AgeAsInt) = Name();
            double WeightAsInt = Weight();
            double HeightAsInt = Height();
            PrintName(FirstName, AgeAsInt, WeightAsInt, HeightAsInt);
            double bmi = BMI(WeightAsInt, HeightAsInt);
            BMIVerdict(bmi);
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
        static double Weight()
        {
            Console.WriteLine("Enter your weight in kg:");
            string Weight = Console.ReadLine();
            int WeightAsInt = int.Parse(Weight);
            return WeightAsInt;
        }

        // Height Method
        static double Height()
        {
            Console.WriteLine("Enter your height in cm:");
            string Height = Console.ReadLine();
            double HeightAsInt = double.Parse(Height);
            return HeightAsInt;
        }

        // Print Method
        static void PrintName(string FirstName, int AgeAsInt, double WeightAsInt, double HeightAsInt)
        {
            Console.WriteLine($"Hello {FirstName}, you are {AgeAsInt} years old!");
            Console.WriteLine($"You are {HeightAsInt} cm tall and weigh {WeightAsInt} kg.");
            Console.WriteLine($"Your height in feet is {Converter(HeightAsInt):0.00} ft.");
        }

        // Convert cm to ft
        static double Converter(double HeightAsInt)
        {
            double HeightInFeet = HeightAsInt / 30.48;
            return HeightInFeet;
        }

        // BMI Calculation Method
        static double BMI(double WeightAsInt, double HeightAsInt)
        {
            double heightInMeters = HeightAsInt / 100;
            double BmiComputation = WeightAsInt / (heightInMeters * heightInMeters);

            Console.WriteLine($"Your BMI is {BmiComputation:0.00}");
            return BmiComputation;
        }

        //BMI Print Method
        static void BMIVerdict(double bmi)
        {
            Console.WriteLine($"Your BMI is {bmi:F2}");

            if (bmi < 18.5)
                Console.WriteLine("Your BMI is Underweight");
            else if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("Your BMI is Normal");
            else if (bmi >= 25 && bmi <= 29.9)
                Console.WriteLine("Your BMI is Overweight");
            else
                Console.WriteLine("Your BMI is Obese");
            
        }

    }
}
