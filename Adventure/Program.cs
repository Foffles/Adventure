using System;
using System.Linq;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure.BusinessObjects.Player Player = new Adventure.BusinessObjects.Player();
            Adventure.BusinessObjects.Hero Hero = new Adventure.BusinessObjects.Hero();
            Adventure.BusinessObjects.Dungeon Dungeon;
            string playerName;
            string heroName;
            string classId;


            Console.WriteLine("Enter your name:");
            playerName = Console.ReadLine();

            Player.populatePlayer(playerName);
            
            Console.WriteLine($"Welcome {Player.Name}. Please enter your hero's name for this run");
            heroName = Console.ReadLine();

            Console.WriteLine($"Please enter {heroName}'s class: \n   " + String.Join(Environment.NewLine + "   ", Hero.ClassNames.Select(d => $"{d.Key}: {d.Value}")));
            classId = Console.ReadLine();

            // Populating hero object
            switch (classId)
            {
                case "1":
                    {
                        Hero.populateHero(heroName, 1);
                        break;
                    }
                case "2":
                    {
                        Hero.populateHero(heroName, 2);
                        break;
                    }
                case "3":
                    {
                        Hero.populateHero(heroName, 3);
                        break;
                    }
                case "4":
                    {
                        Hero.populateHero(heroName, 4);
                        break;
                    }
                case "5":
                    {
                        Hero.populateHero(heroName, 5);
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Silly Rogue. No Cheating....");
                        Hero.populateHero(heroName, 5);
                        break;
                    }


            }

            Console.WriteLine($"{Hero.ToString()}");

            Console.WriteLine("Press any key to start your journey...");
            Console.ReadKey();

            // Add logic to pick a dungeon
            Dungeon = new Adventure.BusinessObjects.Dungeon(1);

            Dungeon.LaunchDungeon(Hero);


            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();


        }
    }
}
