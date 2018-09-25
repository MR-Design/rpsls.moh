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

        public void userInput()
        {
            Console.WriteLine("Please Enter Your Name");
            string Player1 = Console.ReadLine();

            Console.WriteLine(Player1 + "Do you Have someone to play agains ?/n Tape Yes Or No");
            string numOfPlayers = Console.ReadLine();

            if (numOfPlayers == "No")
            {

                Console.WriteLine("Awsome you're gonna play the computer!! /n");
                Console.WriteLine(Player1 + "Please Chose a Hand");
                string player1Choice = Console.ReadLine();

            }
            else
            {

                Console.WriteLine("Please Enter Your Name");
                string Player2 = Console.ReadLine();
                Console.WriteLine(Player2 + "Please Chose a Hand");
                string player1Choice = Console.ReadLine();

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
