namespace Cruise2Holiday {
    internal class Program {
        // Perhaps use Command pattern
        static void Main(string[] args) {
            if (File.Exists("./Cruises.db") != true) {
                SqlCommands.CreateNewDatabase();
            }

            while(true) {
                Menu.DisplayMainMenu();
            }
        }
    }
}