namespace Infrastructure
{
    public class Taxi
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }

        public Passanger Passanger { get; set; } = null;
        public int stripNumber { get; set; }
    }
}
