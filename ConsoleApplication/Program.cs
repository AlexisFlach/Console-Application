partial class Program
{
        static void Main(string[] args)
    {
        var taskHandler = new TaskHandler();
        RegisterTasks(taskHandler);
        taskHandler.Run();
    }

    private static void RegisterTasks(TaskHandler handler)
    {
        var helloWorld = new HelloWorld(handler);
        var userProps = new UserProps(handler);
        var terminalColor = new TerminalColor(handler);
        var datePrinterte = new DatePrinter(handler);
        var largestNumberPrinter = new LargestNumberPrinter(handler);
        var numberGuesser = new NumberGuesser(handler);
        var writeFile = new FileStream(handler);
        var maxCharPrinter = new MaxChar(handler);
        var multiplicationTable = new MultiplicationTablePrinter(handler);
        var palindrome = new Palindrome(handler);
        var arrayBuilder = new ArrayBuilder(handler);
        var numberBetween = new NumbersBetween(handler);
        var math = new MathTask(handler);
        var printOddsAndEvens = new PrintOddsAndEvens(handler);
        var addNumbers = new AddNumbers(handler);
        var characterBuilder = new CharacterBuilder(handler);
    }
}




