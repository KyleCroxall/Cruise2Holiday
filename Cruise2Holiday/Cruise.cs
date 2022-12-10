namespace Cruise2Holiday {
    internal class Cruise {
        private string cruiseName;
        private List<Port> ports = new List<Port>();

        public string CruiseName {
            get { return cruiseName; }
            private set { cruiseName = value; }
        }

        public List<Port> Ports {
            get { return ports; }
            private set { ports = value; }
        }

        public Cruise(string cruiseName) { 
            CruiseName = cruiseName;
        }

        public void AddPort(Port port) {
            Ports.Add(port);
        }
    }
}
