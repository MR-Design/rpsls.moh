using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_
{
   
    class Game
    {


        private readonly int player1Choice;
        private readonly int player2Choice;

        public Game(int Player1Hand, int Player2Hand)
        {
            player1Choice = Player1Hand;
            player2Choice = Player2Hand;
            Play();
        }

        public void Play()
        {
            Console.WriteLine("Player1 Picks: \n " + player1Choice(Player1Hand));
            Console.WriteLine("Player2 Picks:\n  " + player2Choice(Player2Hand));
            Console.Write("    ");
            if (Player2Hand == Player1Hand) Console.WriteLine("Tie");
            switch (Player1Hand)
            {
                case 1:
                    if (Player2Hand == 4) Console.WriteLine("Rock crushes lizard. You win!");
                    else if (Player2Hand == 3) Console.WriteLine("Rock crushes scissors. You win!");
                    else if (Player2Hand == 2) Console.WriteLine("Paper covers rock. Computer wins!");
                    else if (Player2Hand == 5) Console.WriteLine("Spock vaporizes rock. Computer wins!");
                    break;

                case 2:
                    if (Player2Hand == 1) Console.WriteLine("Paper covers rock. You win!");
                    else if (Player2Hand == 5) Console.WriteLine("Paper disproves Spock. You win!");
                    else if (Player2Hand == 3) Console.WriteLine("Scissors cut paper. Computer wins!");
                    else if (Player2Hand == 4) Console.WriteLine("Lizard eats paper. Computer wins!");
                    break;

                case 3:
                    if (Player2Hand == 2) Console.WriteLine("Scissors cut paper. You win!");
                    else if (Player2Hand == 4) Console.WriteLine("Scissors decapitate lizard. You win!");
                    else if (Player2Hand == 5) Console.WriteLine("Spock smashes scissors. Computer wins!");
                    else if (Player2Hand == 1) Console.WriteLine("Rock crushes scissors. Computer wins!");
                    break;

                case 4:
                    if (Player2Hand == 5) Console.WriteLine("Lizard poisons Spock. You win!");
                    else if (Player2Hand == 2) Console.WriteLine("Lizard eats paper. You win!");
                    else if (Player2Hand == 1) Console.WriteLine("Rock crushes lizard. Computer wins!");
                    else if (Player2Hand == 3) Console.WriteLine("Scissors decapitate lizard. Computer wins!");
                    break;

                case 5:
                    if (Player2Hand == 3) Console.WriteLine("Spock smashes scissors. You win!");
                    else if (Player2Hand == 1) Console.WriteLine("Spock vaporizes rock. You win!");
                    else if (Player2Hand == 4) Console.WriteLine("Lizard poisons Spock. Computer wins!");
                    else if (Player2Hand == 2) Console.WriteLine("Paper disproves Spock. Computer wins!");
                    break;
            }

             string player1Choice(int Num)
            {
                switch (Num)
                {
                    case 1:
                        return "Rock";
                    case 2:
                        return "Paper";
                    case 3:
                        return "Scissor";
                    case 4:
                        return "Lizard";
                    case 5:
                        return "Spock";
                }
                return null;
            }














        }    }
}



            // In This Methods I need To Convert User Choices From my Users Data  to Interger ...
            // public string getUserHand;
            // constructor 
            // public Game()
            // {
            //     getUserHand = player1Choice;

// }



// Hands Rulles  Who win.
//enum UserChoice
// {
//   Rock = 1,
//   Paper = 2,
//  Scissors = 3,
//   Spock = 4,
//  Lizard = 5
// }
//  let d = (5 + a - b) % 5.Then:
//d = 1 or d = 3 => a wins
//  d = 2 or d = 4 => b wins
// d = 0 => tie



// int results = (5 + (hand1)-(hans2)) % 5;



// Methods for the score ...





// Methods to decied the Winner...