using System.Collections.Generic;

public class TaskHandler : ITaskHandler
{
    public List<ITask> Task = new List<ITask>();

    public void RegisterTask(ITask task)
    {
        Task.Add(task);
    }

    public void SetActiveTask()
    {
        Menu.SetActive(Task);
    }
    public void Run()
    {
        SetActiveTask();
    }
}




