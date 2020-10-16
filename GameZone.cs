using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RPSLS
{
    class GameZone
    {

        //// GameZone Variables playerOne and playerTwo
        /// GameZone Methods //member varible
        Human playerOne;
        Player playerTwo;
        List<string> options = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });

        //constructor
        public GameZone()
        {
            DisplayRules();
            player1 = new Human();
            GameMenu();

            //If unfamiliar with rules see here
        public void DisplayRules()
            {Console.WriteLine("Here are your rules for this game!");
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




        }
        public void CompareTurns()
        {

            int playerOneturn = playerOne.UserInput();
            int playerTwoturn = playerTwo.UserInput();

            if (playerOneturn == playerTwoturn)
            {   //Display a Tie
                Console.WriteLine("It's a Tie! Go again!");
            }


