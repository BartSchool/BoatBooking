using BoatBooking.Class;

namespace BoatBooking.Models
{
    public class BoathouseViewModel
    {
        private readonly DataBase _dataBase = new DataBase();
        public Boat Boat { get; set; }
        public List<Boat> boats { get; set; }

        public BoathouseViewModel()
        {
            boats = _dataBase.GetBoatsFromDataBase();
            Boat = new Boat("test", "test");
        }
    }
}
