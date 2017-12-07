using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // in this scenario we can see how objects iteract with each other
            var newStockRoom = new StockRoom("StockRoom 1", 1);
            ComputerGame foundComputerGame = newStockRoom.FindAndReturnComputerGame(654);
            Console.WriteLine("ComputerGame Found is {0}", foundComputerGame.Name);

            var mySimulation = new Simulation();
            // a new simulation can have its own properties, PcGame's properties and ComputerGame's properties
            mySimulation.Id = 6565444;

            // Assign a new Simulation to a ComputerGame, but we only get the ComputerGame part of the Simulation
            ComputerGame mySecondSimulation = new Simulation();
            mySecondSimulation.Id = 6786;

            // Casting - Change the object back to the type we know it is
            Simulation myThirdSimulation = mySecondSimulation as Simulation;
            string simDescription = myThirdSimulation.Description;

            myThirdSimulation.Name = "My Simulation";
            myThirdSimulation.Sell();

            Adventure myAdventure = new Adventure
            {
                Name = "my Adventure",
                SteamID = "43242355"
            };
            myAdventure.Sell();

            //ComputerGame someGame = new ComputerGame();
            // Calling the static method
            ComputerGame newGame = ComputerGame.GetGame();
            Console.WriteLine("ID = {0}, Name = {1}", newGame.Id, newGame.Name);
        }
    }
}
