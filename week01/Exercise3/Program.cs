using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicInput = Console.ReadLine();
        // int magicNumber = int.Parse(magicInput);  

        // Console.Write("What is your guess? ");
        // string guessInput = Console.ReadLine();
        // int guess = int.Parse(guessInput); 

        Random random = new Random(); 
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            int magicNumber = random.Next(1, 101); // Random number between 1 and 100
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}
