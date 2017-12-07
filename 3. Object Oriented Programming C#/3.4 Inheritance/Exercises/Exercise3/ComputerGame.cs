using System;

namespace Exercise3
{
    public class ComputerGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Overloading - Virtual method - We intend for this method to be overridden in the derived classes
        public virtual void Sell()
        {
            Console.WriteLine("Selling {0}", Name);
        }

        // static indicates that this is a class method, not an instance method
        public static ComputerGame GetGame()
        {
            // We don't have a Game to return, so for the purpose of the demo we create it innthe method and then return it
            var newGame = new ComputerGame()
            {
                Id = 9879,
                Name = "My Item"
            };

            return newGame;
        }
    }
}
