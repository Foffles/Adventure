using System;


namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure.BusinessObjects.Player Player = new Adventure.BusinessObjects.Player();
            Adventure.BusinessObjects.Hero Hero = new Adventure.BusinessObjects.Hero();

            string playerName;
            string heroName;
            string classId;


            Console.WriteLine("Enter your name:");
            playerName = Console.ReadLine();

            Player.populatePlayer(playerName);
            
            Console.WriteLine($"Welcome {Player.Name}. Please enter your hero's name for this run");
            heroName = Console.ReadLine();

            Console.WriteLine($"Please enter {heroName}'s class: \n 1: Warrior \n 2: Healer \n 3: Mage \n 4: Paladin \n 5: Rogue.");
            classId = Console.ReadLine();

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


            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();


        }


    }
}
