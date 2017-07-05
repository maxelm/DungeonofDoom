using DungeonsOfDoom.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Game
    {
        const int worldX = 20;
        const int worldY = 5;
        static int monsterCount = 0;
        static int itemCount = 0;

        Player player;
        Room[,] world;

        public void StartGame()
        {
            Console.Clear();
            TextUtils.Animate("Welcome to Dungeons of Doom!");
            Console.ReadKey(true);

            CreatePlayer();
            Play();
        }


        public void Play()
        {
            player.X = 0;
            player.Y = 0;
            CreateWorld();

            do
            {
                Console.Clear();
                DisplayStats();
                DisplayWorld();
                AskForAction();
                CollisionDetection();
            } while (player.Health > 0 && monsterCount > 0);

            if (player.Health > 0)
            {
                YouWin();
            }
            else
                GameOver();
        }

        private void YouWin()
        {
            Console.Clear();
            Console.WriteLine("YOU WIN!!!");
            Console.ReadKey(true);
            Play();
        }

        private void CollisionDetection()
        {
            Room currentRoom = world[player.X, player.Y];
            if (currentRoom.Monster != null)
            {
                Combat(currentRoom.Monster);
            }
            else if (currentRoom.Item != null)
            {
                GetItem(currentRoom.Item);
            }
        }

        private void GetItem(Item item)
        {
            Console.WriteLine($"\nYou found a {item.Name}!");
            Console.WriteLine(item.GetPickedUp(player)); //todo rename method. Getpickedup? manage/handle

            world[player.X, player.Y].Item = null;
            itemCount--;

            Console.ReadKey(true);
        }

        private void Combat(Monster opponent) //todo Add Combat Logic
        {

            int roundCounter = 1;
            Console.WriteLine($"\nA wild {Character.DisplayName(opponent)} appeared! Prepare yourself!"); //todo add name of class to message

            if (opponent.IsWillingToFight(player))
            {
                do
                {
                    Console.WriteLine($"Round: {roundCounter++}");
                    Console.WriteLine(player.Attack(opponent));

                    if (opponent.Health > 0)
                    {
                        Console.WriteLine(opponent.Attack(player));
                    }
                    Console.ReadKey(true);
                }
                while (player.Health > 0 && opponent.Health > 0);

                if (player.Health < 0)
                {
                    Console.WriteLine($"You've been slain by {Character.DisplayName(opponent)}");
                }
                else
                {
                    Console.WriteLine($"You slayed {Character.DisplayName(opponent)}");
                }
            }
            else
            {
                Console.WriteLine("You crushed your opponent leaving him no chance to strike back!"); //todo Add message or something else...
            }

            if (opponent.Health <= 0)
            {
                Console.WriteLine(world[player.X, player.Y].Monster.GetPickedUp(player));
                world[player.X, player.Y].Monster = null;
                monsterCount--;
            }

            Console.ReadKey(true);
        }

        void DisplayStats()
        {
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Damage: {player.Damage}\n");
        }

        private void AskForAction()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            int newX = player.X;
            int newY = player.Y;
            bool isValidMove = true;

            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                case ConsoleKey.B: DisplayBackpack(); break;
                default: isValidMove = false; break;
            }

            if (isValidMove &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;

                //player.HealthPool--; //todo Bestämma om man vill ha fatigue. Tog bort den for now.
            }
        }

        private void DisplayBackpack()
        {
            Console.Clear();
            Console.WriteLine($"Backpack:");
            foreach (var item in player.Backpack)
            {
                Console.WriteLine($"{item.DisplayName()}");

            }
            Console.ReadKey(true);
        }

        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write(player.DisplayChar);
                    else if (room.Monster != null)
                        Console.Write(room.Monster.DisplayChar);
                    else if (room.Item != null)
                        Console.Write(room.Item.DisplayChar);
                    else
                        Console.Write(room.DisplayChar);
                }
                Console.WriteLine();
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            StartGame();
        }

        private void CreateWorld()
        {
            world = new Room[worldX, worldY];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    if (player.X != x || player.Y != y)
                    {
                        if (RandomUtils.ChanceToCreate(10))
                        {
                            if (RandomUtils.ChanceToCreate(50))
                            {
                                world[x, y].Monster = new Orc(); //todo add random monster spawn. Spawnar bara goblins atm.
                            }
                            else
                            {
                                world[x, y].Monster = new Ogre();
                            }

                            monsterCount++; // tracks the amount of monsters created
                        }

                        if (RandomUtils.ChanceToCreate(10))
                        {

                            if (RandomUtils.ChanceToCreate(20)) // Justerade drop chansen för items, 20% svärd - 80% potion
                            {

                                world[x, y].Item = new Weapon("Sword", 10);
                            }
                            else
                            {
                                if (RandomUtils.ChanceToCreate(50))
                                    world[x, y].Item = new HealthPotion(); //todo randomize via reflection

                                else
                                    world[x, y].Item = new StrengthPotion();

                            }

                            itemCount++; // tracks the amount of Items created
                        }


                    }
                }
            }
        }

        private void CreatePlayer()
        {
            player = new Player(0, 0);
        }
    }
}
