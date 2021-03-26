using System;

public class CharacterBuilder : Task
{
   
    TaskHandler handler;
    CharacterCollection characterCollection = new CharacterCollection();


    public CharacterBuilder(TaskHandler handler)
    {
        this.handler = handler;
        handler.RegisterTask(this);
        Id = 16;
        Title = "Character Creator";
        Description = "Create your hero, and your enemy!";
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

    public  override void Run()
    {
        CreateCharacter();
        CreateCharacter();
        characterCollection.PrintMenu();
    }
}




