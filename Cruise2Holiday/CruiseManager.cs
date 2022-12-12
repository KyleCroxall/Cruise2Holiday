using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruise2Holiday {

    //TODO Could add validation inside RemoveCruise that checks if the integer added is present in the list of 
    internal sealed class CruiseManager {
        private CruiseManager() { 
        }

        private static CruiseManager cruiseManagerInstance;

        public static CruiseManager GetInstance() {
            if(cruiseManagerInstance == null) {
                cruiseManagerInstance = new CruiseManager();
            }
            return cruiseManagerInstance;
        }

        public void Start() {
            bool continueInteracting = true;
            while (continueInteracting) {
                Console.Clear();
                int selection;

                while (true) {
                    Menu.DisplayMainMenu();
                    string selectionInput = Console.ReadLine();
                    if (Validation.CheckIsValidIntInRange(selectionInput, 1, 7)) {
                        selection = int.Parse(selectionInput);
                        break;
                    } else {
                        Console.WriteLine("Invalid input, press any key to try again.");
                        Console.ReadKey();
                    }
                }

                switch (selection) {
                    case 1:
                        // Add Cruise
                        AddCruise();
                        break;
                    case 2:
                        // Remove Cruise
                        RemoveCruise();
                        break;
                    case 3:
                        // Add Port
                        AddPort();
                        break;
                    case 4:
                        // Remove Port
                        RemovePort();
                        break;
                    case 5:
                        // Add Port
                        
                        string nameOfPort = Console.ReadLine();
                        int portPrimaryKey = DatabaseManager.GetNextPrimaryKey("PortId", "Ports");
                        DatabaseManager.AddPort(portPrimaryKey, nameOfPort);
                        Console.WriteLine("Port added!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 6:
                        // Remove Port
                        Console.Clear();
                        Console.WriteLine("List Of Ports:");
                        Menu.OutputAllPorts(DatabaseManager.GetAllPorts());
                        Console.WriteLine("Enter the ID of the port you'd like to remove: ");
                        int portIdToRemove = int.Parse(Console.ReadLine());
                        DatabaseManager.RemovePort(portIdToRemove);
                        Console.WriteLine("Port removed!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 7:
                        // Exit
                        Console.WriteLine("Exiting program, press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void AddCruise() {
            Menu.DisplayAddCruiseString();
            string nameOfCruise = Console.ReadLine();
            if(nameOfCruise == "cancel") {
                Menu.OutputReturningToPreviousMenu();
                return;
            }
            int nextPrimaryKey = DatabaseManager.GetNextPrimaryKey("CruiseId", "Cruises");
            DatabaseManager.AddCruise(nextPrimaryKey, nameOfCruise);
            Menu.OutputCruiseAdded();
        }

        public void RemoveCruise() {
            Menu.OutputListOfCruisesString();
            Menu.DisplayCruisesOnSystem(DatabaseManager.GetAllCruises());
            bool cruiseFound = false;
            while(!cruiseFound) {
                Menu.OutputChooseCruiseToRemoveString();
                string userInput = Console.ReadLine();
                int selection;
                if (int.TryParse(userInput, out selection)) {
                    List<Cruise> cruises = DatabaseManager.GetAllCruises();
                    foreach(Cruise c in cruises) {
                        if(c.CruiseId == selection) {
                            DatabaseManager.RemoveCruise(selection);
                            Menu.OutputCruiseAdded();
                            cruiseFound = true;
                            break;
                        }
                    }
                    if(cruiseFound != true) {
                        Menu.OutputInvalidInputAlert();
                    }
                } else {
                    Menu.OutputInvalidInputAlert();
                }
            }

        }

        public void AddPort() {
            Menu.DisplayAddPortString();
            string nameOfPort = Console.ReadLine();
            if(nameOfPort == "cancel") {
                Menu.OutputReturningToPreviousMenu();
                return;
            }
            int nextPrimaryKey = DatabaseManager.GetNextPrimaryKey("PortId", "Ports");
            DatabaseManager.AddPort(nextPrimaryKey, nameOfPort);
            Menu.OutputPortAdded();
        }

        public void RemovePort() {
            Menu.OutputListOfPortsString();
            Menu.OutputAllPorts(DatabaseManager.GetAllPorts());
            bool portFound = false;
            while(!portFound) {
                Menu.OutputChoosePortToRemoveString();
                string userInput = Console.ReadLine();
                int selection;
                if (int.TryParse(userInput, out selection)) {
                    List<Port> ports = DatabaseManager.GetAllPorts();
                    foreach (Port p in ports) {
                        if (p.PortId == selection) {
                            DatabaseManager.RemovePort(selection);
                            Menu.OutputCruiseAdded();
                            portFound = true;
                            break;
                        }
                    }
                    if (portFound != true) {
                        Menu.OutputInvalidInputAlert();
                    }
                } else {
                    Menu.OutputInvalidInputAlert();
                }
            }
        }

        public void ViewPorts() {
            Menu.OutputListOfPortsString();
            Menu.OutputAllPorts(DatabaseManager.GetAllPorts());
            // Give ability to go further into next menus
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

    }
}
