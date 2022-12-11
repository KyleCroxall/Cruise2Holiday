namespace Cruise2Holiday {
    internal class Program {
        // Perhaps use Command pattern
        static void Main(string[] args) {
            if (File.Exists("./Cruises.db") != true) {
                DatabaseManager.CreateNewDatabase();
            }

            CruiseManager admin = CruiseManager.GetInstance();

            admin.Start();
            

            
        }

        //public static void ContinueInteractingWithMenu() {
        //    bool continueInteracting = true;
        //    while (continueInteracting) {
        //        Console.Clear();
        //        int selection;

        //        while (true) {
        //            Menu.DisplayMainMenu();
        //            string selectionInput = Console.ReadLine();
        //            if (Validation.CheckIsValidIntInRange(selectionInput, 1, 7)) {
        //                selection = int.Parse(selectionInput);
        //                break;
        //            } else {
        //                Console.WriteLine("Invalid input, press any key to try again.");
        //                Console.ReadKey();
        //            }
        //        }

        //        switch(selection) {
        //            case 1:
        //                // View Cruise

        //                break;
        //            case 2:
        //                // Add Cruise
        //                Console.Clear();
        //                Console.WriteLine("Enter the name of the cruise you'd like to add: ");
        //                string nameOfCruise = Console.ReadLine();
        //                int cruisePrimaryKey = DatabaseManager.GetNextPrimaryKey("CruiseId", "Cruises");
        //                DatabaseManager.AddCruise(cruisePrimaryKey, nameOfCruise);
        //                Console.WriteLine("Cruise added!");
        //                Console.WriteLine();
        //                Console.WriteLine("Press any key to continue.");
        //                Console.ReadKey();
        //                break;
        //            case 3:
        //                // Remove Cruise
        //                Console.Clear();
        //                Console.WriteLine("List Of Cruises:");
        //                Menu.DisplayCruisesOnSystem(DatabaseManager.GetAllCruises());
        //                Console.WriteLine("Enter the ID of the cruise you'd like to remove: ");
        //                int cruiseIdToRemove = int.Parse(Console.ReadLine());
        //                DatabaseManager.RemoveCruise(cruiseIdToRemove);
        //                Console.WriteLine("Cruise removed!");
        //                Console.WriteLine();
        //                Console.WriteLine("Press any key to continue.");
        //                Console.ReadKey();
        //                break;
        //            case 4:
        //                // View Ports
        //                Console.Clear();
        //                Console.WriteLine("List Of Cruises:");
        //                Menu.OutputAllPorts(DatabaseManager.GetAllPorts());
        //                // Give ability to go further into next menus
        //                Console.WriteLine();
        //                Console.WriteLine("Press any key to continue.");
        //                Console.ReadKey();
        //                break;
        //            case 5:
        //                // Add Port
        //                Console.Clear();
        //                Console.WriteLine("Enter the name of the port you'd like to add: ");
        //                string nameOfPort = Console.ReadLine();
        //                int portPrimaryKey = DatabaseManager.GetNextPrimaryKey("PortId", "Ports");
        //                DatabaseManager.AddPort(portPrimaryKey, nameOfPort);
        //                Console.WriteLine("Port added!");
        //                Console.WriteLine();
        //                Console.WriteLine("Press any key to continue.");
        //                Console.ReadKey();
        //                break;
        //            case 6:
        //                // Remove Port
        //                Console.Clear();
        //                Console.WriteLine("List Of Ports:");
        //                Menu.OutputAllPorts(DatabaseManager.GetAllPorts());
        //                Console.WriteLine("Enter the ID of the port you'd like to remove: ");
        //                int portIdToRemove = int.Parse(Console.ReadLine());
        //                DatabaseManager.RemovePort(portIdToRemove);
        //                Console.WriteLine("Port removed!");
        //                Console.WriteLine();
        //                Console.WriteLine("Press any key to continue.");
        //                Console.ReadKey();
        //                break;
        //            case 7:
        //                // Exit
        //                Console.WriteLine("Exiting program, press any key to exit");
        //                Console.ReadKey();
        //                Environment.Exit(0);
        //                break;
        //        }
        //    }
        //}
    }
}