using System;
using System.Text.RegularExpressions;

public class Validator
{
    public static string GetString(string msg)
    {
        Console.WriteLine(msg);
        string input = Console.ReadLine();
        return input;
    }

    public static bool CheckString(string input)
    {
        bool isValid = false;

        if (string.IsNullOrEmpty(input))
            isValid = false;
        else
        {
            isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");

            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    isValid = false;
            }
        }
        return isValid;
    }

    public static string ValidateString(string msg)
    {
        bool err = true;

        while (err)
        {   
            string str = Validator.GetString(msg);
            if (!Validator.CheckString(str))
            {
                ConsoleEventing.Error("Not valid.");
                err = true;
            }
            else
            {
                ConsoleEventing.Success("Valid string");
                err = false;
                return str;
            }
        }
        return "";
    }

    public static string ValidateString(string name, string msg)
    {
        bool err = false;

        while (err || String.IsNullOrEmpty(name))
        {
            string str = Validator.GetString(msg);
            if (!Validator.CheckString(str))
            {
                ConsoleEventing.Error("Not valid.");
                err = true;
            }
            else
            {
                ConsoleEventing.Success("Valid string");
                err = false;
                return str;
            }
        }
        return "";
    }

    public static int HandleUserMenuChoises(string msg)
    {
        bool err = false;
        bool isValid = false;

        while (!err || !isValid)
        {
            string str = Validator.GetString(msg);
            if (!Validator.CheckInt(str))
            {
                ConsoleEventing.Error("Not valid.");
                err = true;
            }
            else
            {
                int number = Int32.Parse(str);
                err = false;
                return number;
            }
        }
        return 200;
    }

    public static bool CheckInt(string input)
    {
        bool isValid = true;

        foreach (char c in input)
        {
            if (!Char.IsDigit(c))
                isValid = false;
        }
        return isValid;
    }

    public static int ValidateInt(string msg)
    {
        bool err = false;
        bool isValid = false;
        var number = 0;

        while (!err || !isValid)
        {
            string str = GetString(msg);
            if (!CheckInt(str))
            {
                ConsoleEventing.Error("Not valid.");
                err = true;
            }
            else
            {
                number = Int32.Parse(str);

                return number;
            }
        }
        return number;
    }

    public static bool CheckDecimal(string input)
    {
        Match m = Regex.Match(input, @"^-?[0-9]*\.?[0-9]+$");
        return m.Success && m.Value != "";
    }

    public static double ValidateDecimal(string msg)
    {
        bool err = false;
        bool isValid = false;

        while (!err || !isValid)
        {
            string str = Validator.GetString(msg);
            if (!Validator.CheckDecimal(str))
            {
                ConsoleEventing.Error("Not valid.");
                err = true;
            }
            else
            {
                double dec = double.Parse(str);
                err = false;
                return dec;
            }
        }
        return 0;
    }
}




