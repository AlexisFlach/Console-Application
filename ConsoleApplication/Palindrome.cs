using System;
using System.Linq;

public class Palindrome : Task
{
    TaskHandler handler;

    public Palindrome(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 12;
        Title = "Palindrome";
        Description = "Checks to see if input is valid palindrome.";
    }

    public bool PalindromeValidator()
    {
        string input = Validator.ValidateString(input = "", "Write something!");
        var reversed = new string(input.Reverse().ToArray());
        return input == reversed;
    }

    public override void Run()
    {
        Console.WriteLine(PalindromeValidator());
    }
}




