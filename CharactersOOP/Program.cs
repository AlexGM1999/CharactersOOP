using CharactersOOP.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CharactersOOP
{
    class Program
    {
        private static Character player1Character;
        private static Character player2Character;
        private static CharacterContext characterContext = new CharacterContext();

        static void Main(string[] args)
        {
            ModeSelection();
        }

        static void CreateNewCharacter()
        {
            Console.WriteLine("Character Name:");
            string characterName = Console.ReadLine();
            Console.WriteLine("Character Health:");
            int characterHealth = int.Parse(Console.ReadLine());
            Console.WriteLine("Character Attack:");
            int characterAttack = int.Parse(Console.ReadLine());
            Console.WriteLine("Create (y/n)");
            if (Console.ReadLine() == "y")
            {
                Character character = new Character(characterHealth, characterAttack, characterName);

                characterContext.Add(character);
                characterContext.SaveChanges();

            }
            ModeSelection();
        }

        static void ChooseCharacter()
        {
            List<Character> characterList = characterContext.Characters.ToList();

            int i = 1;
            foreach (var character in characterList)
            {
                Console.WriteLine($"{i} - {character.Name}: Attack {character.Attack} Health {character.Health}");
                i++;
            }
            Console.WriteLine("Player1 Character:");
            player1Character = characterList[int.Parse(Console.ReadLine()) - 1];
        }

        static void ModeSelection()
        {
            Console.WriteLine("Create new character: 1");
            Console.WriteLine("Choose a character: 2");
            int mode = int.Parse(Console.ReadLine());

            switch (mode)
            {
                case 1:
                    CreateNewCharacter();
                    break;
                case 2:
                    ChooseCharacter();
                    break;
            }
        }
    }
}
