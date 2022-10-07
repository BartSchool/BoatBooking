namespace BoatBooking.Class
{
    public class Day
    {
        List<Reservation>? Appointments { get; set; }
        public DateOnly Date { get; set; }

        public Day(DateOnly dt)
        {
            Date = dt;
        }
    }
}
