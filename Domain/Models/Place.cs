namespace Domain.Models
{
    public class Place
    {
        public Guid Id { get; set; }
        public string Tuman { get; set; }
        public string Mahalla { get; set; }
        public string Address { get; set; }

        public string toString() => $"{Tuman},{Mahalla},{Address}";
    }
}
