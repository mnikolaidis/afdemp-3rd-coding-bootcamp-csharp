using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    // Simulation derives from PCGame but also derives from ComputerGame
    class Simulation : PCGame
    {
        public string Requirements { get; set; }
        public string Description { get; set; }
    }
}
