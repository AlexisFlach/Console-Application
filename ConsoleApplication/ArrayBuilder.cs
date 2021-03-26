using System;
using System.Linq;

public class ArrayBuilder : Task
{
    TaskHandler handler;

    public int[] nums = new int[10];
    Random rand = new Random();

    public ArrayBuilder(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        nums = RandomArray(nums);
        Id = 11;
        Title = "Array Builder";
        Description = "Prints an array two times; one times in its original form, one time sorted.";

    }

    public int[] RandomArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 10);
        }
        return arr;
    }

    public int[] SortedArray(int[] arr)
    {
        return arr.OrderBy(i => i).ToArray();
    }

    public void PrintArr(int[] arr)
    {
        string list = "";
        foreach (var item in arr)
        {
            list += item + " ";
        }
        ConsoleEventing.Msg(list);
    }

    public override void Run()
    {
        PrintArr(nums);
        PrintArr(SortedArray(nums));
    }
}




