using System.Reflection.PortableExecutable;
using System.Xml;
using Domain.Models;
using Newtonsoft.Json;

namespace Domain.Broker
{
    public static class Broker
    {
        static string pathh = "D:\\Projects\\Taxi\\Domain\\Broker\\Taxies.json";

        public static void AddTaxiToJson(Taxi taxi)
        {
            var taxies = Read();
            if(taxies == null)
                taxies = new List<Taxi>();
            taxies.Add(taxi);
            Write(taxies);
        }

        public static List<Taxi> ReadTaxiesFromJson()
        {
            return Read();
        }

        /*      public void UpdateFolder(Folder folder, string id)
              {
                  var shop = Read();
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

        public static void RemoveTaxiFromJson(Taxi taxi)
        {
            var taxies = Read();
            var ctaxi = taxies.FirstOrDefault(ct => ct.Number == taxi.Number);
            if(ctaxi != null)
            {
                taxies.Remove(ctaxi);
                Write(taxies);
                Console.WriteLine( "o'chdi");
            } else
            Console.WriteLine( "o'chmadi");
        }

        public static List<Taxi> Read()
        {
            var stringShop = File.ReadAllText(pathh);
            return JsonConvert.DeserializeObject<List<Taxi>>(stringShop);
        }

        public static void Write(List<Taxi> taxies)
        {
            var taxiesJson = JsonConvert.SerializeObject(taxies, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(pathh, taxiesJson);
        }
    }
}
