using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    // ConsoleGame derives from ComputerGame
    // This is a (is - a) relationship
    // ConsoleGame Inherits properties from ComputerGame and add the things that is specialized to the ConsoleGames
    class ConsoleGame : ComputerGame
    {
        public string SerialNumber { get; set; }

        public override void Sell()
        {
            //base.Sell();
            Console.WriteLine("My ISBN is {0}", SerialNumber);
        }
    }
}
