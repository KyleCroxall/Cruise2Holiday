using Microsoft.Data.Sqlite;

namespace Cruise2Holiday {
    internal static class SqlCommands {
        public static void CreateNewDatabase() {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var delTableCmd = connection.CreateCommand();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS Cruises;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS Ports;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS Trips;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS Passengers;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS PassengerTrips;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS CruisePorts;";
                delTableCmd.ExecuteNonQuery();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = "CREATE TABLE Cruises (CruiseId INTEGER, CruiseName TEXT);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE Ports (PortId INTEGER, PortName TEXT);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE Trips (TripId INTEGER, PortId INTEGER, CruiseId INTEGER, TripName TEXT, TripPrice TEXT);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE Passengers (PassengerId INTEGER, PassengerName TEXT, PassportNumber INTEGER);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE PassengerTrips (PassTripId INTEGER, PassengerId INTEGER);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE CruisePorts (CruisePortId INTEGER, CruiseId INTEGER, PortId INTEGER);";
                createTableCmd.ExecuteNonQuery();

                using (var transaction = connection.BeginTransaction()) {
                    var insertCmd = connection.CreateCommand();

                    insertCmd.CommandText = "INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('001', 'Oasis of the Seas');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('002', 'Allure of the Seas');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('003', 'Liberty of the Seas');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('004', 'Mariner of the Seas');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('001', 'Palma de Mallorca');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('002', 'Barcelona');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('003', 'Athens);";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('004', 'Greece');";
                    insertCmd.ExecuteNonQuery();


                    insertCmd.CommandText = "INSERT INTO Tutor (TutorId, Password, FullName, Email) VALUES ('tut001', 'password1', 'Albus Dumbledore', 'albusdumbledore@hull.ac.uk');";
                    insertCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }


        }
    }
}
