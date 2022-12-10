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
                createTableCmd.CommandText = "CREATE TABLE Trips (TripId INTEGER, PortId INTEGER, TripName TEXT, TripPrice TEXT);";
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

                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('001', '001', 'White Water Rafting', '89.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('002', '001', 'Off-Road Biking', '59.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('003', '002', 'Sky-Diving', '159.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('004', '002', 'Gliding', '129.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('005', '003', 'Rock Climbing', '39.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('005', '003', 'Bungee Jumping', '199.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('005', '004', 'Hot Air Balloon Ride', '149.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripsId, PortId, TripName, TripPrice) VALUES ('005', '004', 'Kayaking', '69.99' );";
                    insertCmd.ExecuteNonQuery();


                    transaction.Commit();
                }
            }


        }
    }
}
