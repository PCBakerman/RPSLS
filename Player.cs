using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {   //Member Variables
        public string name;
        public int score = 0;
        //Constructor
        public Player()
        {

        }


        //methods 


        //get choice from user 
        public int UserInput()
        {
            Console.WriteLine(name + " Please enter your weapon");
            Console.WriteLine("Enter 0 for Rock");
            Console.WriteLine("Enter 1 for Paper");
            Console.WriteLine("Enter 2 for Scissors");
            Console.WriteLine("Enter 3 for Lizard");
            Console.WriteLine("Enter 4 for Spock\n");

            int weapon = Convert.ToInt32(Console.ReadLine());
            return weapon;




        }
    }
}


