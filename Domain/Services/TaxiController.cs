using Domain.Models;

namespace Domain.Services
{
    public class TaxiController
    {
        public Taxi callTaxi(Passanger passanger)
        {
            TaxiCompany company = new TaxiCompany();
            var listofAvailableTaxies = company.getAvailable();
            var taxi = listofAvailableTaxies[0];
            Broker.Broker.RemoveTaxiFromJson(taxi);
            taxi.Passanger = passanger;
            return taxi;
        }
        public List<LostTrip> getLostTrips() => new List<LostTrip>();
    }
}
