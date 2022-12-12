namespace Cruise2Holiday {
    internal class Program {
        static void Main(string[] args) {
            if (File.Exists("./Cruises.db") != true) {
                DatabaseManager.CreateNewDatabase();
            }

            CruiseManager admin = CruiseManager.GetInstance();
            admin.Start();
        }

        
    }
}