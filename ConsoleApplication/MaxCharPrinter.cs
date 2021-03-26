using System;

public class MaxCharPrinter
{
    static int ASCII_SIZE = 256;

    public char FindMaxChar(string input)
    {
        int[] count = BuildCharInt(input);
        char maxChar = GetMaxChar(count, input);

        return maxChar;
    }

    private int[] BuildCharInt(string str)
    {

        int[] count = new int[ASCII_SIZE];

        for (int i = 0; i < str.Length; i++)
        {
            int v = count[str[i]]++;
        }
        return count;

    }

    private char GetMaxChar(int[] intArr, string str)
    {
        int max = 0;
        char maxChar = ' ';

        for (int i = 0; i < str.Length; i++)
        {
            if (intArr[str[i]] > max)
            {
                max = intArr[str[i]];
                maxChar = str[i];
            }
        }
        return maxChar;
    }

    public void PrintMaxChar(string input)
    {
        Console.WriteLine(FindMaxChar(input));
    }

}




