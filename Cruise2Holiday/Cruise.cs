namespace Cruise2Holiday {
    internal class Cruise {
        private string cruiseName;
        private int cruiseId;
        private List<Port> ports = new List<Port>();

        public string CruiseName {
            get { return cruiseName; }
            private set { cruiseName = value; }
        }

        public int CruiseId {
            get { return cruiseId; }
            private set { cruiseId = value;}
        }

        public List<Port> Ports {
            get { return ports; }
            private set { ports = value; }
        }

        public Cruise(string cruiseName, int cruiseId) { 
            CruiseName = cruiseName;
            CruiseId = cruiseId;
        }

        public void AddPort(Port port) {
            Ports.Add(port);
        }
    }
}
