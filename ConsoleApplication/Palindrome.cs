using System;
using System.Linq;

public class Palindrome : ITask
{
    public int TaskId { set; get; } = 12;
    public string Title { get; set; } = "Palindrome";
    public string Description { get; set; } = "Checks to see if input is valid palindrome.";

    TaskHandler handler;

    public Palindrome(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public bool PalindromeValidator()
    {
        string input = Validator.ValidateString(input = "", "Write something!");
        var reversed = new string(input.Reverse().ToArray());
        return input == reversed;
    }

    public void Run()
    {
        Console.WriteLine(PalindromeValidator());
    }
}




