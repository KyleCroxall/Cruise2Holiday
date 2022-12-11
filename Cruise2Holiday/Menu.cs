﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruise2Holiday {
    internal static class Menu {
        public static void DisplayMainMenu() {
            Console.WriteLine("Welcome to the Cruise2Holiday Administration Menu!");
            Console.WriteLine();
            Console.WriteLine("Please select an option from the menu:");
            Console.WriteLine();
            Console.WriteLine("1. View Cruise");
            Console.WriteLine("2. Add Cruise to System");
            Console.WriteLine("3. Remove Cruise from System");
            Console.WriteLine("4. View List Of Ports");
            Console.WriteLine("5. Add Port to System");
            Console.WriteLine("6. Remove Port from System");
            Console.WriteLine("7. Exit");
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

        }

        public static void DisplayCruisesOnSystem(List<Cruise> cruises) {
            // Needs implementing
            Console.WriteLine(String.Format("{0, -10} {1, -20}", "CruiseID", "Cruise Name"));
            for (int i = 0; i < cruises.Count; i++) {
                Console.WriteLine(String.Format("{0, -10} {1, -20}", cruises[i].CruiseId, cruises[i].CruiseName));
            }
        }

        public static void DisplayPortsOnCruise(List<Port> ports) {
            // Needs implementing
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

        internal static void DisplayAddCruiseMenu() {
            Console.Clear();
            Console.WriteLine("Enter the name of the cruise you'd like to add (or type 'cancel' to cancel): ");
        }

        internal static void OutputReturningToPreviousMenu() {
            Console.WriteLine("Returning to previous menu");
        }
    }
}
