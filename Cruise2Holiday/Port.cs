namespace Cruise2Holiday {
    internal class Port {
        private string portName;
        private List<Trip> trips = new List<Trip>();

        public string PortName {
            get { return portName; }
            private set { portName = value; }
        }

        public List<Trip> Trips {
            get { return trips; }
            private set { trips = value; }
        }

        public Port(string portName) { 
            PortName = portName;
        }

        public void AddTrip(Trip trip) {
            Trips.Add(trip);
        }
    }
}
