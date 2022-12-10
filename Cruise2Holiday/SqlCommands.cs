using Microsoft.Data.Sqlite;

namespace Cruise2Holiday {

    // TODO: Could remove nested using statements.
    // TODO: Add writelines for 'cruise added' or 'cruise removed' etc, would probably be best performed in the view class
    // TODO: May need validation adding to check if cruiseNum is present in the database in AddCruise method
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
                delTableCmd.CommandText = "DROP TABLE IF EXISTS CruisePorts;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS TripPassengers;";
                delTableCmd.ExecuteNonQuery();
                delTableCmd.CommandText = "DROP TABLE IF EXISTS CruisePassengers;";
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
                    insertCmd.CommandText = "INSERT INTO Ports (PortId, PortName) VALUES ('003', 'Athens');";
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

                    transaction.Commit();
                }
            }


        }

        public static void AddCruise(int nextPrimaryKey, string cruiseName) {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var insertCmd = connection.CreateCommand();

                insertCmd.CommandText = $"INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('{nextPrimaryKey}', '{cruiseName}');";
                insertCmd.ExecuteNonQuery();

                //using (var transaction = connection.BeginTransaction()) {
                //    var insertCmd = connection.CreateCommand();

                //    insertCmd.CommandText = $"INSERT INTO Cruises (CruiseId, CruiseName) VALUES ('{nextPrimaryKey}', '{cruiseName}');";
                //    insertCmd.ExecuteNonQuery();

                //    transaction.Commit();
                //}
            }
        }

        public static void RemoveCruise(int cruiseId) {
            
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var deleteCmd = connection.CreateCommand();

                deleteCmd.CommandText = $"DELETE FROM Cruises WHERE CruiseId = '{cruiseId}';";
                deleteCmd.ExecuteNonQuery();
            }
        }

        public static void AddPort(int nextPrimaryKey, string portName) {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var insertCmd = connection.CreateCommand();

                insertCmd.CommandText = $"INSERT INTO Ports (PortId, PortName) VALUES ('{nextPrimaryKey}', '{portName}');";
                insertCmd.ExecuteNonQuery();

            }
        }

        public static void RemovePort(int portId) {

            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var deleteCmd = connection.CreateCommand();

                deleteCmd.CommandText = $"DELETE FROM Ports WHERE PortId = '{portId}';";
                deleteCmd.ExecuteNonQuery();
            }
        }

        public static void AddTripToPort(int nextPrimaryKey, int portId, string tripName, string tripPrice) {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var insertCmd = connection.CreateCommand();

                insertCmd.CommandText = $"INSERT INTO Trips (TripId, PortID, TripName, TripPrice) VALUES ('{nextPrimaryKey}', '{portId}', '{tripName}', '{tripPrice}');";
                insertCmd.ExecuteNonQuery();

            }
        }

        public static void RemoveTripFromPort(int tripId, int portId) {

            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./Cruises.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var deleteCmd = connection.CreateCommand();

                deleteCmd.CommandText = $"DELETE FROM Trips WHERE TripId = '{tripId}' AND PortId = '{portId}';";
                deleteCmd.ExecuteNonQuery();
            }
        }

        public static int GetNextPrimaryKey(string primaryKeyField, string tableName) {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./Cruises.db";
            int nextKey = 0;

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = $"SELECT MAX({primaryKeyField}) + 1 AS next_id FROM {tableName};";

                using (var reader = selectCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        nextKey = reader.GetInt32(0);
                    }
                }
            }
            return nextKey;
        }

        // Returns a list of port objects with their corresponding names and portids
        public static List<Port> GetPortsOnCruise(int cruiseId) {
            List<Port> portsOnCruise = new List<Port>();




            return portsOnCruise;
        }

        public static string GetPortNameById(int portId) {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./Cruises.db";
            string portName = null;

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString)) {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = $"SELECT PortName FROM Ports WHERE PortId = '{portId}';";

                using (var reader = selectCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        portName = reader.GetString(0);
                    }
                }
            }
            return portName;
        }
    }
}
