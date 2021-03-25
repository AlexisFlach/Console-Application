public interface ITask
{
    int TaskId { get; }
    string Title { get; set; }
    string Description { get; set; }
    void Run();
}




