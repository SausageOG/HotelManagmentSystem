namespace HotelSys.Models
{
    class Room
    {
        private int _id;
        private string _title;
        private int maxVisitors;


        public Visitor[] visitors;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
            }
        }


        public Room(string title)
        {

        }

    }
}
