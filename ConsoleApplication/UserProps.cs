public class UserProps : ITask
{
    public int TaskId { get; private set; } = 2;
    public string Title { get; set; } = "User Props";
    public string Description { get; set; } = "Prints user info";

    TaskHandler handler;
  
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public int Age { get; protected set; }

    public UserProps(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public void Reset()
    {
        FirstName = "";
        LastName = "";
        Age = -1;
    }

    public void Run()
    {
        FirstName = Validator.ValidateString(FirstName, "Please enter your first name");
        LastName = Validator.ValidateString(LastName, "Please enter your last name");
        Age = Validator.ValidateInt("Please enter your age");
        ConsoleEventing.Msg($"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}");
        Reset();
    }
}




