using HotelSys.Models;

namespace HotelSys
{
    class Visitor
    {
        private int _id;
        private string _name;
        private string _lastName;
        private int _age;
        private Room _visitorRoom;



        public Visitor() { }
        public Visitor(string name, string lastName, int age)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
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
        public Room Room
        {
            get { return _visitorRoom; }
            set
            {
                _visitorRoom = value;
            }
        }
    }
}
