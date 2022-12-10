﻿using Microsoft.Data.Sqlite;

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
                createTableCmd.CommandText = "CREATE TABLE Passengers (PassengerId INTEGER, CruiseId INTEGER, PassengerName TEXT, PassportNumber INTEGER);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE CruisePorts (CruiseId INTEGER, PortId INTEGER);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE TripPassengers (TripId INTEGER, PassengerId INTEGER);";
                createTableCmd.ExecuteNonQuery();
                createTableCmd.CommandText = "CREATE TABLE CruisePassengers (CruiseId INTEGER, PassengerId INTEGER);";
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
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('005', 'Turkey');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('006', 'Venice');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('007', 'Cyprus');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('008', 'Croatia');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('009', 'Italy');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('010', 'Marseille');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('001', '001', 'White Water Rafting', '89.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('002', '002', 'Off-Road Biking', '59.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('003', '003', 'Sky-Diving', '159.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('004', '004', 'Gliding', '129.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('005', '005', 'Rock Climbing', '39.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('006', '006', 'Bungee Jumping', '199.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('007', '007', 'Hot Air Balloon Ride', '149.99' );";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Trips (TripId, PortId, TripName, TripPrice) VALUES ('008', '008', 'Kayaking', '69.99' );";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('001', '001', 'Sarah Smith', '829429838');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('002', '001', 'Michael Johnson', '465713765');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('003', '002', 'Jessica Williams', '975743534');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('004', '002', 'John Brown', '273649583');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('005', '003', 'Emily Jones', '983649267');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('006', '003', 'David Anderson', '274629475');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO Passengers (PassengerId, CruiseId, PassengerName, PassportNumber) VALUES ('007', '004', 'Ashley Davis', '465394753');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('001', '003');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('001', '007');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('001', '005');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('002', '007');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('002', '002');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('002', '004');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('003', '001');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('003', '002');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('003', '006');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('004', '005');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('004', '008');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePorts (CruiseId, PortId) VALUES ('004', '002');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('001', '001');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('001', '002');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('002', '003');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('002', '004');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('003', '005');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('003', '006');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('004', '007');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO CruisePassengers (CruiseId, PassengerId) VALUES ('004', '008');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('005', '001');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('002', '003');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('002', '005');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('006', '006');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('001', '006');";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO TripPassengers (TripId, PassengerId) VALUES ('008', '008');";
                    insertCmd.ExecuteNonQuery();


                    //createTableCmd.CommandText = "CREATE TABLE TripPassengers (TripId INTEGER, PassengerId INTEGER);";
                    //createTableCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }


        }
    }
}
