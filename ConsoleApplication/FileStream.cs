using System;
using System.IO;

public class FileStream : Task
{
    TaskHandler handler;

    public FileStream(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 7;
        Title = "File Stream";
        Description = "Lets your save text to a file and provides the option for you to read it.";
    }

    public async void WriteFile()
    {
        string input = Validator.GetString("Enter text");
        await File.WriteAllTextAsync("WriteText.txt", input);
    }


    public void ReadFile()
    {
        string text = File.ReadAllText("WriteText.txt");
        Console.WriteLine(text);
    }

    public bool YesOrNo(params string[] options)
    {
        Console.WriteLine(options[0]);
        string answer = Console.ReadLine().ToUpper();

        if (answer == options[1])
        {
            return true;
        }
        else if (answer == options[2])
        {
            return false;
        }
        else
        {
            return false;
        }
    }

    public override void Run()
    {
        WriteFile();

        if (YesOrNo("Want to read it? [Y or N]?", "Y", "B"))
        {
            ReadFile();
        }
        else
        {
            Console.WriteLine("Okay, we are done here");
        }
    }
}




