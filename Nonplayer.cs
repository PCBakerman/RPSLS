using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class NonPlayer : Player
    {
        public NonPlayer()
        {
            name = "Computer";
        }
        public override int UserInput()
        {
            Random num = new Random();
            int NonPlayerTurn = num.Next(0, 5);
            return NonPlayerTurn;


        }






    }
}
