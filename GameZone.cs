﻿using System;
using System.Collections.Generic;

namespace RPSLS
{
    class GameZone
    {

        //// GameZone Variables player1 and player2
        /// GameZone Methods //member varible
        Human player1;
        Player player2;
        List<string> options = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });

        //constructor
        public GameZone()
        {
            DisplayRules();
            player1 = new Human();
            GameMenu();
        }
        //If unfamiliar with rules see here


        public void DisplayRules()
        {
            Console.WriteLine("Here are your rules for this game!");
            Console.WriteLine("\nThis game is called, Rock,Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("The winner is the one who defeats the others best 2 of 3 rounds.");
            Console.WriteLine("In a tie, the round is repeated until a winner is found.");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors\n");
        }

        public void GameMenu()
        {
            Console.WriteLine("For player vs computer, enter 1");
            Console.WriteLine("For player vs player, enter 2.");
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":
                    /*Player enters 1 then start Player vs NonPlayer*/
                    Console.WriteLine("You entered 1");
                    player2 = new NonPlayer();
                    Rounds();
                    break;
                case "2":
                    //if player enters 2 then start Player vs Player
                    Console.WriteLine("You entered 2");
                    player2 = new Human();
                    Rounds();
                    break;
                default:
                    Console.WriteLine("Invalid entry, press 1 or 2.\n");
                    GameMenu();
                    break;
            }
        }

        public void CompareTurns()
        {

            int player1turn = player1.UserInput();
            int player2turn = player2.UserInput();

            if (player1turn == player2turn) // Display A Tie Here
            {
                Console.WriteLine("It's a Tie! Go again!");
            }
            else if (player1turn == 0)
            {
                if (player2turn == 2 || player2turn == 3)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player2.score++;
                }
            }
            else if (player1turn == 1)
            {
                if (player2turn == 0 || player2turn == 4)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player1.score++;

                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player2.score++;

                }
            }
            else if (player1turn == 2)
            {
                if (player2turn == 1 || player2turn == 3)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player1.score++;

                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player2.score++;

                }
            }
            else if (player1turn == 3)
            {
                if (player2turn == 1 || player2turn == 4)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player1.score++;

                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player2.score++;

                }
            }
            else if (player1turn == 4)
            {
                if (player2turn == 0 || player2turn == 2)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player1.score++;

                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " picked " + options[player2turn]);
                    player2.score++;

                }
            }
        }
        public void Rounds()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                CompareTurns();
            }
            if (player1.score == 2)
            {
                Console.WriteLine(player1.name + " Wins the match!");

            }
            else
            {
                Console.WriteLine(player2.name + " Wins! the match");
            }
        }


    }
}




