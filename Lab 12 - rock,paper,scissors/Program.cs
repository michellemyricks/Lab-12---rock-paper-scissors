﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12___rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine("Would you like to play against TheJets or TheSharks (j/s)?:");
            string userAnswer = Console.ReadLine();

            Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose,paper beat rock");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,scissors beat paper ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,rock beats scissors");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,rock beats scissors");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,paper beats rock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            Console.ReadLine();

        }
    }
}
