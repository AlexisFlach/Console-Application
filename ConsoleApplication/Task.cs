//public interface ITask
//{
//    int TaskId { get; }
//    string Title { get; set; }
//    string Description { get; set; }
//    void Run();
//}

public abstract class Task
{
    protected int Id;
    protected string Title;
    protected string Description;

    public int GetId()
    {
        return Id;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        return Description;
    }

    public abstract void Run();
}

