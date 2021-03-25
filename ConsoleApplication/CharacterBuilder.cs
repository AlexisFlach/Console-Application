using System;

public class CharacterBuilder : ITask
{
    public int TaskId { set; get; } = 16;
    public string Title { get; set; } = "Character Creator";
    public string Description { get; set; } = "Create your hero, and your enemy!";
    TaskHandler handler;
    CharacterCollection characterCollection = new CharacterCollection();


    public CharacterBuilder(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
    }

    public void CreateCharacter()
    {
        string input = Validator.GetString("Name:");
        CharacterType type = SetCharacterType();
        CharacterModel character = new CharacterModel(input, type);
        ConsoleEventing.Success("Character created");
        characterCollection.AddCharacter(character);
    }

    public CharacterType SetCharacterType()
    {
        Console.WriteLine("Is your character good or evil? [Good, Evil, neutral*]");

        string answer = Console.ReadLine().ToUpper();

        if (answer == "GOOD")
        {
            return CharacterType.Good;
        }
        else if (answer == "EVIL")
        {
            return CharacterType.Evil;
        }
        else
        {
            return CharacterType.Neutral;
        }


    }

    public void Run()
    {
        CreateCharacter();
        CreateCharacter();
        characterCollection.PrintMenu();
    }
}




