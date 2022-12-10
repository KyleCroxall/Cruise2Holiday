using System;
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
    }
}
