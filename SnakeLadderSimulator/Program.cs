﻿namespace SnakeLadderSimulator
{ /// <summary>
  /// UC4 : Repeat till the Player reaches the winning position 100.
  /// In case the player position moves below 0, then the player restarts from 0
  /// </summary>
    public class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {
            int position = 0;

            //constant variable
            const int START_POSITION = 0;
            const int WINNING_POSITION = 100;


            Console.WriteLine("Welcome to the Snake and Ladder Simulator Program");
            Console.WriteLine("Mode : Single Player");
            Console.WriteLine("\nThe Position of your TOKEN in the board is START : " + START_POSITION);

            Random random = new Random(); //Creating Random class object to access Next function

            while (position != WINNING_POSITION)
            {
                int dieRoll = random.Next(1, 7); //using next function to generate number between 1 & 6
                Console.WriteLine("\nAfter Rolling die, Dice Number : " + dieRoll);
                int option = random.Next(1, 4); //Random function to generate options between 1 & 3

                //Creating object of CheckOption to access CheckPlayOption method
                ReturnPosition returnPositionObj = new ReturnPosition();
                position = returnPositionObj.ReturnCurrentPosition(option, dieRoll, position);

            }

        }

    }
}
