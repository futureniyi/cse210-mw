using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        float number = float.Parse(input);  // Convert string input to float

        string letter = "";
        string sign = "";
        bool passedCourse = false;

        // Determine letter grade
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 1: determine + or - sign
        int remDigit = (int)number % 10;
        if (remDigit >= 7)
        {
            sign = "+";
        }
        else if (remDigit < 3)
        {
            sign = "-";
        }

        // Stretch Challenge 2: No + for grades 93 and above
        if (number >= 93)
        {
            sign = "";
        }

        // Stretch Challenge 3: No + or - if letter grade is F
        if (letter == "F")
        {
            sign = "";
        }

        // Print letter grade with sign
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Determine and print pass/fail message
        if (number >= 70)
        {
            passedCourse = true;
        }

        if (passedCourse)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Keep trying and you’ll improve!");
        }
    }




}