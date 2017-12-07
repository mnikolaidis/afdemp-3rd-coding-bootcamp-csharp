namespace Exercise3
{
    class StockRoom
    {
        // Properties
        public int Id { get; set; }
        public string StockRoomName { get; set; }

        // Constructor that initializes all properties
        public StockRoom(string name, int Id)
        {
            StockRoomName = name;
            // we use the keyword this which is a reference to the current object 
            this.Id = Id;
        }

        // Method that takes parameter an ID that finds and returns a ComputerGame
        public ComputerGame FindAndReturnComputerGame(int ComputerGameID)
        {
            // For Demo purpose we create the object in here, normally we would have searced in a db 
            ComputerGame returnGame = new ComputerGame()
            {
                Id = ComputerGameID,
                Name = "My Game"
            };

            return returnGame;
        }
    }
}
