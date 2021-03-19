namespace HotelSys
{
    class Visitor
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _female;
        public string Female { get { return _female; } set { _female = value; } }

        private int _age;
        public int Age { get { return _age; } set { _age = value; } }

        private int _room;
        public int Room { get { return _room; } set { _room = value; } }
        public Visitor() { }
        public Visitor(string name, string female, int age, int room)
        {
            _name = name;
            _female = female;
            _age = age;
            _room = room;
        }
    }
}
