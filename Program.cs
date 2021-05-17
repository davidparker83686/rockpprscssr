using System;
using System.Collections.Generic;
using System.Threading;
using rockpprscssr.Models;

namespace rockpprscssr
{
  class Program
  {
    static void Main(string[] args)
    {
      // SECTION Number Game
      Console.Clear();
      Console.WriteLine("Lets Play ROCK PAPER SCISSORS! (Y/N)");
      char choice = Console.ReadKey().KeyChar;
      Console.WriteLine("");
      if (choice == 'y')
      {
        Console.WriteLine("Cool Cool");
      }
      else if (choice == 'n')
      {
        Console.WriteLine("Good Bye");
        // Console.cd /;
      }
      else
      {
        Console.WriteLine("Please pic (Y/N)");
      }
      bool running = true;
      while (running)
      {
        Console.Write("Alrighty! 3...2...1");
        int freq = 300;
        for (int i = 0; i < 6; i++)
        {
          Thread.Sleep(750);
          Console.Write('.');
          Console.Beep(freq, 200);
          freq += 50;
        }
        Console.Beep(850, 1500);
        Console.Clear();
        Game game = new Game();
        bool playing = true;
        while (playing)
        {

          Console.Write("What is your guess: ");
          string guess = Console.ReadLine();
          //   if (int.TryParse(guess, out int intGuess))
          //   if ("rock" || "paper" || "scissor")
          {
            // playing = !game.Guess(intRPS);
          }
          else
          {
            Console.WriteLine("Thats not even a number you bozo");
          }
        }
        System.Console.WriteLine("GG BRO");
        System.Console.WriteLine("Play again?");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        if (choice == 'y')
        {
          Console.WriteLine("Lets Play!");
        }
        else if (choice == 'n')
        {
          Console.WriteLine("Bye Loser!");
          running = false;
        }
        else
        {
          Console.WriteLine("Your Stupidity is upsetting, I'm done");
          running = false;
        }
      }












































//       Console.Clear();
//       Console.WriteLine("Lets Play ROCK PAPER SCISSORS!");
//       string choice = Console.ReadLine();
//       //   string choice = Console.ReadLine()KeyLine;
//       Console.WriteLine("");
//       bool running = true;
//       while (running)
//       {
//         {
//           Console.Write("Pick One(rock/paper/scissor)");
//           string guess = Console.ReadLine();
//         //   if (!rock || !paper || !scissor)
//           if (!"rock" || !"paper" || !"scissor")
//           {
//             playing = !game.Guess(intGuess);
//           }
//           else
//           {
//             Console.WriteLine("Please Pick rock paper or scissor");
//           }
//         }


//       }
//     }
//   }
// }
