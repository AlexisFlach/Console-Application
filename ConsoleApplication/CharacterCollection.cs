using System;
using System.Collections.Generic;
using System.Linq;

public class CharacterCollection
{
    public List<CharacterModel> Character = new List<CharacterModel>();

    public void AddCharacter(CharacterModel character)
    {
        Character.Add(character);
    }
    public void PrintMenu()
    {

        IEnumerable<CharacterModel> list = Character.OrderBy(task => task.Name);

        foreach (var character in list)
        {
            Console.WriteLine($"Name: {character.Name} Helth: {character.Helth} Strength: {character.Strength} Luck: {character.Luck} Type: {character.Type}");
        }
    }
}




