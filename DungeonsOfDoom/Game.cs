using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Game
    {
        Player player;
        Room[,] world;
        Random random = new Random();

        public void Play()
        {
            CreatePlayer();
            CreateWorld();

            do
            {
                Console.Clear();
                DisplayStats();
                DisplayWorld();
                AskForMovement();
                CollisionDetection();
            } while (player.HealthPool > 0);

            GameOver();
        }

        private void CollisionDetection()
        {
            Room currentRoom = world[player.X, player.Y];
            if (currentRoom.Monster != null)
            {
                Combat();
            }
            else if (currentRoom.Item != null)
            {
                GetItem(currentRoom);
            }
        }

        private void GetItem(Room roomWithItem)
        {
            player.Backpack.Add(roomWithItem.Item);

            world[player.X, player.Y] = new Room();

            Console.WriteLine($"\nYou found a {roomWithItem.Item.Name}! {roomWithItem.Item.Name} was added to backpack.");
            Console.ReadKey(true);
        }

        private void Combat() //todo Add Combat Logic
        {
            Console.WriteLine($"A wild Monster appeared! FIGHT!");
            Console.ReadKey(true);
        }

        void DisplayStats()
        {
            Console.WriteLine($"Health: {player.HealthPool}");
        }

        private void AskForMovement()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int newX = player.X;
            int newY = player.Y;
            bool isValidMove = true;

            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
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
            Play();
        }

        private void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    if (player.X != x || player.Y != y)
                    {
                        if (random.Next(0, 100) < 10)
                            world[x, y].Monster = new Monster(30, 10);

                        if (random.Next(0, 100) < 10)
                        {

                            if (random.Next(0, 100) < 50)
                            {

                                world[x, y].Item = new Weapon("Sword", 10);
                            }
                            else
                            {
                                world[x, y].Item = new Potion("Healing Potion", 30);
                            }

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
