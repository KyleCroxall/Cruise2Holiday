namespace Cruise2Holiday {
    internal class Program {
        // Perhaps use Command pattern
        static void Main(string[] args) {
            if (File.Exists("./Cruises.db") != true) {
                SqlCommands.CreateNewDatabase();
            }

            //while(true) {
            //    Menu.DisplayMainMenu();
            //}

            //int nextPrimaryKey = SqlCommands.GetNextPrimaryKey("CruiseId", "Cruises");
            int nextPrimaryKey = SqlCommands.GetNextPrimaryKey("PortId", "Ports");

            //SqlCommands.AddCruise(nextPrimaryKey, "Testing of the Seas");
            //SqlCommands.AddPort(nextPrimaryKey, "Southampton");
            //Console.ReadKey();
            //SqlCommands.RemoveCruise(11);
            //SqlCommands.RemovePort(11);

            //Console.WriteLine("Next primary key to use in cruises is: " + nextPrimaryKey); 


            // Output ports here
            Console.WriteLine("Which port would you like to add a trip to?");
            string portSelected  = Console.ReadLine();
            SqlCommands.AddTripToPort(nextPrimaryKey, 8, "Testing trip", "69.99");
        }
    }
}