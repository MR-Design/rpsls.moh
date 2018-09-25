using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_
{
    class Players
    {
// Asking User If they Wanna Play Agains Computer OR Friend.

// Asking User  Names

        public  Players()
        {
        }


        // User Input Methods || Here I collect All Data From Users...
        public void UserInput()
        {
            Console.WriteLine("Please Enter Your Name");
            string Player1 = Console.ReadLine();

            Console.WriteLine(Player1 + "Do you Have someone to play against ?/n Tape Yes Or No");
            string numOfPlayers = Console.ReadLine();

            if (numOfPlayers == "No")
            {

                Console.WriteLine("Awsome !! you're gonna play the computer!! /n");
                Console.WriteLine(Player1 + "Please Chose a hand (1)Rock (2)Paper (3)Scissor (4)Lizard (5)Spock");
                int player1Choice = Convert.ToInt32(Console.ReadLine());

            }
            else
            {

                Console.WriteLine("Please Enter Your Name");
                string Player2 = Console.ReadLine();
                Console.WriteLine(Player2 + "Please Chose a hand (1)Rock (2)Paper (3)Scissor (4)Lizard (5)Spock");
                int player2Choice = Convert.ToInt32(Console.ReadLine());

            }


        }







      //  public string PlayerChoice()
     //   {
        
          //  Console.WriteLine("Please Chose a hand");
         //   string PlayersChoice = Console.ReadLine();
         //   return PlayersChoice;

       // }






    }
}
