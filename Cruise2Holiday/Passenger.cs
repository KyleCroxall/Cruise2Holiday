namespace Cruise2Holiday {
    internal class Passenger {
        private string name;
        private int passportNum;
        private int passengerId;

        public string Name {
            get { return name; }
            private set { name = value; }
        }
        public int PassportNum {
            get { return passportNum; }
            private set { passportNum = value; }
        }

        public int PassengerId {
            get { return passengerId; }
            private set { passengerId = value; }
        }

        public Passenger(string name, int passportNum, int passengerId) {
            Name = name;
            PassportNum = passportNum;
            PassengerId = passengerId;
        }
    }
}
