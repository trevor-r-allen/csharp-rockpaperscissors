using System;
using csharp_rockpaperscissors.Models;

namespace csharp_rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int losses = 0;
            int draws = 0;
            bool running = true;
            Game game = new Game();
            // void setDefaultColors()
            // {
            // Console.BackgroundColor = ConsoleColor.Black;
            // Console.ForegroundColor = ConsoleColor.White;
            // };
            static string hydro()
            {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return "HYDRO";
            };
            static string cryo()
            {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return "CRYO";
            };
            static string pyro()
            {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return "PYRO";
            };
            

            while (running)
            {
    
            Console.WriteLine(@"
  ______ _      ______ __  __ ______ _   _ _______       _        __  __           _____ _______ ______ _______     __
 |  ____| |    |  ____|  \/  |  ____| \ | |__   __|/\   | |      |  \/  |   /\    / ____|__   __|  ____|  __ \ \   / /
 | |__  | |    | |__  | \  / | |__  |  \| |  | |  /  \  | |      | \  / |  /  \  | (___    | |  | |__  | |__) \ \_/ / 
 |  __| | |    |  __| | |\/| |  __| | . ` |  | | / /\ \ | |      | |\/| | / /\ \  \___ \   | |  |  __| |  _  / \   /  
 | |____| |____| |____| |  | | |____| |\  |  | |/ ____ \| |____  | |  | |/ ____ \ ____) |  | |  | |____| | \ \  | |   
 |______|______|______|_|  |_|______|_| \_|  |_/_/    \_\______| |_|  |_/_/    \_\_____/   |_|  |______|_|  \_\ |_|   
                                                                                                                      
                                                                                                                      
            ");
            Console.WriteLine(@"
            PYRO beats CRYO, CRYO beats HYDRO, HYDRO beats PYRO
            Press P to play PYRO, press H to play HYDRO, press C to play CRYO
            Press Q to QUIT
            
            
            ");
            ConsoleKeyInfo choice = Console.ReadKey();
            if(choice.Key ==  ConsoleKey.P)
            {
                string move = game.generateComputerMove();
                if (move == "HYDRO")
                {
                    Console.WriteLine($"{hydro()} beats {pyro()} DEFEAT");
                    losses++;
                }
                else if (move == "CRYO")
                {
                    Console.WriteLine($"{pyro()} beats {cryo()} VICTORY");
                    wins++;
                }
                else
                {
                    Console.WriteLine($"{pyro()} ties {pyro()} DRAW");
                    draws++;
                }
            }
            else if(choice.Key ==  ConsoleKey.C)
            {
                string move = game.generateComputerMove();
                if (move == "HYDRO")
                {
                    Console.WriteLine($"{cryo()} beats {hydro()} VICTORY");
                    wins++;
                }
                else if (move == "CRYO")
                {
                    Console.WriteLine($"{cryo()} ties {cryo()} DRAW");
                    draws++;
                }
                else
                {
                    Console.WriteLine($"{pyro()} beats {cryo()} DEFEAT");
                    losses++;
                }
            }
            else if(choice.Key ==  ConsoleKey.H)
            {
                string move = game.generateComputerMove();
                if (move == "HYDRO")
                {
                    Console.WriteLine($"{hydro()} ties {hydro()} DRAW");
                    draws++;
                }
                else if (move == "CRYO")
                {
                    Console.WriteLine($"{cryo()} beats {hydro()} DEFEAT");
                    losses++;
                }
                else
                {
                    Console.WriteLine($"{hydro()} beats {pyro()} VICTORY");
                    wins++;
                }
            }
            else if (choice.Key ==  ConsoleKey.Q)
            {
                Console.WriteLine($"Wins: {wins} Losses: {losses} Draws: {draws}");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid input, please select an available option");
            }
          
          }


        }
    }
}
