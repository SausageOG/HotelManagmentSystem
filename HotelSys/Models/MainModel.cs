using System.Collections.ObjectModel;


namespace HotelSys.Models
{
    class MainModel
    {
        public Room room;


        private ObservableCollection<Room> _rooms;
        private ObservableCollection<Visitor> _visitors;


        public ObservableCollection<Visitor> Visitors => _visitors;
        public ObservableCollection<Room> Rooms => _rooms;

        public MainModel()
        {
            room = new Room();
        }

        public void AddVisitor(Visitor visitor)
        {
            
        }

    }
}
