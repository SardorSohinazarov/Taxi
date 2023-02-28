namespace Domain.Models
{
    public class Passanger //Passenger klassi konstructori Place ob'yekti qabul qiladi.
    {
        public Passanger(Place place)
        {
            CurrentPlace = place;
        }
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        private Place CurrentPlace { get; set; }
        public string getPlace() =>
            CurrentPlace.toString();
    }
}
