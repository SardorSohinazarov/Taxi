using Domain.Services;

namespace Domain.Models
{
    public class TaxiCompany
    {
        public void addTaxi() 
        {
            int id = int.Parse(Console.ReadLine());
            string phoneNumber = Console.ReadLine();
            string number = Console.ReadLine();
            string status = Console.ReadLine();
            var taxi = new Taxi(id)
            {
                Number = number,
                Status = status,
                PhoneNumber = phoneNumber
            };
            Broker.Broker.AddTaxiToJson(taxi);   
        }

        //shetta tel qiladi
        public void CallTaxiMoment()
        {
            var place = new Place
            {
                Id = Guid.NewGuid(),
                Tuman = Console.ReadLine(),
                Mahalla = Console.ReadLine(),
                Address = Console.ReadLine()
            };

            var passenger = new Passanger(place)
            {
                Id = Guid.NewGuid(),
                PhoneNumber = Console.ReadLine(),
            };

            //interface
            TaxiController controller = new TaxiController();
            var taxi = controller.callTaxi(passenger);
            taxi.stripNumber++;

            Broker.Broker.AddTaxiToJson(taxi);
        }

        public List<Taxi> getAvailable() 
        { 
            var list = Broker.Broker.ReadTaxiesFromJson();
            var availableTaxies = list.Where(taxi => taxi.Passanger == null).ToList();
            return availableTaxies;
        }

        public List<Trip> getTrips() => new List<Trip>();

        public List<Taxi> statsTaxi() => new List<Taxi>();

        public List<Place> statsDistricts() => new List<Place>();
    }
}
