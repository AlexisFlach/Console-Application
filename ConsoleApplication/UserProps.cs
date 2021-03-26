public class UserProps : Task
{
    TaskHandler handler;
  
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public int Age { get; protected set; }

    public UserProps(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 2;
        Title = "User Props";
        Description = "Prints user info";
    }

    public void Reset()
    {
        FirstName = "";
        LastName = "";
        Age = -1;
    }

    public override void Run()
    {
        FirstName = Validator.ValidateString(FirstName, "Please enter your first name");
        LastName = Validator.ValidateString(LastName, "Please enter your last name");
        Age = Validator.ValidateInt("Please enter your age");
        ConsoleEventing.Msg($"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}");
        Reset();
    }
}




