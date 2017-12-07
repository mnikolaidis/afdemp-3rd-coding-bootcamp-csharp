using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    // PcGame is a kind of ComputerGame 
    // Inheritance example
    public class PCGame : ComputerGame
    {
        public string SteamID { get; set; }

        // We intend for the derived classes to make their own version of the virtual method Sell, specialized to this class
        // We can also just inherit a virtual method, it is not mandatory to override it
        public override void Sell()
        {
            // base calls the basic method Sell. Calling the base method is not required
            base.Sell();
            Console.WriteLine("My SerialNumber is {0}", SteamID);
        }
    }
}
