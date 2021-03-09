using System;
using System.Collections.Generic;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scales = new List<string>();
            scales.Add("Fahrenheit");
            scales.Add("Celsius");
            scales.Add("Kelvin");
            scales.Add("Rankine");
            Console.WriteLine("What would you like to convert? (Fahrenheit/Celsius/Kelvin/Rankine)");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            scales.Remove(choice);
            Console.WriteLine();
            Console.WriteLine($"What would you like to convert {choice} to? {string.Join("/", scales)}");
            Console.Write("Choice: ");
            string choiceTwo = Console.ReadLine();
            Console.WriteLine();

            if(choice == "Fahrenheit")
            {
                Console.WriteLine("How much F would you like to convert");
                Console.Write("Answer: ");
                double answer = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if(choiceTwo == "Celsius")
                {
                    double result = (answer - 32) * 0.5556;
                    Console.WriteLine($"Result: {result:F1} °C");
                }
                else if(choiceTwo == "Kelvin")
                {
                    double result = (answer - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"Result: {result:F2} kelvin");
                }
                else if(choiceTwo == "Rankine")
                {
                    double result = answer + 459.67;
                    Console.WriteLine($"Result: {result:F2} °R");
                }
            }
            else if(choice == "Celsius")
            {
                Console.WriteLine("How much C would you like to convert");
                Console.Write("Answer: ");
                double answer = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choiceTwo == "Fahrenheit")
                {
                    double result = answer * 1.8 + 32;
                    Console.WriteLine($"Result: {result:F1} °F");
                }
                else if (choiceTwo == "Kelvin")
                {
                    double result = answer + 273.15;
                    Console.WriteLine($"Result: {result:F2} kelvin");
                }
                else if (choiceTwo == "Rankine")
                {
                    double result = (answer + 273.15) * 9/5;
                    Console.WriteLine($"Result: {result:F2} °R");
                }
            }
            else if(choice == "Kelvin")
            {
                Console.WriteLine("How much kelvin would you like to convert");
                Console.Write("Answer: ");
                double answer = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choiceTwo == "Fahrenheit")
                {
                    double result = answer * 9/5 - 459.67;
                    Console.WriteLine($"Result: {result:F1} °F");
                }
                else if (choiceTwo == "Celsius")
                {
                    double result = answer - 273.15;
                    Console.WriteLine($"Result: {result:F2} °C");
                }
                else if (choiceTwo == "Rankine")
                {
                    double result = answer * 9/5;
                    Console.WriteLine($"Result: {result:F2} °R");
                }
            }
            else if(choice == "Rankine")
            {
                Console.WriteLine("How much kelvin would you like to convert");
                Console.Write("Answer: ");
                double answer = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choiceTwo == "Fahrenheit")
                {
                    double result = answer - 459.67;
                    Console.WriteLine($"Result: {result:F1} °F");
                }
                else if (choiceTwo == "Celsius")
                {
                    double result = (answer - 491.67) * 5/9;
                    Console.WriteLine($"Result: {result:F2} °C");
                }
                else if (choiceTwo == "Kelvin")
                {
                    double result = answer * 5/9;
                    Console.WriteLine($"Result: {result:F2} kelvin");
                }
            }
        }
    }
}
