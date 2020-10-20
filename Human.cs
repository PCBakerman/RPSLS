using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {

        public Human()
        {
            Console.WriteLine("Please enter youre name!");
            name = Console.ReadLine();


        }
    }
}
