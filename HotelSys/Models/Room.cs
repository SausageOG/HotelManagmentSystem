using System.Collections.ObjectModel;

namespace HotelSys.Models
{
    public enum RoomType
    {
        StandardRoom,
        BusinessClassRoom,
        JuniorSuite,
        PresidentialSuite
    }
    class Room
    {
        private RoomType _roomType;
        private int _id;
        private string _title;
        private int _max;


        private ObservableCollection<Visitor> _visitors;
        public ObservableCollection<Visitor> Visitors { get { return _visitors; } set { _visitors = value; } }

        public RoomType Type
        {
            get { return _roomType; }
            set
            {
                _roomType = value;
            }
        }
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
            }
        }


        public Room(string title, int max)
        {
            _title = title;
            _max = max;
        }

        public void AddVisitor(Visitor visitor)
        {
            _visitors.Add(visitor);
        }
        public void DeleteVisitor(Visitor visitor)
        {
            _visitors.Remove(visitor);
        }
    }
}
