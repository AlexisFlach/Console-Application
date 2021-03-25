using System;

public class ConsoleEventing
{
    public static void Msg(string msg)
    {
        Console.WriteLine(msg);
    }

    public static void Error(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Msg(msg);
        Console.ForegroundColor = ConsoleColor.Black;
    }

    public static void Success(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Msg(msg);
        Console.ForegroundColor = ConsoleColor.Black;
    }
}




