using System.Collections.Generic;

public class TaskHandler : ITaskHandler
{
    protected List<Task> Tasks = new List<Task>();


    public void RegisterTask(Task task)
    {
        Tasks.Add(task);
    }

    public void SetActiveTask()
    {
        Menu<Task>.SetActive(Tasks);
    }
    public void Run()
    {
        SetActiveTask();
    }
}




