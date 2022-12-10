namespace Cruise2Holiday {
    internal class Passenger {
        private string name;
        private int passportNum;

        public string Name {
            get { return name; }
            private set { name = value; }
        }
        public int PassportNum {
            get { return passportNum; }
            private set { passportNum = value; }
        }

        public Passenger(string name, int passportNum) {
            Name = name;
            PassportNum = passportNum;
        }
    }
}
