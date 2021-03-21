namespace HotelSys
{
    class Visitor
    {
        private int _id;
        private string _name;
        private string _lastName;
        private int _age;
        private int _room;



        public Visitor() { }
        public Visitor(string name, string lastName, int age, int room)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
            _room = room;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public int Room
        {
            get { return _room; }
            set
            {
                _room = value;
            }
        }
    }
}
