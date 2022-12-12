using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruise2Holiday {
    internal static class Menu {
        //public static void DisplayMainMenu() {
        //    Console.WriteLine("Welcome to the Cruise2Holiday Administration Menu!");
        //    Console.WriteLine();
        //    Console.WriteLine("Please select an option from the menu:");
        //    Console.WriteLine();
        //    Console.WriteLine("1. View Cruise");
        //    Console.WriteLine("2. Add Cruise to System");
        //    Console.WriteLine("3. Remove Cruise from System");
        //    Console.WriteLine("4. View List Of Ports");
        //    Console.WriteLine("5. Add Port to System");
        //    Console.WriteLine("6. Remove Port from System");
        //    Console.WriteLine("7. Exit");
        //}

        public static void DisplayMainMenu() {
            Console.WriteLine("Welcome to the Cruise2Holiday Administration Menu!");
            Console.WriteLine();
            Console.WriteLine("Please select an option from the menu:");
            Console.WriteLine();
            Console.WriteLine("1. Add Cruise");
            Console.WriteLine("2. Remove Cruise");
            Console.WriteLine("3. Add Port");
            Console.WriteLine("4. Remove Port");
            Console.WriteLine("5. Add Trip To Port");
            Console.WriteLine("6. Remove Trip From Port");
            Console.WriteLine("7. Add Port To Cruise");
            Console.WriteLine("8. Remove Port From Cruise");
            Console.WriteLine("9. Add Passenger To Cruise");
            Console.WriteLine("10. Remove Passenger From Cruise");
            Console.WriteLine("11. Add Passenger To Trip");
            Console.WriteLine("12. Remove Passenger From Trip");
            Console.WriteLine("13. Exit");
        }
        public static void DisplayCruiseMenu() {
            Console.WriteLine("Welcome to the Cruise2Holiday Administration Menu!");
            Console.WriteLine();
            Console.WriteLine("Please select an option from the menu:");
            Console.WriteLine();
            Console.WriteLine("1. View Ports on Cruise");
            Console.WriteLine("2. Add Port to Cruise");
            Console.WriteLine("2. Remove Port from Cruise");
            Console.WriteLine("3. View Trips on Cruise");
            Console.WriteLine("4. Add Trip to Cruise");
            Console.WriteLine("4. Remove Trip from Cruise");
            Console.WriteLine("3. View Passengers on Cruise");
            Console.WriteLine("3. Add Passenger to Cruise");
            Console.WriteLine("3. Remove Passenger from Cruise");
            Console.WriteLine("5. Exit");
        }

        public static void DisplayTripsOnCruise(int cruiseId) {

<<<<<<< HEAD
=======
        }

        public static void DisplayCruisesOnSystem(List<Cruise> cruises) {
            // Needs implementing
            Console.WriteLine(String.Format("{0, -10} {1, -20}", "CruiseID", "Cruise Name"));
            for (int i = 0; i < cruises.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20}", cruises[i].CruiseId, cruises[i].CruiseName));
            }
>>>>>>> ba6669bbe374c3c1684f4c2c2a8d5590d9539b0c
        }

        public static void DisplayCruisesOnSystem(List<Cruise> cruises) {

            Console.WriteLine(String.Format("{0, -10} {1, -20}", "CruiseID", "Cruise Name"));
            for (int i = 0; i < cruises.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20}", cruises[i].CruiseId, cruises[i].CruiseName));
            }
        }

        public static void OutputAllPorts(List<Port> ports) {
            Console.WriteLine(String.Format("{0, -10} {1, -20}", "PortID", "Port Name"));
            for (int i = 0; i < ports.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20}", ports[i].PortId, ports[i].PortName));
            }
        }

        public static void OutputTripsAtPort(List<Trip> trips) {
            Console.WriteLine("Trips At Port:");
            Console.WriteLine();
            Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -20}", "TripID", "Trip Name", "Trip Cost"));
            for (int i = 0; i < trips.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -20}", trips[i].TripId, trips[i].TripName, trips[i].Cost));
            }
        }

        public static void OutputTripsOnCruise(List<List<Trip>> trips) {
            Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -20}", "Trip ID", "Trip Name", "Trip Cost"));
            for (int i = 0; i < trips.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20} {2, -20}", trips[i][0].TripId, trips[i][0].TripName, trips[i][0].Cost));
            }
        }
<<<<<<< HEAD

        internal static void DisplayAddCruiseString() {
            Console.Clear();
            Console.WriteLine("Enter the name of the cruise you'd like to add (or type 'cancel' to cancel): ");
        }

        internal static void DisplayAddPortString() {
            Console.Clear();
            Console.WriteLine("Enter the name of the port you'd like to add (or type 'cancel' to cancel): ");
        }

        internal static void DisplayAddTripNameString() {
            Console.Clear();
            Console.WriteLine("Enter the name of the trip you'd like to add (or type 'cancel' to cancel): ");
        }

        internal static void DisplayAddTripPriceString() {
            Console.WriteLine("Enter the price (or type 'cancel' to cancel):");
        }

        internal static void OutputReturningToPreviousMenu() {
            Console.WriteLine("Returning to previous menu, press any key.");
            Console.ReadKey();
        }

        internal static void OutputInvalidInputAlert() {
            Console.WriteLine("Invalid input, press any key to try again.");
            Console.ReadKey();
        }

        internal static void OutputCruiseAdded() {
            Console.WriteLine("Cruise added!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        internal static void OutputCruiseRemoved() {
            Console.WriteLine("Cruise removed!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        internal static void OutputTripAdded() {
            Console.WriteLine("Trip added!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }


        internal static void OutputTripRemoved() {
            Console.WriteLine("Trip removed!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        internal static void OutputPortAdded() {
            Console.WriteLine("Port added!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        internal static void OutputPortRemoved() {
            Console.WriteLine("Port removed!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        internal static void OutputListOfCruisesString() {
            Console.Clear();
            Console.WriteLine("List Of Cruises:");
        }

        internal static void OutputListOfPortsString() {
            Console.Clear();
            Console.WriteLine("List Of Ports:");
        }

        internal static void OutputChooseCruiseToRemoveString() {
            Console.WriteLine("Enter the ID of the cruise you'd like to remove: ");
        }

        internal static void OutputChoosePortToRemoveString() {
            Console.WriteLine("Enter the ID of the port you'd like to remove: ");
        }

        internal static void OutputChooseTripToRemoveString() {
            Console.WriteLine("Enter the ID of the trip you'd like to remove (or type 'cancel' to cancel): ");
        }

        internal static void OutputChoosePortToAddTripToString() {
            Console.WriteLine("Enter the ID of the port you'd like to add a trip to: ");
        }

        
=======
>>>>>>> ba6669bbe374c3c1684f4c2c2a8d5590d9539b0c
    }
}
