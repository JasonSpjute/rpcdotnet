using System;
using System.Threading;
namespace rpcdotnet
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] comp = new string[3];
            comp[0] = "Rock";
            comp[1] = "Paper";
            comp[2] = "Scissors";
            bool running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine(@"
__________               __     __________                                _________      .__                                  
\______   \ ____   ____ |  | __ \______   \_____  ______   ___________   /   _____/ ____ |__| ______ _________________  ______
 |       _//  _ \_/ ___\|  |/ /  |     ___/\__  \ \____ \_/ __ \_  __ \  \_____  \_/ ___\|  |/  ___//  ___/  _ \_  __ \/  ___/
 |    |   (  <_> )  \___|    <   |    |     / __ \|  |_> >  ___/|  | \/  /        \  \___|  |\___ \ \___ (  <_> )  | \/\___ \ 
 |____|_  /\____/ \___  >__|_ \  |____|    (____  /   __/ \___  >__|    /_______  /\___  >__/____  >____  >____/|__|  /____  >
        \/            \/     \/                 \/|__|        \/                \/     \/        \/     \/                 \/ 
            ");
                Console.WriteLine(@"
        Press R for Rock, P for Paper, S for Scissors, or q to quit.        
                ");
                ConsoleKeyInfo choice = Console.ReadKey();
                if (choice.Key == ConsoleKey.R)
                {
                    string player = "Rock";
                    Random r = new Random();
                    int genRand = r.Next(0, 3);
                    string compChoice = comp[genRand];
                    System.Console.WriteLine("You Chose Rock");
                    Thread.Sleep(1500);
                    Console.WriteLine($"The computer chose {compChoice}");
                    Thread.Sleep(1500);
                    if (player == compChoice)
                    {
                        Console.Write("It's a Tie");
                        Thread.Sleep(1500);
                    }
                    else if (player)

                }
                else if (choice.Key == ConsoleKey.P)
                {
                    Console.WriteLine("You chose Paper");
                    Thread.Sleep(1500);

                }
                else if (choice.Key == ConsoleKey.S)
                {
                    Console.WriteLine("You chose Scissors");
                    Thread.Sleep(1500);

                }
                else if (choice.Key == ConsoleKey.Q)
                {
                    running = false;
                }
                else
                {
                    System.Console.WriteLine("Invalid Command");
                    Thread.Sleep(1500);
                }

            }
        }
    }
}
