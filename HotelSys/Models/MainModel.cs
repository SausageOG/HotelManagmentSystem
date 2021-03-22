using System.Collections.ObjectModel;


namespace HotelSys.Models
{
    class MainModel
    {
        public Room room;


        private ObservableCollection<Room> _rooms;


        public ObservableCollection<Visitor> Visitors => room.Visitors;
        public ObservableCollection<Room> Rooms { get { return _rooms; } set { _rooms = value; } }

        public MainModel()
        {
            room = new Room();
        }
    }
}
