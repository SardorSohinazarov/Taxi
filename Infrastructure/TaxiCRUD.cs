using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class TaxiCRUD {
        static string pathh = "D:\\Projects\\Taxi\\Application\\TAXICOMPANY.json";

        public void AddTaxi(Domain.Models.Taxi taxi)
        {
            var newTaxi = new Taxi()
            {
                Number = taxi.Number,
                Passanger = taxi.Passanger,
                PhoneNumber = taxi.PhoneNumber,
                Status = taxi.Status,
                stripNumber = taxi.stripNumber,
            };
            var taxies = Read();
            taxies.Add(taxi);
            Write(taxies);
        }

        /*        public string ReadFolder()
                {
                    return JsonConvert.SerializeObject(Read(), Newtonsoft.Json.Formatting.Indented);
                }
        */
       /* public void UpdateFolder(Taxi taxi, string id)
        {
            var taxies = Read();
            taxies =
            var updatingfolder = shop.folders.FirstOrDefault(folder => folder.containerId == id);
            updatingfolder = folder;
            Write(shop);
        }

        public void DeleteFolder(string id)
        {
            var shop = Read();
            var deletingfolder = shop.folders.FirstOrDefault(folder => folder.containerId == id);
            shop.folders.Remove(deletingfolder);
            Write(shop);
        }*/


        public List<Taxi> Read()
        {
            var stringListofTaxi = File.ReadAllText(pathh);
            return JsonConvert.DeserializeObject<List<Taxi>>(stringListofTaxi);
        }

        public void Write(List<Taxi> taxies)
        {
            var jsonTaxies = JsonConvert.SerializeObject(taxies, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(pathh, jsonTaxies);
        }


    }
}
