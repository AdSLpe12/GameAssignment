using System;

class GuessTheNumberGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the 'Guess the Number' game!");
        
        Random random = new Random();
        int secretNumber = random.Next(1, 101); 
        
        int guess = 0;
        int attempts = 0;
        bool isGameRunning = true;
        
        while(isGameRunning)
        {
            Console.WriteLine("Please enter a number between 1 and 100:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out guess) && guess >= 1 && guess <= 100) 
            {
                attempts++;
                if(guess != secretNumber)
                {
                    ProvideFeedback(guess, secretNumber); 
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number in {attempts} attempts.");
                    isGameRunning = false; 
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
        ShowPartingWords();
    }
    static void ProvideFeedback(int guess, int secretNumber)
    {
        if (guess < secretNumber)
        {
            Console.WriteLine("Your guess is lower than the secret number. Try again.");
        }
        else 
        {
            Console.WriteLine("Your guess is higher than the secret number. Try again.");
        }
    }
    static void ShowPartingWords()
    {
        Console.WriteLine("Thank you for playing! We hope you enjoyed it.");
    }
}
