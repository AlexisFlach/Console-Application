using System;

public class CharacterModel
{
    public string Name;
    public int Helth;
    public int Strength;
    public int Luck;
    public CharacterType Type;

    Random rand = new Random();

    public CharacterModel(string name, CharacterType type)
    {
        this.Name = name;
        Helth = rand.Next(1, 10);
        Strength = rand.Next(1, 10);
        Luck = rand.Next(1, 10);
        Type = type;
    }
}




