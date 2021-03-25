using System;

public class NumberGuesser : ITask
{
    public int TaskId { get; set; } = 6;
    public string Title { get; set; } = "Number Guesser";
    public string Description { get; set; } = "Find the correct number";
    TaskHandler handler;

    public NumberGuesser(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }


    public void RunGame()
    {
        var random = new Random();
        bool FoundIt = false;
        int CorrectNumber = random.Next(1, 100);
        int Min = 0;
        int Max = 100;
        int Guess = 0;
        int Guesses = 0;

        while (!FoundIt)
        {
            Guess = Validator.ValidateInt($"Guess a number between {Min} and {Max}");
            Guesses++;

            if (Guesses == 2)
            {
                Console.WriteLine($"Hint! The Number you are looking for is {CorrectNumber - 2 } And {CorrectNumber + 2}");
            }

            if (Guess == CorrectNumber)
            {
                ConsoleEventing.Success($"You guessed it correctly, champ! Attempts: {Guesses}");
                FoundIt = true;
                return;
            }

            else if (Guess >= CorrectNumber)
            {
                Max = Math.Min(Max, Guess - 1);
                ConsoleEventing.Error("Your guess was too high");
                FoundIt = false; ;
            }
            else
            {
                Min = Math.Max(Min, Guess + 1);
                ConsoleEventing.Error("Your guess was too low");
                FoundIt = false;
            }
        }
    }

    public void Run()
    {
        RunGame();
    }
}




