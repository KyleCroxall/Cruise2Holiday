using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruise2Holiday {
    internal class Validation {
        public static string invalidNumber = "{0} is not a value from {1} to {2} inclusive.";
        public static bool CheckIsValidIntInRange(string userInput, int min, int max) {
            int parsedInt;
            while (true) {
                if (int.TryParse(userInput, out parsedInt)) {
                    if (parsedInt < min || parsedInt > max) {
                        Console.WriteLine(invalidNumber, parsedInt, min, max);
                        return false;
                    } else {
                        return true;
                    }
                } else {
                    Console.WriteLine($"{userInput} is not a valid number. Please try again.");
                    return false;
                }
            }
        }
    }
}
