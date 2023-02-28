namespace Domain.Models
{
    public class LostTrip
    {
        public int Id { get; set; }
        public int TaxiId { get; set; }
        public int PassangerId { get; set; }
        public DateTime Create { get; set; }
    }
}
