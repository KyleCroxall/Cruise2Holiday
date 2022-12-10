namespace Cruise2Holiday {
    internal class Port {
        private string portName;
        private int portId;
        private List<Trip> trips = new List<Trip>();

        public string PortName {
            get { return portName; }
            private set { portName = value; }
        }

        public int PortId {
            get { return portId; }
            private set { portId = value; }
        }

        public List<Trip> Trips {
            get { return trips; }
            private set { trips = value; }
        }

        public Port(string portName, int portId) { 
            PortName = portName;
            PortId = portId;
        }

        public void AddTrip(Trip trip) {
            Trips.Add(trip);
        }
        
    }
}
