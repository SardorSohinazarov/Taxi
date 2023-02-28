namespace Domain.Models
{
    public class Taxi
    {
        public Taxi(int id)
        {
            Id = id;
        }

        private int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }

        public Passanger Passanger { get; set; } = null;
        public int stripNumber { get; set; }

        //public Taxi beginTrip(Place dest) { }
        public void terminateTrip() { } // Bundan tashqari taksi  bo'sh taksilar  ro'yhating ohiriga qo'shiladi.
        public string toString() => "";
    }
}
