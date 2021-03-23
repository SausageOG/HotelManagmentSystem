using System.Collections.Generic;

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
        private string _roomNum;
        private IList<Visitor> _visitors;


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
        public string RoomNumber
        {
            get { return _roomNum; }
            set
            {
                _roomNum = value;
            }
        }
        public IList<Visitor> Visitors
        {
            get { return _visitors; }
            set
            {
                _visitors = value;
            }
        }
        public Room()
        {
            _visitors = new List<Visitor>();
        }
    }
}
