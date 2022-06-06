using System;

namespace CSharp_Day003_TreasureIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("Welcome to Treasure Island\n" +
                "Your mission is to find the treasure.\n");

            Console.WriteLine("");
            Console.WriteLine("You come to a fork in the path.\n" +
                "To the left leads to the river.\n" +
                "To the right leads to the woods.");

            while (true)
            {
                Console.WriteLine("Do you go <left> or <right>? ");
                answer = Console.ReadLine();
                if (answer == "left" || answer == "right")
                {
                    if (answer == "left")
                    {
                        Console.WriteLine("You're still alive!");
                    }
                    if (answer == "right")
                    {
                        Console.WriteLine("You get eaten by wolves! Game Over!");
                        Environment.Exit(0);
                    }
                    break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("You make your way to the river.\n" +
                "You see the river looks calm but it's wide." +
                "There is a dock near by but no boat.");

            while (true)
            {
                Console.WriteLine("Do you <swim> or <wait>?");
                answer = Console.ReadLine();
                if (answer == "swim" || answer == "wait")
                {
                    if (answer == "wait")
                    {
                        Console.WriteLine("You wait fo the boat amd make it safely across the river.");
                        break;
                    }
                    if (answer == "swim")
                    {
                        Console.WriteLine("The river is too rough uner the surface and drown. Game Over!");
                        Environment.Exit(0);
                    }
                    break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("You make it to a small stone building with 3 doors of different colors.");

            while (true)
            {
                Console.WriteLine("Do you choose the <red>, <yellow>, or <blue> door?");
                answer = Console.ReadLine();
                if (answer == "red" || answer == "yellow" || answer == "blue")
                {
                    if (answer == "red")
                    {
                        Console.WriteLine("You die in an inferno! Game Over!");
                        Environment.Exit(0);
                    }
                    if (answer == "yellow")
                    {
                        Console.WriteLine("You found a chest full of treasure! You win!");
                    }
                    if (answer == "blue")
                    {
                        Console.WriteLine("You die in an icy blizzard! Game Over");
                        Environment.Exit(0);
                    }
                    break;
                }
            }
        }
    }
}
