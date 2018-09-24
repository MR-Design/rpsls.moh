using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players();

           player1.userInput();
            Console.ReadKey();
        }
    }
}
