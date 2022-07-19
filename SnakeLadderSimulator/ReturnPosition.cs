using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{   //class to check option
    public class CheckOption
    {   //method to check for an option and move the token accordingly
        public void CheckPlayOption(int option, int dieRoll)
        {
            int position = 0;

            switch (option)
            {
                case 1: //No play
                    Console.WriteLine("Option : No Play");
                    position = position;
                    Console.WriteLine("Your Current Position : " + position);
                    break;
                case 2: //Ladder
                    Console.WriteLine("Option : Ladder");
                    position += dieRoll;
                    Console.WriteLine("Your Current Position : " + position);
                    break;
                default: //Snake
                    Console.WriteLine("Option : Snake");
                    position -= dieRoll;
                    Console.WriteLine("Your Current Position : " + position);
                    break;
            }

        }
    }
}