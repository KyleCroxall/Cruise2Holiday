namespace Cruise2Holiday {
    internal class Trip {
        private double cost;
        private string tripName;
        private int tripId;
        private List<Passenger> passengers = new List<Passenger>();
        public double Cost { 
            get { return cost; } 
            private set { cost = value; } 
        }
        public string TripName {
            get { return tripName; }
            private set { tripName = value; }
        }
        public int TripId {
            get { return tripId; }
            private set { tripId = value; }
        }
        public List<Passenger> Passengers {
            get { return passengers; }
            private set { passengers = value; }
        }
        public Trip(double cost, string tripName, int tripId) {
            Cost = cost;
            TripName = tripName;
            TripId = tripId;
        }
        public void AddPassenger(Passenger passenger) {
            // Check if necessary, validation may need performing before adding passenger
            // SqlCommands.CheckIfPassengerExists...
        }
    }
}
