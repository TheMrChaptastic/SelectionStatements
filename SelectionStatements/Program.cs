using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.Write("Guess a number: ");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
            Console.WriteLine();
            Console.Write("Favorite School Subject: ");
            var userStr = Console.ReadLine();
            switch (userStr.ToLower())
            {
                case "history":
                    Console.WriteLine($"Getting lost in the past in {userStr} huh?");
                    break;
                case "band":
                    Console.WriteLine($"Ahhh {userStr}! I played the trombone.");
                    break;
                case "math":
                    Console.WriteLine($"Ouch I kinda stunk at {userStr}.");
                    break;
                case "english":
                    Console.WriteLine($"Oh wow! I can hardly speak {userStr}.");
                    break;
                case "science":
                    Console.WriteLine($"Ohh {userStr} we got a scientist here.");
                    break;
                default:
                    Console.WriteLine($"huh... {userStr}, I must have missed that class.");
                    break;
            }
        }
    }
}
