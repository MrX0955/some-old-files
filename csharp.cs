using System;

namespace Code_Test
{
    public class AgeStruct {
        private const int Adult_Age = 18;

        public void DisplayMessage() {
            Console.WriteLine("Welcome to the Age Calculator!");
        }

        public string AgeCalculate(int age) {
            if (age < 0) {
                return "Age cannot be negative.";
            }
            
            if (age < Adult_Age) {
                return "You are a minor.";
            } else {
                return "You are an adult.";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AgeStruct ageStruct = new AgeStruct();
            ageStruct.DisplayMessage();

            Console.WriteLine("Enter your age:");
            int age;
            if (int.TryParse(Console.ReadLine(), out age)) {
                string result = ageStruct.AgeCalculate(age);
                Console.WriteLine(result);
            } else {
                Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            }
        }
    }
}